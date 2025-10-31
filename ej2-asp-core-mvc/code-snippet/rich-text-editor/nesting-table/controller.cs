public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.value = @"<table border='1' style='width:100%; border-collapse: collapse;'>
  <tr>
    <th>Department</th>
    <th>Details</th>
  </tr>
  <tr>
    <td>Sales</td>
    <td>
      <table border='1' style='width:100%; border-collapse: collapse;'>
        <tr>
          <th>Employee</th>
          <th>Target</th>
        </tr>
        <tr>
          <td>John Doe</td>
          <td>$50,000</td>
        </tr>
        <tr>
          <td>Jane Smith</td>
          <td>$60,000</td>
        </tr>
      </table>
    </td>
  </tr>
  <tr>
    <td>Marketing</td>
    <td>Campaign planning in progress</td>
  </tr>
</table>";
        ViewBag.items = new[] { "CreateTable" };
        return View();
    }
}