using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDI
{
    public class Entity : IEntity
    {
        public string Name => this.GetType().Name;
    }
    public interface IEntity
    {
    }

    public class Person : Entity, IPerson
    {
    }
    public interface IPerson : IEntity
    {
    }

    public class Product : Entity, IProduct
    {
    }
    public interface IProduct : IEntity
    {
    }

    public class Customer : Person, ICustomer
    {
    }
    public interface ICustomer : IPerson
    {
    }

    public class Employee : Person, IEmployee
    {
    }
    public interface IEmployee : IPerson
    {
    }

}
