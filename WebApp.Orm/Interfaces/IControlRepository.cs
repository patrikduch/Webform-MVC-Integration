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
