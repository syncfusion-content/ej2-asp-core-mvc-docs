public IActionResult Index()
{
   List<object> data = new List<object>()
   {
      new { ItemName= "Casual Shoes", Date= "2/14/2024", Time= "11:34:32 AM", Quantity= 10, Price= 20, Amount= "=PRODUCT(D2=E2)", Discount= "2%", Profit= "=PRODUCT(G2=F2)" },
      new { ItemName= "Sports Shoes", Date= "6/11/2024", Time= "05:56:32 AM", Quantity= 20, Price= 30, Amount= "=PRODUCT(D3=E3)", Discount= "5%", Profit= "=PRODUCT(G3=F3)" },
      new { ItemName= "Formal Shoes", Date= "7/27/2024", Time= "03:32:44 AM", Quantity= 20, Price= 15, Amount= "=PRODUCT(D4=E4)", Discount= "7.5%", Profit= "=PRODUCT(G4=F4)" },
      new { ItemName= "Sandals & Floaters", Date= "11/21/2024", Time= "06:23:54 PM", Quantity= 15, Price= 20.45, Amount= "=PRODUCT(D5=E5)", Discount= "11%", Profit= "=PRODUCT(G5=F5)" },
      new { ItemName= "Flip- Flops & Slippers", Date= "6/23/2024", Time= "12:43:59 AM", Quantity= 30, Price= 10.67, Amount= "=PRODUCT(D6=E6)", Discount= "10%", Profit= "=PRODUCT(G6=F6)" },
      new { ItemName= "Sneakers", Date= "7/22/2024", Time= "10:55:53 AM", Quantity= 40, Price= 20, Amount= "=PRODUCT(D7=E7)", Discount= "13.2%", Profit= "=PRODUCT(G7=F7)" },
      new { ItemName= "Running Shoes", Date= "2/4/2024", Time= "03:44:34 AM", Quantity= 20, Price= 10.5, Amount= "=PRODUCT(D8=E8)", Discount= "3%", Profit= "=PRODUCT(G8=F8)" },
      new { ItemName= "Loafers", Date= "11/30/2024", Time= "03:12:52 AM", Quantity= 31, Price= 10, Amount= "=PRODUCT(D9=E9)", Discount= "6.67%", Profit= "=PRODUCT(G9=F9)" },
      new { ItemName= "Cricket Shoes", Date= "7/9/2024", Time= "11:32:14 PM", Quantity= 41, Price= 30, Amount= "=PRODUCT(D10=E10)", Discount= "12.5%", Profit= "=PRODUCT(G10=F10)" },
      new { ItemName= "T-Shirts", Date= "10/31/2024", Time= "12:01:44 AM", Quantity= 50, Price= 10.75, Amount= "=PRODUCT(D11=E11)", Discount= "9%", Profit= "=PRODUCT(G11=F11)" }
   };
   ViewBag.DefaultData = data;
   return View();
}