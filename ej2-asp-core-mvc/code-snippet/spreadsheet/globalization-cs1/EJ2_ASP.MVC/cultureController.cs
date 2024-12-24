public ActionResult Index()
{
    List<object> data = new List<object>()
    {
        new { ItemName= "Casual Shoes", Date= "14.02.2014", Time= "11:34:32 AM", Quantity= 10, Price= 20, Amount= "=PRODUCT(D2;E2)", Discount= "2%", Profit= "=PRODUCT(G2;F2)" },
        new { ItemName= "Sports Shoes", Date= "11.06.2014", Time= "05:56:32 AM", Quantity= 20, Price= 30, Amount= "=PRODUCT(D3;E3)", Discount= "5%", Profit= "=PRODUCT(G3;F3)" },
        new { ItemName= "Formal Shoes", Date= "27.07.2014", Time= "03:32:44 AM", Quantity= 20, Price= 15, Amount= "=PRODUCT(D4;E4)", Discount= "7,5%", Profit= "=PRODUCT(G4;F4)" },
        new { ItemName= "Sandals & Floaters", Date= "21.11.2014", Time= "06:23:54 AM", Quantity= 15, Price= "20,45", Amount= "=PRODUCT(D5;E5)", Discount= "11%", Profit= "=PRODUCT(G5;F5)" },
        new { ItemName= "Flip- Flops & Slippers", Date= "23.06.2014", Time= "12:43:59 AM", Quantity= 30, Price= "10,67", Amount= "=PRODUCT(D6;E6)", Discount= "10%", Profit= "=PRODUCT(G6;F6)" },
        new { ItemName= "Sneakers", Date= "22.07.2014", Time= "10:55:53 AM", Quantity= 40, Price= 20, Amount= "=PRODUCT(D7;E7)", Discount= "13,2%", Profit= "=PRODUCT(G7;F7)" },
        new { ItemName= "Running Shoes", Date= "04.02.2014", Time= "03:44:34 AM", Quantity= 20, Price= "10,5", Amount= "=PRODUCT(D8;E8)", Discount= "3%", Profit= "=PRODUCT(G8;F8)" },
        new { ItemName= "Loafers", Date= "30.11.2014", Time= "03:12:52 AM", Quantity= 31, Price= 10, Amount= "=PRODUCT(D9;E9)", Discount= "6,67", Profit= "=PRODUCT(G9;F9)" },
        new { ItemName= "Cricket Shoes", Date= "09.07.2014", Time= "11:32:14 AM", Quantity= 41, Price= 30, Amount= "=PRODUCT(D10;E10)", Discount= "12,5%", Profit= "=PRODUCT(G10;F10)" },
        new { ItemName= "T-Shirts", Date= "31.10.2014", Time= "12:01:44 AM", Quantity= 50, Price= "10,75", Amount= "=PRODUCT(D11;E11)", Discount= "9%", Profit= "=PRODUCT(G11;F11)" }
    };
    List<object> cultureList = new List<object>()
    {
        new { Culture= "German - Germany", Locale= "de EUR ;" },
        new { Culture= "French - Switzerland", Locale = "fr-CH CHF ;" },
        new { Culture= "Chinese - China", Locale= "zh CNY ," },
        new { Culture= "English", Locale= "en-US USD ," }
    };
    
    Dictionary<string, List<object>> localeFormats = new Dictionary<string, List<object>> {
            { "de", new List<object> {
                new { id = 37, code = @"#,##0;-#,##0" },
                new { id = 38, code = @"#,##0;[Red]-#,##0" },
                new { id = 39, code = @"#,##0.00;-#,##0.00" },
                new { id = 40, code = @"#,##0.00;[Red]-#,##0.00" },
                new { id = 5, code = @"#,##0 ""€"";-#,##0 ""€""" },
                new { id = 6, code = @"#,##0 ""€"";[Red]-#,##0 ""€""" },
                new { id = 7, code = @"#,##0.00 ""€"";-#,##0.00 ""€""" },
                new { id = 8, code = @"#,##0.00 ""€"";[Red]-#,##0.00 ""€""" },
                new { id = 41, code = @"_-* #,##0_-;-* #,##0_-;_-* ""-""_-;_-@_-" },
                new { id = 42, code = @"_-* #,##0 ""€""_-;-* #,##0 ""€""_-;_-* ""-"" ""€""_-;_-@_-" },
                new { id = 43, code = @"_-* #,##0.00_-;-* #,##0.00_-;_-* ""-""??_-;_-@_-" },
                new { id = 44, code = @"_-* #,##0.00 ""€""_-;-* #,##0.00 ""€""_-;_-* ""-""?? ""€""_-;_-@_-" },
                new { id = 14, code = @"dd.MM.yyyy" },
                new { id = 15, code = @"dd. MMM yy" },
                new { id = 16, code = @"dd. MMM" },
                new { id = 17, code = @"MMM yy" },
                new { id = 20, code = @"hh:mm" },
                new { id = 21, code = @"hh:mm:ss" },
                new { id = 22, code = @"dd.MM.yyyy hh:mm" }
            }},
            { "zh", new List<object> {
                new  { id = 37, code = @"#,##0;-#,##0" },
                new  { id = 38, code = @"#,##0;[Red]-#,##0" },
                new  { id = 39, code = @"#,##0.00;-#,##0.00" },
                new  { id = 40, code = @"#,##0.00;[Red]-#,##0.00" },
                new  { id = 5, code = @"""¥""#,##0;""¥""-#,##0" },
                new  { id = 6, code = @"""¥""#,##0;[Red]""¥""-#,##0" },
                new  { id = 7, code = @"""¥""#,##0.00;""¥""-#,##0.00" },
                new  { id = 8, code = @"""¥""#,##0.00;[Red]""¥""-#,##0.00" },
                new  { id = 41, code = @"_ * #,##0_ ;_ * -#,##0_ ;_ * ""-""_ ;_ @_" },
                new  { id = 42, code = @"_ ""¥""* #,##0_ ;_ ""¥""* -#,##0_ ;_ ""¥""* ""-""_ ;_ @_" },
                new  { id = 43, code = @"_ * #,##0.00_ ;_ * -#,##0.00_ ;_ * ""-""??_ ;_ @_" },
                new  { id = 44, code = @"_ ""¥""* #,##0.00_ ;_ ""¥""* -#,##0.00_ ;_ ""¥""* ""-""??_ ;_ @_" },
                new  { id = 14, code = @"yyyy/m/d" },
                new  { id = 22, code = @"yyyy/m/d h:mm" }
            }},
            { "fr-CH", new List<object> {
                new { id = 37, code = @"#,##0;-#,##0" },
                new { id = 38, code = @"#,##0;[Red]-#,##0" },
                new { id = 39, code = @"#,##0.00;-#,##0.00" },
                new { id = 40, code = @"#,##0.00;[Red]-#,##0.00" },
                new { id = 5, code = @"#,##0 ""CHF"";-#,##0 ""CHF""" },
                new { id = 6, code = @"#,##0 ""CHF"";[Red]-#,##0 ""CHF""" },
                new { id = 7, code = @"#,##0.00 ""CHF"";-#,##0.00 ""CHF""" },
                new { id = 8, code = @"#,##0.00 ""CHF"";[Red]-#,##0.00 ""CHF""" },
                new { id = 14, code = @"dd.MM.yyyy" },
                new { id = 15, code = @"dd.MMM.yy" },
                new { id = 16, code = @"dd.MMM" },
                new { id = 17, code = @"MMM.yy" },
                new { id = 20, code = @"HH:mm" },
                new { id = 21, code = @"HH:mm:ss" },
                new { id = 22, code = @"dd.MM.yyyy HH:mm" },
                new { id = 42, code = @"_-* #,##0 ""CHF""_-;-* #,##0 ""CHF""_-;_-* ""-"" ""CHF""_-;_-@__-" },
                new { id = 44, code = @"_-* #,##0.00 ""CHF""_-;-* #,##0.00 ""CHF""_-;_-* ""-""?? ""CHF""_-;_-@__-" },
                new { id = 41, code = @"_-* #,##0_-;-* #,##0_-;_-* ""-""_-;_-@__-" },
                new { id = 43, code = @"_-* #,##0.00_-;-* #,##0.00_-;_-* ""-""??_-;_-@__-" }
            }},
            { "en-US", new List<object>() }
            };
    ViewBag.LocaleFormats = localeFormats;
    ViewBag.CultureList = cultureList;
    ViewBag.DefaultData = data;
    return View();
}