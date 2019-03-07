﻿//---------------------------------------------------------------------------------
// <copyright file="IModelable" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//--------------------------------------------------------------------------------

namespace WebApp.Models
{
    /// <summary>
    /// Interface that must be implemented by every MVC model
    /// </summary>
    public interface IModelable
    {
        /// <summary>
        /// Gets or sets identifier.
        /// </summary>
        int Id { get; set; }
    }
}
