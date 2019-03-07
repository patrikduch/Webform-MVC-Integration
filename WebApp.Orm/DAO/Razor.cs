//---------------------------------------------------------------------------------
// <copyright file="Razor.cs" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//---------------------------------------------------------------------------------
namespace WebApp.Orm.DAO
{
    /// <summary>
    /// Entity class that represents razor page without controller association.
    /// </summary>
    public class Razor
    {
        /// <summary>
        /// Gets or sets razor page identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets name of razor page.
        /// </summary>
        public string Name { get; set; }

  
        public string Type { get; set; }
    }
}
