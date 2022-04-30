namespace ConsoleDI
{
    public interface IValidator<T>
        where T : class, IEntity
    {
        string Validate();
    }
    public class Validator<T> : IValidator<T>
        where T : class, IEntity
    {
        public string Validate()
            => $"{this.GetType().Name} - {typeof(T).Name}";
    }

    public class PersonValidator<T> : Validator<T>
        where T : class, IPerson
    {
    }
    public class CustomerValidator : PersonValidator<ICustomer>
    {
    }

    //public class EmployeeValidator : PersonValidator<IEmployee>
    //{
    //}
}
