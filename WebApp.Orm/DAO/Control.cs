//---------------------------------------------------------------------------------
// <copyright file="Control.cs" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//---------------------------------------------------------------------------------
namespace WebApp.Orm.DAO
{
    /// <summary>
    /// Entity class that represents control.
    /// </summary>
    public class Control
    {
        /// <summary>
        /// Gets or sets control identifier.
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// Gets or sets control name.
        /// </summary>
        public string Name{ get; set; }
        /// <summary>
        /// Gets or sets type of control.
        /// </summary>
        public string Type { get; set; }

    }
}

