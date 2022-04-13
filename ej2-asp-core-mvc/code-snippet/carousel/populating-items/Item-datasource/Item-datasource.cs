 public IActionResult Index()
        {
            List<CarouselDataBinding> datasrc = new List<CarouselDataBinding>();
            datasrc.Add(new CarouselDataBinding
            {
                Id = 1,
                Title = "Slide 1",
            });
            datasrc.Add(new CarouselDataBinding
            {
                Id = 2,
                Title = "Slide 2",
            });
            datasrc.Add(new CarouselDataBinding
            {
                Id = 3,
                Title = "Slide 3",
            });
            datasrc.Add(new CarouselDataBinding
            {
                Id = 4,
                Title = "Slide 4",
            });
            datasrc.Add(new CarouselDataBinding
            {
                Id = 5,
                Title = "Slide 5",
            });
            ViewBag.dataSource = datasrc;
            return View();
        }
public class CarouselDataBinding
{
    public int Id { get; set; }
    public string Title { get; set; }
}