//---------------------------------------------------------------------------------
// <copyright file="DefaultController" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//--------------------------------------------------------------------------------
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