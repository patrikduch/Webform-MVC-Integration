//---------------------------------------------------------------------------------
// <copyright file="IDataInitRepository.cs" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//---------------------------------------------------------------------------------
namespace WebApp.Orm.Interfaces
{
    /// <summary>
    /// Interface for Data repository.
    /// </summary>
    public interface IDataInitRepository
    {
        /// <summary>
        /// Data initialization of whole application
        /// </summary>
        /// <returns></returns>
        void Initialization();
    }
}
