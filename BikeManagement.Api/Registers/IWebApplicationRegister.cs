namespace BikeManagement.Api.Registers
{
    public interface IWebApplicationRegister : IRegister
    {
        public void RegisterPipelineComponents(WebApplication app);
    }
}
