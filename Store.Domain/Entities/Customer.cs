using Flunt.Validations;

namespace Store.Domain.Entities;

public class Customer : Entity
{
    public Customer(string name, string email)
    {
        AddNotifications(
            new Contract()
                .Requires()
                .IsNotNullOrEmpty(name, "Name", "nome inválido")
                .HasMinLen(name, 3, "Name", "O nome deve conter ao menos 3 caracteres")
                .HasMaxLen(name, 40, "Name", "O nome deve conter até 40 caracteres")
                .IsNotNullOrEmpty(email, "Email", "e-mail inválido")
                .IsEmail(email, "Email", "E-mail inválido")
                .HasMinLen(email, 10, "Email", "O e-mail deve conter ao menos 10 caracteres")
                .HasMaxLen(email, 200, "Name", "O e-mail deve conter até 200 caracteres")
        );

        Name = name;
        Email = email;
    }

    public string Name { get; private set; }

    public string Email { get; private set; }
}