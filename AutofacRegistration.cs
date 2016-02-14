using Autofac;
using System.Reflection;

namespace sample_AutofacAssemblyScanOrder
{
    public static class AutofacRegistration
    {
        public static IContainer Build()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces();
            return builder.Build();
        }
    }
}
