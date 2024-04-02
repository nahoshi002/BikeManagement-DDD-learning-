using BikeManagement.Api.Registers;

namespace BikeManagement.Api.Extentions
{
    public static class RegisterExtention
    {
        public static void RegisterServices(this WebApplicationBuilder builder, Type scanningType)
        {
            var registers = GetRegisters<IWebApplicationBuilderRegister>(scanningType);

            foreach (var register in registers)
            {
                register.RegisterServices(builder);
            }
        }

        public static void RegisterPipelineComponents(this WebApplication app, Type scanningType)
        {
            var registrars = GetRegisters<IWebApplicationRegister>(scanningType);
            foreach (var registrar in registrars)
            {
                registrar.RegisterPipelineComponents(app);
            }
        }

        private static IEnumerable<T> GetRegisters<T>(Type scanningType)
            where T : IRegister
        {
            return scanningType.Assembly
                .GetTypes()
                .Where(t => t.IsAssignableTo(typeof(T)) && !t.IsAbstract && !t.IsInterface)
                .Select(Activator.CreateInstance)
                .Cast<T>();
        }
    }
}
