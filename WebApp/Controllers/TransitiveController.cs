namespace WebApp.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    /// Initial controller.
    /// </summary>
    public class TransitiveController : Controller
    {
        /// <summary>
        /// Render partial view.
        /// </summary>
        /// <returns></returns>
        public ActionResult PartialRender()
        {
            return PartialView();
        }
    }
}