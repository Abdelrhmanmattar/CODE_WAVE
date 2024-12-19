namespace DAY10
{
    public enum OrderStatus
    {
        Pending=0,
        Processing,
        Shipped,
        Delivered
    }
    public class OrderController
    {
        public void DisplayOrderStatus(OrderStatus status)
        {
            switch (status)
            {
                case OrderStatus.Pending:
                    Console.WriteLine("The order is pending.");
                    break;
                case OrderStatus.Processing:
                    Console.WriteLine("The order is being processed.");
                    break;
                case OrderStatus.Shipped:
                    Console.WriteLine("The order has been shipped.");
                    break;
                case OrderStatus.Delivered:
                    Console.WriteLine("The order has been delivered.");
                    break;
                default:
                    Console.WriteLine("Invalid order status.");
                    break;
            }
        }
    }
}
