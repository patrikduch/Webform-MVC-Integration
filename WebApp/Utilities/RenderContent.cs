namespace WebApp.Utilities
{
    using System.IO;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.UI;
    using WebApp.Controls;
    using WebApp.Models;

      
    /// <summary>
    /// Render helper for MVC integration into with Webforms
    /// </summary>
    public class RenderContent
    {

        /// <summary>
        /// Render view by ViewContext
        /// </summary>
        /// <param name="viewContext"></param>
        /// <returns></returns>
        public string RenderView(ViewContext viewContext)
        {
            var response = viewContext.HttpContext.Response;
            response.Flush();
            var oldFilter = response.Filter;
            Stream filter = null;
            try
            {
                filter = new MemoryStream();
                response.Filter = filter;
                viewContext.View.Render(viewContext, viewContext.HttpContext.Response.Output);
                response.Flush();
                filter.Position = 0;
                var reader = new StreamReader(filter, response.ContentEncoding);
                return reader.ReadToEnd();
            }
            finally
            {
                filter?.Dispose();
                response.Filter = oldFilter;
            }
        }

        /// <summary>
        /// Render of Razor view without controller association
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public LiteralControl RenderRazor<T>(string fileName, T model) where T : IModelable
        {
            try
            {
                ViewContext context = MvcUtility.RenderPartial("~/ViewEngines/Razor/" + fileName + ".cshtml", model);
                return new LiteralControl(RenderView(context));
            }
            catch (HttpException)
            {
                return new LiteralControl("ERROR WITH LOADING CLASSIC RAZOR VIEW</br>");
            }
        }

        /// <summary>
        /// Render of webform control
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public Control RenderWebForm(string fileName)
        {
            try
            {
                TemplateControl template = new TestControl();
                return template.LoadControl("~/ViewEngines/Webform/" + fileName + ".ascx");
            }
            catch (HttpException)
            {
                 return new LiteralControl("ERROR WITH LOADING WEBFORM USER CONTROL</br>");
            }
        }

        /// <summary>
        /// Render of view (Razor page) based on incoming controller
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="controllerName">Name of controller</param>
        /// <param name="actionName">Action name</param>
        /// <param name="routeValues">Route values</param>
        /// <returns></returns>
        public LiteralControl RenderController(string controllerName, string actionName, object routeValues)
        {
            try
            {
                ViewContext context = MvcUtility.RenderAction(controllerName, actionName, routeValues);
                return new LiteralControl(RenderView(context));
            }
            catch (HttpException)
            {
                return new LiteralControl("ERROR WITH LOADING CONTROLLER AND VIEW</br>");
            }

        }

    }
}