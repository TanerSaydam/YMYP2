using Iyzipay.Model;

namespace MyRestaurantApp.DTOs;
public sealed record IyzipayRequest(
    decimal Cash,     
    decimal CreditCartAmount, 
    PaymentCard PaymentCard, 
    Buyer Buyer, 
    Address ShippingAddress, 
    Address BillingAddress);


//public class Test
//{
//    public Test(string id)
//    {
//        Id = id;
//    }
//    public string Id { get; init; } //5
//}

//public record TestRecord(string Id);