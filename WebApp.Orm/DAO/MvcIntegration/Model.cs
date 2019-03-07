//---------------------------------------------------------------------------------
// <copyright file="Model.cs" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//---------------------------------------------------------------------------------
namespace WebApp.Orm.DAO.MvcIntegration
{
    /// <summary>
    /// Entity class that represents model.
    /// </summary>
    public class Model
    {
        /// <summary>
        /// Gets or sets model identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets model name.
        /// </summary>
        public string ModelName { get; set; }
    }
}
