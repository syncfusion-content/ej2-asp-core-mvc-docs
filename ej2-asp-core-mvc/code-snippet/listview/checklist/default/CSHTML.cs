public class CheckboxModel : PageModel
{
    public List<CarModel>? DataSource { get; set; }
    public void OnGet()
    {
        DataSource = new List<CarModel>
    {
        new CarModel { Text = "Hennessey Venom", Id = "list-01" },
        new CarModel { Text = "Bugatti Chiron", Id = "list-02" },
        new CarModel { Text = "Bugatti Veyron Super Sport", Id = "list-03" },
        new CarModel { Text = "SSC Ultimate Aero", Id = "list-04" },
        new CarModel { Text = "Koenigsegg CCR", Id = "list-05" },
        new CarModel { Text = "McLaren F1", Id = "list-06" },
        new CarModel { Text = "Aston Martin One- 77", Id = "list-07" },
        new CarModel { Text = "Jaguar XJ220", Id = "list-08" },
        new CarModel { Text = "McLaren P1", Id = "list-09" },
        new CarModel { Text = "Ferrari LaFerrari", Id = "list-10" }
    };
    }
}
public class CarModel
{
    public string Text { get; set; }
    public string Id { get; set; }
}