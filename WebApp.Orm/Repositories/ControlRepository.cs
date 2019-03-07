//---------------------------------------------------------------------------------
// <copyright file="ControlRepository.cs" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//---------------------------------------------------------------------------------

using WebApp.Orm.Interfaces;
using WebApp.Orm.WebApp.Orm.Database;
namespace WebApp.Orm.Repositories
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;

    /// <summary>
    ///  Repository for getting all controls.
    /// </summary>
    public class ControlRepository : IControlRepository
    {
        #region Fields
        /// <summary>
        /// Instance of MSQL database.
        /// </summary>
        private readonly Database _database;
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor for control repository.
        /// </summary>
        public ControlRepository()
        {
            _database = new Database();
            _database.Connect();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Get all controls (Razor page, MVC, Webforms).
        /// </summary>
        /// <returns></returns>
        public List<DAO.Control> GetControls()
        {

            var viewResult = new List<DAO.Control>();
            var procedure = new SqlCommand("pr_getControls", _database.Connection);
            procedure.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = null;
            dr = procedure.ExecuteReader();

            while (dr.Read()) // iterate through all records
            {
                viewResult.Add(new DAO.Control
                {
                    CId = int.Parse(dr["cId"].ToString()),
                    Name = dr["name"].ToString(),
                    Type = dr["type"].ToString()
                });
            }

            _database.Close();
            dr.Close();

            return viewResult.OrderByDescending(x => x.CId).ToList();
        }


        #endregion
    }
}
