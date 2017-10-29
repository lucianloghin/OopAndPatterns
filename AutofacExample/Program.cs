using System;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core.Lifetime;

namespace AutofacExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IContainer container = AutoFacBootstrapper.Init();
            
            IUserHandler startPoint = container.Resolve<IUserHandler>();
            startPoint.PerformSomeAction();
        }
    }
}
