using Flunt.Notifications;
using Flunt.Validations;
using Store.Domain.Commands.Interfaces;

namespace Store.Domain.Commands;

public class CreateOrderCommand : Notifiable, ICommand
{
    public CreateOrderCommand() 
    { 
        Items = new List<CreateOrderItemCommand>();
    }

    public CreateOrderCommand(string customer, string zipCode, string promoCode, List<CreateOrderItemCommand> items)
    {
        Customer = customer;
        ZipCode = zipCode;
        PromoCode = promoCode;
        Items = items;
    }

    public string Customer { get; set; }

    public string ZipCode { get; set; }

    public string PromoCode { get; set; }

    public List<CreateOrderItemCommand> Items { get; set; }

    public void Validate()
    {
        AddNotifications(
            new Contract()
                .Requires()
                .HasLen(Customer, 11, "Customer", "Cliente inválido")
                .HasLen(ZipCode, 8, "ZipCode", "CEP inválido")
                .IsGreaterThan(Items.Count, 0, "Items", "É necessário haver itens no pedido")
        );
    }
}
