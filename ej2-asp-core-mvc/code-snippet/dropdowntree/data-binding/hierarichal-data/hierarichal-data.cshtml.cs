public class HierarchicalDataModel : PageModel
{
    public List<Continents> continents { get; set; }
    public string Child { get; set; }

    public void OnGet()
    {
        continents = new List<Continents>();
        List<Countries> countries = new List<Countries>();

        continents.Add(new Continents { code = "NA", name = "North America", expanded = true, child = countries });
        countries.Add(new Countries { code = "USA", name = "United States of America", selected = true });
        countries.Add(new Countries { code = "CUB", name = "Cuba" });
        countries.Add(new Countries { code = "MEX", name = "Mexico" });

        List<Countries> countries2 = new List<Countries>();
        continents.Add(new Continents { code = "AF", name = "Africa", child = countries2 });
        countries2.Add(new Countries { code = "NGA", name = "Nigeria" });
        countries2.Add(new Countries { code = "EGY", name = "Egypt" });
        countries2.Add(new Countries { code = "ZAF", name = "South Africa" });

        List<Countries> countries3 = new List<Countries>();
        continents.Add(new Continents { code = "AS", name = "Asia", child = countries3 });
        countries3.Add(new Countries { code = "CHN", name = "China" });
        countries3.Add(new Countries { code = "IND", name = "India" });
        countries3.Add(new Countries { code = "JPN", name = "Japan" });

        List<Countries> countries4 = new List<Countries>();
        continents.Add(new Continents { code = "EU", name = "Europe", child = countries4 });
        countries4.Add(new Countries { code = "DNK", name = "Denmark" });
        countries4.Add(new Countries { code = "FIN", name = "Finland" });
        countries4.Add(new Countries { code = "AUT", name = "Austria" });

        List<Countries> countries5 = new List<Countries>();
        continents.Add(new Continents { code = "SA", name = "South America", child = countries5 });
        countries5.Add(new Countries { code = "BRA", name = "Brazil" });
        countries5.Add(new Countries { code = "COL", name = "Colombia" });
        countries5.Add(new Countries { code = "ARG", name = "Argentina" });

        List<Countries> countries6 = new List<Countries>();
        continents.Add(new Continents { code = "OC", name = "Oceania", child = countries6 });
        countries6.Add(new Countries { code = "AUS", name = "Australia" });
        countries6.Add(new Countries { code = "NZL", name = "New Zealand" });
        countries6.Add(new Countries { code = "WSM", name = "Samoa" });

        List<Countries> countries7 = new List<Countries>();
        continents.Add(new Continents { code = "AN", name = "Antarctica", child = countries7 });
        countries7.Add(new Countries { code = "BVT", name = "Bouvet Island" });
        countries7.Add(new Countries { code = "ATF", name = "French Southern Lands" });

        Child = "child";
    }

    public class Continents
    {
        public string code { get; set; }
        public string name { get; set; }
        public bool expanded { get; set; }
        public List<Countries> child { get; set; }
    }

    public class Countries
    {
        public string code { get; set; }
        public string name { get; set; }
        public bool selected { get; set; }
    }
}
