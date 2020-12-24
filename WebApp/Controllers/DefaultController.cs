namespace WebApp.Controllers
{
    using System.Web.Mvc;
    using WebApp.Models;

    /// <summary>
    /// MVC Test controller
    /// </summary>
    public class DefaultController : Controller
    {
        #region Actions

        public ActionResult Index()
        {
            var testModel = new TestModel { Id = 4 };

            return View(testModel);
        }
        #endregion
    }
}