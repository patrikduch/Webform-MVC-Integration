namespace WebApp.Utilities
{
    using System;
    using System.Text;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;
    using WebApp.Controllers;
    using WebApp.Models.ViewModels.MvcWebform;

    /// <summary>
    /// MVC utility for integration into Webform
    /// </summary>
    public static class MvcUtility
    {
        /// <summary>
        /// Render of controller from MasterPage or Aspx (Webform)
        /// </summary>
        /// <param name="controllerName"></param>
        /// <param name="actionName"></param>
        /// <param name="routeValues"></param>
        /// <returns></returns>
        public static ViewContext RenderAction(string controllerName, string actionName, object routeValues)
        {
            return RenderPartial("PartialRender", new RenderActionViewModel() { ControllerName = controllerName, ActionName = actionName, RouteValues = routeValues });
        }
        public static ViewContext RenderPartial(string partialViewName, object model)
        {
            // Get Http context
            HttpContextBase httpContextBase = new HttpContextWrapper(HttpContext.Current);

            // Create route data that are  forwarded do the initial controller
            RouteData routeData = new RouteData();
            routeData.Values.Add("controller", typeof(TransitiveController).Name);
            
            // Create controller context
            ControllerContext controllerContext = new ControllerContext(new RequestContext(httpContextBase, routeData),
                new TransitiveController());

            // Find partial view
            IView view = FindPartialView(controllerContext, partialViewName);

            // Create the view context and pass in the routeValues
            ViewContext viewContext = new ViewContext(controllerContext, view, new ViewDataDictionary {Model = model}, new TempDataDictionary(), httpContextBase.Response.Output);

            // Return view
            return viewContext;
        }

        /// <summary>
        /// Search for partial view
        /// </summary>
        /// <param name="controllerContext">Controller context</param>
        /// <param name="partialViewName">Name of partial view</param>
        /// <returns></returns>
        private static IView FindPartialView(ControllerContext controllerContext, string partialViewName)
        {
            // Attempt to find partial view
            ViewEngineResult result = ViewEngines.Engines.FindPartialView(controllerContext, partialViewName);
            if (result.View != null)
            {
                return result.View;
            }

            // Partial view wasnt found
            var locationsText = new StringBuilder();
            foreach (var location in result.SearchedLocations)
            {
                locationsText.AppendLine();
                locationsText.Append(location);
            }

            throw new InvalidOperationException(
                $"Partial view {partialViewName} not found. Locations Searched: {locationsText}");
        }

    }
}