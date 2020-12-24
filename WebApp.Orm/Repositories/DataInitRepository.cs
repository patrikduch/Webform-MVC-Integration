using WebApp.Orm.Interfaces;
using WebApp.Orm.WebApp.Orm.Database;

namespace WebApp.Orm.Repositories
{
    using System.Data;
    using System.Data.SqlClient;

    /// <summary>
    /// Repository that initializes whole app data
    /// </summary>
    public class DataInitRepository : IDataInitRepository
    {
        #region Fields
        /// <summary>
        /// Instance of MSQL database
        /// </summary>
        private readonly Database _database;
        #endregion

        #region Constructors
        public DataInitRepository()
        {
            _database = new Database();
            _database.Connect();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Initialization data of whole application
        /// </summary>
        public void Initialization()
        {
            SqlCommand procedure = new SqlCommand("pr_DataInit", _database.Connection);
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.ExecuteReader();
            _database.Close();
        }
        #endregion

    }
}
