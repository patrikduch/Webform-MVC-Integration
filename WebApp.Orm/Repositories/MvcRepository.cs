//---------------------------------------------------------------------------------
// <copyright file="MvcRepository.cs" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//---------------------------------------------------------------------------------

using WebApp.Orm.DAO.MvcIntegration;
using WebApp.Orm.Interfaces;
using WebApp.Orm.WebApp.Orm.Database;

namespace WebApp.Orm.Repositories
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;

    /// <summary>
    /// Repository for getting MVC setup from database.
    /// </summary>
    public class MvcRepository : IMvcRepository
    {
        #region Fields

        /// <summary>
        /// Instance of MSQL database
        /// </summary>
        private readonly Database _database;

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor for Mvc repository
        /// </summary>
        public MvcRepository()
        {
            _database = new Database();
        }
        #endregion

        #region Methods

        /// <summary>
        /// Get controller from Db by controller name.
        /// </summary>
        /// <param name="controllerName">Name of controller</param>
        /// <returns>Controller instance</returns>
        public Controller GetController(string controllerName)
        {
            Controller controllerResult = null;

            _database.Connect();

            SqlCommand procedure = new SqlCommand("pr_getController", _database.Connection);
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.AddWithValue("@controllerName", controllerName);

            SqlDataReader dr = null;
            dr = procedure.ExecuteReader();

            while (dr.Read())
            {
                controllerResult = new Controller
                {
                    Id = int.Parse(dr["id"].ToString()),
                    ControllerName = dr["name"].ToString()
                };
            }

            _database.Close();

            dr.Close();

            return controllerResult;
        }
        /// <summary>
        /// Get view by controller id
        /// </summary>
        /// <param name="controllerId">Id of controller</param>
        /// <returns></returns>
        public List<View> GetView(int controllerId)
        {
            List<View> viewResult = new List<View>();

            _database.Connect();

            SqlCommand procedure = new SqlCommand("pr_getView", _database.Connection);
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.AddWithValue("@controllerId", controllerId);

            SqlDataReader dr = null;
            dr = procedure.ExecuteReader();

            while (dr.Read())
            {
                viewResult.Add(new View
                {
                    Id = int.Parse(dr["id"].ToString()),
                    ActionName = dr["name"].ToString()
                });
            }

            _database.Close();

            dr.Close();

            return viewResult;
        }

        /// <summary>
        /// Get model by conjunction of controller id and action name
        /// </summary>
        /// <param name="controllerId">Id of controller</param>
        /// <param name="actionName">Name of action</param>
        /// <returns></returns>
        public Model GetModel(int controllerId, string actionName)
        {
            Model modelResult = null;

            _database.Connect();

            SqlCommand procedure = new SqlCommand("pr_getModel", _database.Connection);
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.AddWithValue("@controllerId", controllerId);
            procedure.Parameters.AddWithValue("@actionName", actionName);

            SqlDataReader dr = null;
            dr = procedure.ExecuteReader();

            while (dr.Read())
            {
                modelResult = new Model
                {
                    Id = int.Parse(dr["modelId"].ToString()),
                    ModelName = dr["modelName"].ToString()
                };
            }

            _database.Close();
            dr.Close();

            return modelResult;
        }

        #endregion
    }
}
