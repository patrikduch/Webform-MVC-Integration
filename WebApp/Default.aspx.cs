//---------------------------------------------------------------------------------
// <copyright file="Controller.cs" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//---------------------------------------------------------------------------------

namespace WebApp
{
    using System;
    using System.Data.SqlClient;
    using WebApp.Models;
    using WebApp.Utilities;
    using WebApp.Orm.Repositories;

    /// <summary>
    /// Webform start page
    /// </summary>
    public partial class Default : System.Web.UI.Page
    {
        private RenderContent _renderContent;
        protected void Page_Load(object sender, EventArgs e)
        {
            var dataInitRepository = new DataInitRepository();

            try
            {
                dataInitRepository.Initialization();

            }
            catch(SqlException)
            {
                dataInitRepository = null;
            }
           
            MvcRepository mvcRepository = new MvcRepository();
            ControlRepository controlRepository = new ControlRepository();
            _renderContent = new RenderContent();

            var controls = controlRepository.GetControls();

            foreach (var control in controls)
            {
                if (control.Type.Equals("Webform"))
                {
                    renderedContent.Controls.Add(_renderContent.RenderWebForm(control.Name));
                }
                else if (control.Type.Equals("Razor"))
                {
                    renderedContent.Controls.Add(_renderContent.RenderRazor(control.Name, new TestModel{ Id = 788}));

                } else if (control.Type.Equals("Controller"))
                {
                    var controller = mvcRepository.GetController(control.Name);
                    var views = mvcRepository.GetView(controller.Id);
                   
                    foreach (var view in views)
                    {
                        var routeValues = new object();

                        renderedContent.Controls.Add(_renderContent.RenderController(controller.ControllerName, view.ActionName, routeValues));
                    }
                }
            }
            
        }
    }
}