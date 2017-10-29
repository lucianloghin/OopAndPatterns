using Autofac;
using Autofac.Core;

namespace AutofacExample
{
    class AutoFacBootstrapper : Module
    {
        public static IContainer Init()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<UserHandler>().As<IUserHandler>();
            builder.RegisterType<BackupFactory>().As<IBackupFactory>();

            return builder.Build();
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
        }
    }
}