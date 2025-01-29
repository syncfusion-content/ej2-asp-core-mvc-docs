public class NestedListModel : PageModel
{
    public List<ContinentModel>? DataSource { get; set; }

    public void OnGet()
    {
        DataSource = new List<ContinentModel>
    {
        new ContinentModel
        {
            Text = "Asia",
            Id = "01",
            Category = "Continent",
            Child = new List<CountryModel>
            {
                new CountryModel
                {
                    Text = "India",
                    Id = "1",
                    Category = "Asia",
                    Child = new List<CityModel>
                    {
                        new CityModel { Text = "Delhi", Id = "1001", Category = "India" },
                        new CityModel { Text = "Kashmir", Id = "1002", Category = "India" },
                        new CityModel { Text = "Goa", Id = "1003", Category = "India" }
                    }
                },
                new CountryModel
                {
                    Text = "China",
                    Id = "2",
                    Category = "Asia",
                    Child = new List<CityModel>
                    {
                        new CityModel { Text = "Zhejiang", Id = "2001", Category = "China" },
                        new CityModel { Text = "Hunan", Id = "2002", Category = "China" },
                        new CityModel { Text = "Shandong", Id = "2003", Category = "China" }
                    }
                }
            }
        },
        new ContinentModel
        {
            Text = "North America",
            Id = "02",
            Category = "Continent",
            Child = new List<CountryModel>
            {
                new CountryModel
                {
                    Text = "USA",
                    Id = "3",
                    Category = "North America",
                    Child = new List<CityModel>
                    {
                        new CityModel { Text = "California", Id = "3001", Category = "USA" },
                        new CityModel { Text = "New York", Id = "3002", Category = "USA" },
                        new CityModel { Text = "Florida", Id = "3003", Category = "USA" }
                    }
                },
                new CountryModel
                {
                    Text = "Canada",
                    Id = "4",
                    Category = "North America",
                    Child = new List<CityModel>
                    {
                        new CityModel { Text = "Ontario", Id = "4001", Category = "Canada" },
                        new CityModel { Text = "Alberta", Id = "4002", Category = "Canada" },
                        new CityModel { Text = "Manitoba", Id = "4003", Category = "Canada" }
                    }
                }
            }
        },
        new ContinentModel
        {
            Text = "Europe",
            Id = "03",
            Category = "Continent",
            Child = new List<CountryModel>
            {
                new CountryModel
                {
                    Text = "Germany",
                    Id = "5",
                    Category = "Europe",
                    Child = new List<CityModel>
                    {
                        new CityModel { Text = "Berlin", Id = "5001", Category = "Germany" },
                        new CityModel { Text = "Bavaria", Id = "5002", Category = "Germany" },
                        new CityModel { Text = "Hesse", Id = "5003", Category = "Germany" }
                    }
                },
                new CountryModel
                {
                    Text = "France",
                    Id = "6",
                    Category = "Europe",
                    Child = new List<CityModel>
                    {
                        new CityModel { Text = "Paris", Id = "6001", Category = "France" },
                        new CityModel { Text = "Lyon", Id = "6002", Category = "France" },
                        new CityModel { Text = "Marseille", Id = "6003", Category = "France" }
                    }
                }
            }
        },
        new ContinentModel
        {
            Text = "Australia",
            Id = "04",
            Category = "Continent",
            Child = new List<CountryModel>
            {
                new CountryModel
                {
                    Text = "Australia",
                    Id = "7",
                    Category = "Australia",
                    Child = new List<CityModel>
                    {
                        new CityModel { Text = "Sydney", Id = "7001", Category = "Australia" },
                        new CityModel { Text = "Melbourne", Id = "7002", Category = "Australia" },
                        new CityModel { Text = "Brisbane", Id = "7003", Category = "Australia" }
                    }
                },
                new CountryModel
                {
                    Text = "New Zealand",
                    Id = "8",
                    Category = "Australia",
                    Child = new List<CityModel>
                    {
                        new CityModel { Text = "Milford Sound", Id = "8001", Category = "New Zealand" },
                        new CityModel { Text = "Tongariro National Park", Id = "8002", Category = "New Zealand" },
                        new CityModel { Text = "Fiordland National Park", Id = "8003", Category = "New Zealand" }
                    }
                }
            }
        },
        new ContinentModel
        {
            Text = "Africa",
            Id = "05",
            Category = "Continent",
            Child = new List<CountryModel>
            {
                new CountryModel
                {
                    Text = "Morocco",
                    Id = "9",
                    Category = "Africa",
                    Child = new List<CityModel>
                    {
                        new CityModel { Text = "Rabat", Id = "9001", Category = "Morocco" },
                        new CityModel { Text = "Toubkal", Id = "9002", Category = "Morocco" },
                        new CityModel { Text = "Todgha Gorge", Id = "9003", Category = "Morocco" }
                    }
                },
                new CountryModel
                {
                    Text = "South Africa",
                    Id = "10",
                    Category = "Africa",
                    Child = new List<CityModel>
                    {
                        new CityModel { Text = "Cape Town", Id = "10001", Category = "South Africa" },
                        new CityModel { Text = "Pretoria", Id = "10002", Category = "South Africa" },
                        new CityModel { Text = "Bloemfontein", Id = "10003", Category = "South Africa" }
                    }
                }
            }
        }
    };
    }
}

public class ContinentModel
{
    public string Text { get; set; }
    public string Id { get; set; }
    public string Category { get; set; }
    public List<CountryModel> Child { get; set; }
}

public class CountryModel
{
    public string Text { get; set; }
    public string Id { get; set; }
    public string Category { get; set; }
    public List<CityModel> Child { get; set; }
}

public class CityModel
{
    public string Text { get; set; }
    public string Id { get; set; }
    public string Category { get; set; }
}