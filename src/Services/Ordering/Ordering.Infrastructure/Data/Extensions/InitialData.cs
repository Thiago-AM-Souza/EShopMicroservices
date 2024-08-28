namespace Ordering.Infrastructure.Data.Extensions
{
    public class InitialData
    {
        public static IEnumerable<Customer> Customers =>
        new List<Customer>
        {
            Customer.Create(CustomerId.Of(new Guid("985dd2c2-919c-4d04-85b7-3429979852b6")), "Thiago", "thiago@email.com"),
            Customer.Create(CustomerId.Of(new Guid("af504331-dde6-4793-bb53-bd7ac132222c")), "Rafa", "rafa@email.com")
        };

        public static IEnumerable<Product> Products =>
        new List<Product>
        {
            Product.Create(ProductId.Of(new Guid("cec1c90d-3492-4b1a-9f21-7ea9490bb08d")), "Samsung S23+", 500),
            Product.Create(ProductId.Of(new Guid("708ae581-406f-4fde-adac-54dfd6fcf5af")), "Samsung S22+", 400),
            Product.Create(ProductId.Of(new Guid("f0620f1f-2925-4617-bbad-50c4206da5de")), "Xiaomi 13", 300),
            Product.Create(ProductId.Of(new Guid("11940c8a-074e-4ffa-8934-135976cf2419")), "Motorola Moto X", 200)
        };

        public static IEnumerable<Order> OrdersWithItems
        {
            get
            {
                var address1 = Address.Of("mehmet", "ozkaya", "mehmet@gmail.com", "Bahcelievler No:4", "Turkey", "Istanbul", "38050");
                var address2 = Address.Of("john", "doe", "john@gmail.com", "Broadway No:1", "England", "Nottingham", "08050");

                var payment1 = Payment.Of("mehmet", "5555555555554444", "12/28", "355", 1);
                var payment2 = Payment.Of("john", "8885555555554444", "06/30", "222", 2);

                var order1 = Order.Create(
                                OrderId.Of(Guid.NewGuid()),
                                CustomerId.Of(new Guid("985dd2c2-919c-4d04-85b7-3429979852b6")),
                                OrderName.Of("ORD_1"),
                                shippingAddress: address1,
                                billingAddress: address1,
                                payment1);
                order1.Add(ProductId.Of(new Guid("cec1c90d-3492-4b1a-9f21-7ea9490bb08d")), 2, 500);
                order1.Add(ProductId.Of(new Guid("708ae581-406f-4fde-adac-54dfd6fcf5af")), 1, 400);

                var order2 = Order.Create(
                                OrderId.Of(Guid.NewGuid()),
                                CustomerId.Of(new Guid("af504331-dde6-4793-bb53-bd7ac132222c")),
                                OrderName.Of("ORD_2"),
                                shippingAddress: address2,
                                billingAddress: address2,
                                payment2);
                order2.Add(ProductId.Of(new Guid("f0620f1f-2925-4617-bbad-50c4206da5de")), 1, 650);
                order2.Add(ProductId.Of(new Guid("11940c8a-074e-4ffa-8934-135976cf2419")), 2, 450);

                return new List<Order> { order1, order2 };
            }
        }
    }
}
