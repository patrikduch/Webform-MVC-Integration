//---------------------------------------------------------------------------------
// <copyright file="Controller.cs" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//---------------------------------------------------------------------------------
namespace WebApp.Orm.DAO.MvcIntegration
{
    /// <summary>
    /// Entity class that represents controller.
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// Gets or sets controller identifier.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets controller name.
        /// </summary>
        public string ControllerName { get; set; }
    }
}
