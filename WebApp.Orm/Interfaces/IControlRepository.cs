//---------------------------------------------------------------------------------
// <copyright file="IControlRepository.cs" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//---------------------------------------------------------------------------------
namespace WebApp.Orm.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface for Control repository.
    /// </summary>
    public interface IControlRepository
    {
        /// <summary>
        /// Get all controls (Razor page, MVC, Webforms).
        /// </summary>
        /// <returns></returns>
        List<DAO.Control> GetControls();
    }
}
