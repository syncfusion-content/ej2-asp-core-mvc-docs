using System;
using System.Collections.Generic;

public class OrdersDetails
{
    public static List<OrdersDetails> order = new List<OrdersDetails>();

    public OrdersDetails()
    {
    }

    public OrdersDetails(int orderId, string customerId, int employeeId, double freight, bool verified, DateTime orderDate, string shipCity, string shipName, string shipCountry, string shipAddress)
    {
        OrderID = orderId;
        CustomerID = customerId;
        EmployeeID = employeeId;
        Freight = freight;
        Verified = verified;
        OrderDate = orderDate;
        ShipCity = shipCity;
        ShipName = shipName;
        ShipCountry = shipCountry;
        ShipAddress = shipAddress;
    }

    public static List<OrdersDetails> GetAllRecords()
    {
        if (order.Count == 0)
        {
            order.Add(new OrdersDetails(10248, "VINET", 5, 32.38, true, new DateTime(1996, 8, 1), "Reims", "Vins et alcools Chevalier", "France", "59 rue de l Abbaye"));
            order.Add(new OrdersDetails(10249, "TOMSP", 6, 11.61, false, new DateTime(1996, 8, 1), "Münster", "Toms Spezialitäten", "Germany", "Luisenstr. 48"));
            order.Add(new OrdersDetails(10250, "HANAR", 4, 65.83, true, new DateTime(1996, 8, 1), "Rio de Janeiro", "Hanari Carnes", "Brazil", "Rua do Paço, 67"));
            order.Add(new OrdersDetails(10251, "VICTE", 3, 41.34, true, new DateTime(1996, 8, 1), "Lyon", "Victuailles en stock", "France", "2, rue du Commerce"));
            order.Add(new OrdersDetails(10252, "SUPRD", 4, 51.30, true, new DateTime(1996, 8, 1), "Charleroi", "Suprêmes délices", "Belgium", "Boulevard Tirou, 255"));
            order.Add(new OrdersDetails(10253, "HANAR", 3, 58.17, true, new DateTime(1996, 8, 1), "Rio de Janeiro", "Hanari Carnes", "Brazil", "Rua do Paço, 67"));
            order.Add(new OrdersDetails(10254, "CHOPS", 5, 22.98, false, new DateTime(1996, 8, 1), "Bern", "Chop-suey Chinese", "Switzerland", "Hauptstr. 31"));
            order.Add(new OrdersDetails(10255, "RICSU", 9, 148.33, true, new DateTime(1996, 8, 1), "Genève", "Richter Supermarkt", "Switzerland", "Starenweg 5"));
            order.Add(new OrdersDetails(10256, "WELLI", 3, 13.97, false, new DateTime(1996, 8, 1), "Resende", "Wellington Importadora", "Brazil", "Rua do Mercado, 12"));
            order.Add(new OrdersDetails(10257, "HILAA", 4, 81.91, true, new DateTime(1996, 8, 1), "San Cristóbal", "HILARION-Abastos", "Venezuela", "Carrera 22 con Ave. Carlos Soublette #8-35"));
            order.Add(new OrdersDetails(10258, "ERNSH", 1, 140.51, true, new DateTime(1996, 8, 1), "Graz", "Ernst Handel", "Austria", "Kirchgasse 6"));
            order.Add(new OrdersDetails(10259, "CENTC", 4, 3.25, false, new DateTime(1996, 8, 1), "México D.F.", "Centro comercial Moctezuma", "Mexico", "Sierras de Granada 9993"));
            order.Add(new OrdersDetails(10260, "OTTIK", 4, 55.09, true, new DateTime(1996, 8, 1), "Köln", "Ottilies Käseladen", "Germany", "Mehrheimerstr. 369"));
            order.Add(new OrdersDetails(10261, "QUEDE", 4, 3.05, false, new DateTime(1996, 8, 1), "Rio de Janeiro", "Que Delícia", "Brazil", "Rua da Panificadora, 12"));
            order.Add(new OrdersDetails(10262, "RATTC", 8, 48.29, true, new DateTime(1996, 8, 1), "Albuquerque", "Rattlesnake Canyon Grocery", "USA", "2817 Milton Dr."));
        }

        return order;
    }

    public int? OrderID { get; set; }
    public string CustomerID { get; set; }
    public int? EmployeeID { get; set; }
    public double? Freight { get; set; }
    public string ShipCity { get; set; }
    public bool Verified { get; set; }
    public DateTime OrderDate { get; set; }
    public string ShipName { get; set; }
    public string ShipCountry { get; set; }
    public string ShipAddress { get; set; }
}
