using Store.Domain.Entities;
using Store.Domain.Repositories.Interfaces;

namespace Store.Tests.Repositories;

public class FakeDeliveryFeeRepository : IDeliveryFeeRepository
{
    decimal IDeliveryFeeRepository.Get(string zipCode)
    {
        return 10;
    }
}
