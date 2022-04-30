using Autofac;
using System;
using System.Reflection;

namespace ConsoleDI
{
    public static class RegisterHelper
    {
        internal static void Register(ContainerBuilder builder)
        {
            RegisterEntity(builder);
            RegisterValidator(builder);
        }

        public static void RegisterEntity(ContainerBuilder builder)
        {
            builder.RegisterType<Entity>().As<IEntity>();
            builder.RegisterType<Product>().As<IProduct>();
            builder.RegisterType<Person>().As<IPerson>();
            builder.RegisterType<Customer>().As<ICustomer>();
            builder.RegisterType<Employee>().As<IEmployee>();
        }
        public static void RegisterValidator(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(Validator<>)).As(typeof(IValidator<>));
            builder.RegisterGeneric(typeof(PersonValidator<>)).As(typeof(IValidator<>));

            builder.RegisterType<CustomerValidator>().As<IValidator<ICustomer>>();

        }
    }

}
