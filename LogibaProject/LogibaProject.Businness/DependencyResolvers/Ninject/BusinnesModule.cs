using Ninject.Modules;
using Ninject.Extensions.Conventions;
using System.Reflection;

namespace LogibaProject.Businness.DependencyResolvers.Ninject
{
    public class BusinnesModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind(x =>
            {
                x.FromThisAssembly()
                    .SelectAllClasses()
                    .BindAllInterfaces()
                    .Configure(t => t.InSingletonScope());

                x.From(Assembly.Load("LogibaProject.DataAccess"))
                    .SelectAllClasses()
                    .BindAllInterfaces()
                    .Configure(t => t.InSingletonScope());
            });
        }
    }
}
