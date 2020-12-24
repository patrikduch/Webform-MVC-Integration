using System.Collections.Generic;
using WebApp.Orm.DAO.MvcIntegration;

namespace WebApp.Orm.Interfaces
{
    /// <summary>
    /// Interface for Mvc repository
    /// </summary>
    public interface IMvcRepository
    {
        /// <summary>
        /// Get controller from Db by controller name.
        /// </summary>
        /// <param name="controllerName">Name of controller</param>
        /// <returns>Controller instance</returns>
        Controller GetController(string controllerName);
        /// <summary>
        /// Get view by controller id
        /// </summary>
        /// <param name="controllerId">Id of controller</param>
        /// <returns></returns>
        List<View> GetView(int controllerId);
        /// <summary>
        /// Get model by conjunction of controller id and action name
        /// </summary>
        /// <param name="controllerId">Id of controller</param>
        /// <param name="actionName">Name of action</param>
        /// <returns></returns>
        Model GetModel(int controllerId, string actionName);
    }
}
