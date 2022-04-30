using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDI
{
    internal partial class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            RegisterHelper.Register(builder);
            Container = builder.Build();

            AutofacResigter();
            Console.ReadKey();
        }
        public static void AutofacResigter()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var writer2 = scope.Resolve<IValidator<ICustomer>>();
                var writer3 = scope.Resolve<IValidator<IEmployee>>();
                var writer6 = scope.Resolve<IValidator<IProduct>>();
                var writer1 = scope.Resolve<IValidator<IPerson>>();
                var writer4 = scope.Resolve<IEntity>();
                var writer5 = scope.Resolve<IPerson>();
                var writer11 = scope.Resolve<IProduct>();
                var writer12 = scope.Resolve<IEmployee>();
                var writer13 = scope.Resolve<ICustomer>();
            }
        }

    }

}
