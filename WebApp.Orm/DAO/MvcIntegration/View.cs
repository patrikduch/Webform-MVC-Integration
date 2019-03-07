//---------------------------------------------------------------------------------
// <copyright file="View.cs" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//---------------------------------------------------------------------------------
namespace WebApp.Orm.DAO.MvcIntegration
{
    /// <summary>
    /// Entity class that represents view.
    /// </summary>
    public class View
    {
        /// <summary>
        /// Gets or sets view identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets name of the action.
        /// </summary>
        public string ActionName { get; set; }

    }
}
