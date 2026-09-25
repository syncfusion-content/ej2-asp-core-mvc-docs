public IActionResult Index()
{
    ViewBag.dataSource = GetTicketData();
    return View();
}

private List<TicketData> GetTicketData()
{
    return new List<TicketData>
    {
        new TicketData { TicketID = "65823", TypeofRequest = "Bug", Category = "Support", Title = "Login Failure Report", Assignee = "Sarah Lee", Status = "Open", Priority = "Low", CreatedDate = new DateTime(2026, 8, 25), DueDate = new DateTime(2026, 8, 26) },
        new TicketData { TicketID = "65822", TypeofRequest = "Technical Support", Category = "Product", Title = "Login Setup Assistance", Assignee = "Tom Wilson", Status = "Open", Priority = "Low", CreatedDate = new DateTime(2026, 8, 24), DueDate = new DateTime(2026, 8, 25) },
        new TicketData { TicketID = "65821", TypeofRequest = "Feature Enhancement", Category = "Support", Title = "Dashboard Enhancement Request", Assignee = "Alex Brown", Status = "In Progress", Priority = "Urgent", CreatedDate = new DateTime(2026, 8, 23), DueDate = new DateTime(2026, 9, 1) },
        new TicketData { TicketID = "65820", TypeofRequest = "Refund", Category = "Support", Title = "Order Refund Request", Assignee = "Priya Kumar", Status = "Validated", Priority = "Low", CreatedDate = new DateTime(2026, 8, 22), DueDate = new DateTime(2026, 8, 23) },
        new TicketData { TicketID = "65819", TypeofRequest = "Refund", Category = "Product", Title = "Payment Refund Status Inquiry", Assignee = "Mike Johnson", Status = "Open", Priority = "Medium", CreatedDate = new DateTime(2026, 8, 21), DueDate = new DateTime(2026, 8, 23) },
        new TicketData { TicketID = "65818", TypeofRequest = "Bug", Category = "Product", Title = "Checkout Error Investigation", Assignee = "Sarah Lee", Status = "Validated", Priority = "Low", CreatedDate = new DateTime(2026, 8, 20), DueDate = new DateTime(2026, 8, 21) },
        new TicketData { TicketID = "65817", TypeofRequest = "Bug", Category = "Billing", Title = "Search Defect Needs Fixing", Assignee = "Jane Smith", Status = "In Progress", Priority = "Medium", CreatedDate = new DateTime(2026, 8, 19), DueDate = new DateTime(2026, 8, 21) },
        new TicketData { TicketID = "65816", TypeofRequest = "Feature Enhancement", Category = "Product", Title = "Search Improvement Proposal", Assignee = "Mike Johnson", Status = "Open", Priority = "Medium", CreatedDate = new DateTime(2026, 8, 18), DueDate = new DateTime(2026, 8, 23) },
        new TicketData { TicketID = "65815", TypeofRequest = "Refund", Category = "Support", Title = "Invoice Refund Review Request", Assignee = "Tom Wilson", Status = "Done", Priority = "Medium", CreatedDate = new DateTime(2026, 8, 17), DueDate = new DateTime(2026, 8, 18) },
        new TicketData { TicketID = "65814", TypeofRequest = "Refund", Category = "Product", Title = "Purchase Refund Request", Assignee = "Alex Brown", Status = "Done", Priority = "Medium", CreatedDate = new DateTime(2026, 8, 16), DueDate = new DateTime(2026, 8, 18) },
        new TicketData { TicketID = "65813", TypeofRequest = "Feature Enhancement", Category = "Product", Title = "Reports Feature Upgrade Request", Assignee = "Alex Brown", Status = "Validated", Priority = "Low", CreatedDate = new DateTime(2026, 8, 15), DueDate = new DateTime(2026, 9, 3) },
        new TicketData { TicketID = "65812", TypeofRequest = "Refund", Category = "Support", Title = "Charge Refund Status Inquiry", Assignee = "Priya Kumar", Status = "In Progress", Priority = "Urgent", CreatedDate = new DateTime(2026, 8, 14), DueDate = new DateTime(2026, 8, 16) },
        new TicketData { TicketID = "65811", TypeofRequest = "Feature Enhancement", Category = "Billing", Title = "Filters Enhancement Request", Assignee = "Priya Kumar", Status = "Done", Priority = "Urgent", CreatedDate = new DateTime(2026, 8, 13), DueDate = new DateTime(2026, 8, 31) },
        new TicketData { TicketID = "65810", TypeofRequest = "Technical Support", Category = "Product", Title = "Password Support Guidance", Assignee = "Sarah Lee", Status = "Done", Priority = "Low", CreatedDate = new DateTime(2026, 8, 12), DueDate = new DateTime(2026, 8, 13) },
        new TicketData { TicketID = "65809", TypeofRequest = "Feature Enhancement", Category = "Support", Title = "Export Improvement Proposal", Assignee = "John Doe", Status = "Validated", Priority = "Low", CreatedDate = new DateTime(2026, 8, 11), DueDate = new DateTime(2026, 8, 26) },
        new TicketData { TicketID = "65808", TypeofRequest = "Bug", Category = "Support", Title = "Dashboard Failure Report", Assignee = "Emily Davis", Status = "Done", Priority = "Urgent", CreatedDate = new DateTime(2026, 8, 10), DueDate = new DateTime(2026, 8, 11) },
        new TicketData { TicketID = "65807", TypeofRequest = "Bug", Category = "Product", Title = "Upload Error Investigation", Assignee = "Alex Brown", Status = "Done", Priority = "Urgent", CreatedDate = new DateTime(2026, 8, 9), DueDate = new DateTime(2026, 8, 12) },
        new TicketData { TicketID = "65806", TypeofRequest = "Refund", Category = "Support", Title = "Transaction Refund Review Request", Assignee = "Alex Brown", Status = "Done", Priority = "High", CreatedDate = new DateTime(2026, 8, 8), DueDate = new DateTime(2026, 8, 10) },
        new TicketData { TicketID = "65805", TypeofRequest = "Bug", Category = "Billing", Title = "Billing Defect Needs Fixing", Assignee = "Alex Brown", Status = "Open", Priority = "High", CreatedDate = new DateTime(2026, 8, 7), DueDate = new DateTime(2026, 8, 11) },
        new TicketData { TicketID = "65804", TypeofRequest = "Refund", Category = "Product", Title = "Billing Refund Request", Assignee = "Mike Johnson", Status = "Done", Priority = "Urgent", CreatedDate = new DateTime(2026, 8, 6), DueDate = new DateTime(2026, 8, 7) },
        new TicketData { TicketID = "65803", TypeofRequest = "Bug", Category = "Product", Title = "Profile Failure Report", Assignee = "Tom Wilson", Status = "Open", Priority = "High", CreatedDate = new DateTime(2026, 8, 5), DueDate = new DateTime(2026, 8, 8) },
        new TicketData { TicketID = "65802", TypeofRequest = "Refund", Category = "Product", Title = "Credit Refund Status Inquiry", Assignee = "John Doe", Status = "Done", Priority = "High", CreatedDate = new DateTime(2026, 8, 4), DueDate = new DateTime(2026, 8, 6) },
        new TicketData { TicketID = "65801", TypeofRequest = "Refund", Category = "Product", Title = "Receipt Refund Review Request", Assignee = "Alex Brown", Status = "In Progress", Priority = "Urgent", CreatedDate = new DateTime(2026, 8, 3), DueDate = new DateTime(2026, 8, 4) },
        new TicketData { TicketID = "65800", TypeofRequest = "Bug", Category = "Product", Title = "Notifications Error Investigation", Assignee = "Alex Brown", Status = "Validated", Priority = "Low", CreatedDate = new DateTime(2026, 8, 2), DueDate = new DateTime(2026, 8, 4) },
        new TicketData { TicketID = "65799", TypeofRequest = "Technical Support", Category = "Billing", Title = "Upload Troubleshooting Help", Assignee = "Jane Smith", Status = "In Progress", Priority = "Medium", CreatedDate = new DateTime(2026, 8, 1), DueDate = new DateTime(2026, 8, 2) },
        new TicketData { TicketID = "65798", TypeofRequest = "Feature Enhancement", Category = "Product", Title = "Notifications Feature Upgrade Request", Assignee = "Jane Smith", Status = "Open", Priority = "Medium", CreatedDate = new DateTime(2026, 7, 31), DueDate = new DateTime(2026, 8, 8) },
        new TicketData { TicketID = "65797", TypeofRequest = "Subscription Cancellation", Category = "Support", Title = "Subscription Cancellation Request", Assignee = "Alex Brown", Status = "Done", Priority = "Urgent", CreatedDate = new DateTime(2026, 7, 30), DueDate = new DateTime(2026, 8, 1) },
        new TicketData { TicketID = "65796", TypeofRequest = "Technical Support", Category = "Product", Title = "Dashboard Setup Assistance", Assignee = "Tom Wilson", Status = "In Progress", Priority = "High", CreatedDate = new DateTime(2026, 7, 29), DueDate = new DateTime(2026, 7, 30) },
        new TicketData { TicketID = "65795", TypeofRequest = "Technical Support", Category = "Product", Title = "Reports Support Guidance", Assignee = "Priya Kumar", Status = "In Progress", Priority = "Urgent", CreatedDate = new DateTime(2026, 7, 28), DueDate = new DateTime(2026, 7, 30) },
        new TicketData { TicketID = "65794", TypeofRequest = "Technical Support", Category = "Support", Title = "Calendar Troubleshooting Help", Assignee = "Sarah Lee", Status = "Done", Priority = "Low", CreatedDate = new DateTime(2026, 7, 27), DueDate = new DateTime(2026, 7, 28) },
        new TicketData { TicketID = "65793", TypeofRequest = "Refund", Category = "Billing", Title = "Checkout Refund Request", Assignee = "Alex Brown", Status = "Done", Priority = "High", CreatedDate = new DateTime(2026, 7, 26), DueDate = new DateTime(2026, 7, 29) },
        new TicketData { TicketID = "65792", TypeofRequest = "Feature Enhancement", Category = "Product", Title = "Calendar Enhancement Request", Assignee = "Emily Davis", Status = "In Progress", Priority = "Low", CreatedDate = new DateTime(2026, 7, 25), DueDate = new DateTime(2026, 8, 6) },
        new TicketData { TicketID = "65791", TypeofRequest = "Feature Enhancement", Category = "Support", Title = "Profile Improvement Proposal", Assignee = "John Doe", Status = "Done", Priority = "Urgent", CreatedDate = new DateTime(2026, 7, 24), DueDate = new DateTime(2026, 8, 12) },
        new TicketData { TicketID = "65790", TypeofRequest = "Technical Support", Category = "Billing", Title = "Invoice Setup Assistance", Assignee = "Mike Johnson", Status = "Validated", Priority = "High", CreatedDate = new DateTime(2026, 7, 23), DueDate = new DateTime(2026, 7, 24) },
        new TicketData { TicketID = "65789", TypeofRequest = "Technical Support", Category = "Product", Title = "Profile Support Guidance", Assignee = "John Doe", Status = "In Progress", Priority = "Urgent", CreatedDate = new DateTime(2026, 7, 22), DueDate = new DateTime(2026, 7, 23) },
        new TicketData { TicketID = "65788", TypeofRequest = "Bug", Category = "Product", Title = "Reports Defect Needs Fixing", Assignee = "Emily Davis", Status = "Done", Priority = "Low", CreatedDate = new DateTime(2026, 7, 21), DueDate = new DateTime(2026, 7, 24) },
        new TicketData { TicketID = "65787", TypeofRequest = "Subscription Cancellation", Category = "Billing", Title = "Membership Cancellation Assistance", Assignee = "Jane Smith", Status = "In Progress", Priority = "Urgent", CreatedDate = new DateTime(2026, 7, 20), DueDate = new DateTime(2026, 7, 22) },
        new TicketData { TicketID = "65786", TypeofRequest = "Feature Enhancement", Category = "Product", Title = "Checkout Feature Upgrade Request", Assignee = "Alex Brown", Status = "In Progress", Priority = "Urgent", CreatedDate = new DateTime(2026, 7, 19), DueDate = new DateTime(2026, 8, 3) },
        new TicketData { TicketID = "65785", TypeofRequest = "Subscription Cancellation", Category = "Product", Title = "Plan Cancellation Confirmation", Assignee = "John Doe", Status = "Done", Priority = "Low", CreatedDate = new DateTime(2026, 7, 18), DueDate = new DateTime(2026, 7, 20) },
        new TicketData { TicketID = "65784", TypeofRequest = "Subscription Cancellation", Category = "Support", Title = "Renewal Cancellation Request", Assignee = "Sarah Lee", Status = "Done", Priority = "Medium", CreatedDate = new DateTime(2026, 7, 17), DueDate = new DateTime(2026, 7, 18) },
        new TicketData { TicketID = "65783", TypeofRequest = "Technical Support", Category = "Product", Title = "Address Troubleshooting Help", Assignee = "Emily Davis", Status = "In Progress", Priority = "Urgent", CreatedDate = new DateTime(2026, 7, 16), DueDate = new DateTime(2026, 7, 17) },
        new TicketData { TicketID = "65782", TypeofRequest = "Refund", Category = "Support", Title = "Delivery Refund Status Inquiry", Assignee = "Mike Johnson", Status = "In Progress", Priority = "High", CreatedDate = new DateTime(2026, 7, 15), DueDate = new DateTime(2026, 7, 18) },
        new TicketData { TicketID = "65781", TypeofRequest = "Technical Support", Category = "Billing", Title = "Payment Setup Assistance", Assignee = "Mike Johnson", Status = "Done", Priority = "High", CreatedDate = new DateTime(2026, 7, 14), DueDate = new DateTime(2026, 7, 16) },
        new TicketData { TicketID = "65780", TypeofRequest = "Refund", Category = "Product", Title = "Return Refund Review Request", Assignee = "Jane Smith", Status = "Done", Priority = "Low", CreatedDate = new DateTime(2026, 7, 13), DueDate = new DateTime(2026, 7, 15) },
        new TicketData { TicketID = "65779", TypeofRequest = "Technical Support", Category = "Support", Title = "Orders Support Guidance", Assignee = "Tom Wilson", Status = "In Progress", Priority = "High", CreatedDate = new DateTime(2026, 7, 12), DueDate = new DateTime(2026, 7, 13) },
        new TicketData { TicketID = "65778", TypeofRequest = "Feature Enhancement", Category = "Support", Title = "Analytics Enhancement Request", Assignee = "Tom Wilson", Status = "Done", Priority = "High", CreatedDate = new DateTime(2026, 7, 11), DueDate = new DateTime(2026, 7, 31) },
        new TicketData { TicketID = "65777", TypeofRequest = "Bug", Category = "Product", Title = "Calendar Failure Report", Assignee = "Priya Kumar", Status = "Open", Priority = "Low", CreatedDate = new DateTime(2026, 7, 10), DueDate = new DateTime(2026, 7, 11) },
        new TicketData { TicketID = "65776", TypeofRequest = "Bug", Category = "Product", Title = "Invoice Error Investigation", Assignee = "John Doe", Status = "In Progress", Priority = "Urgent", CreatedDate = new DateTime(2026, 7, 9), DueDate = new DateTime(2026, 7, 11) },
        new TicketData { TicketID = "65775", TypeofRequest = "Subscription Cancellation", Category = "Support", Title = "Account Cancellation Assistance", Assignee = "Tom Wilson", Status = "In Progress", Priority = "Medium", CreatedDate = new DateTime(2026, 7, 8), DueDate = new DateTime(2026, 7, 9) },
        new TicketData { TicketID = "65774", TypeofRequest = "Subscription Cancellation", Category = "Product", Title = "Service Cancellation Confirmation", Assignee = "John Doe", Status = "Open", Priority = "High", CreatedDate = new DateTime(2026, 7, 7), DueDate = new DateTime(2026, 7, 9) }
    };
}

public class TicketData
{
    public string TicketID { get; set; }
    public string TypeofRequest { get; set; }
    public string Category { get; set; }
    public string Title { get; set; }
    public string Assignee { get; set; }
    public string Status { get; set; }
    public string Priority { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime DueDate { get; set; }
}