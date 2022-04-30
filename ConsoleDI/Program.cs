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
                var validator1 = scope.Resolve<IValidator<IPerson>>();
                var validator2 = scope.Resolve<IValidator<ICustomer>>();
                var validator3 = scope.Resolve<IValidator<IEmployee>>();
                var validator4 = scope.Resolve<IValidator<IProduct>>();

                var entity = scope.Resolve<IEntity>();
                var person = scope.Resolve<IPerson>();
                var product = scope.Resolve<IProduct>();
                var employee = scope.Resolve<IEmployee>();
                var customer = scope.Resolve<ICustomer>();
            }
        }

    }

}
