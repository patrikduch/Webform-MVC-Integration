//---------------------------------------------------------------------------------
// <copyright file="DefaultController" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//--------------------------------------------------------------------------------

namespace WebApp.Models.ViewModels.MvcWebform
{
    /// <summary>
    /// Forwarded view model data
    /// </summary>
    public class RenderActionViewModel
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public object RouteValues { get; set; }
    }

}