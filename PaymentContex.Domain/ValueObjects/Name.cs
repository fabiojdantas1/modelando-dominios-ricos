using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(firstName, 3, "Name.FirstName", "The First Name must contain at least 3 characters")
                .HasMinLen(lastName, 3, "Name.LastName", "The Last Name must contain at least 3 characters")
                .HasMaxLen(firstName, 40, "Name.FirstName", "The First Name must contain a maximum of 40 characters")
                .HasMaxLen(lastName, 80, "Name.LastName", "The Last Name must contain a maximum of 40 characters")

            );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}