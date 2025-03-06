public class OrdersDetails
{
    public static List<OrdersDetails> order = new List<OrdersDetails>();
    public OrdersDetails() { }
    public OrdersDetails(int orderID, string customerId, int productID, string productName)
    {
        this.OrderID = orderID;
        this.CustomerName = customerId;
        this.ProductID = productID;
        this.ProductName = productName;
    }
    public static List<OrdersDetails> GetAllRecords()
    {
        if (order.Count() == 0)
        {
            int code = 10000;
            for (int i = 1; i < 5; i++)
            {
                order.Add(new OrdersDetails(code + 1, "Maria", 1, "Chai"));
                order.Add(new OrdersDetails(code + 2, "Ana Trujillo", 2, "Chang"));
                order.Add(new OrdersDetails(code + 3, "Patricio Simpson", 3, "Aniseed Syrup"));
                order.Add(new OrdersDetails(code + 4, "Ana Trujillo", 4, "Chef Anton's Cajun Seasoning"));
                order.Add(new OrdersDetails(code + 5, "Georg Pipps", 5, "Grandma's Boysenberry Spread"));
                order.Add(new OrdersDetails(code + 6, "Peter Franken", 5, "Chef Anton's Cajun Seasoning"));
                order.Add(new OrdersDetails(code + 7, "Paul Henriot", 5, "Mishi Kobe Niku"));
                order.Add(new OrdersDetails(code + 8, "Marie Bertrand", 5, "Northwoods Cranberry Sauce"));
                order.Add(new OrdersDetails(code + 9, "Palle Ibsen", 5, "Carnarvon Tigers"));
                order.Add(new OrdersDetails(code + 10, "Rita Müller", 5, "CFlotemysost"));
                code += 10;
            }
        }
        return order;
    }

    public int? OrderID { get; set; }
    public string? CustomerName { get; set; }
    public? int ProductID { get; set; }
    public? string ProductName { get; set; }
}