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
