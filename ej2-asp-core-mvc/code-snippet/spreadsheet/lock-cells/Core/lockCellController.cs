public ActionResult Index()
{
    List<object> data1 = new List<object>()
    {
        new { ExpenseType= "Housing",  ProjectedCost= "7000",  ActualCost= "7500",  Difference= "-500"},
        new { ExpenseType= "Transportation",  ProjectedCost= "500",  ActualCost= "500",  Difference= "0"},
        new { ExpenseType= "Insurance",  ProjectedCost= "1000",  ActualCost= "1000",  Difference= "0"},
        new { ExpenseType= "Food",  ProjectedCost= "2000",  ActualCost= "1800",  Difference= "200"},
        new { ExpenseType= "Pets",  ProjectedCost= "300",  ActualCost= "200",  Difference= "100"},
        new { ExpenseType= "Personel Care",  ProjectedCost= "500",  ActualCost= "500",  Difference= "0"},
        new { ExpenseType= "Loan",  ProjectedCost= "1000",  ActualCost= "1000",  Difference= "0"},
        new { ExpenseType= "Tax",  ProjectedCost= "200",  ActualCost= "200",  Difference= "0"},
        new { ExpenseType= "Savings",  ProjectedCost= "1000",  ActualCost= "900",  Difference= "100"},
        new { ExpenseType= "Total",  ProjectedCost= "13500",  ActualCost= "13600",  Difference= "-100"},
    };
    List<object> data2 = new List<object>()
    {
        new { Earnings= "Basic",  CreditAmount= "20000",  Deductions= "Provident Fund",  DebitAmount= "2400"},
        new { Earnings= "HRA",  CreditAmount= "8000",  Deductions= "ESI",  DebitAmount= "0"},
        new { Earnings= "Special Allowance",  CreditAmount= "25000",  Deductions= "Professional Tax",  DebitAmount= "200"},
        new { Earnings= "Incentives",  CreditAmount= "2000",  Deductions= "TDS",  DebitAmount= "2750"},
        new { Earnings= "Bonus",  CreditAmount= "1500",  Deductions= "Other Deduction",  DebitAmount= "0"},
        new { Earnings= "Total Earnings",  CreditAmount= "56500",  Deductions= "Total Deductions",  DebitAmount= "5350"},
    };
    List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
    buttons.Add(new DialogDialogButton() { Click = "lockCells", ButtonModel = new DefaultButtonModel() { content = "OK", isPrimary = true } });
    ViewBag.DefaultButtons = buttons;
    ViewBag.budgetData = data1;
    ViewBag.salaryData = data2;
    return View();
}

public class DefaultButtonModel
{
    public string content { get; set; }
    public bool isPrimary { get; set; }
}