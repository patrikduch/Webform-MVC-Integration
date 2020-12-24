namespace WebApp.Models.ViewModels.MvcWebform
{
    /// <summary>
    /// Forwarded view model data
    /// </summary>
    public class RenderActionViewModel
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public object RouteValues { get; set; }
    }

}