﻿public class ListViewController : Controller
{
    public ActionResult ConditionalRendering()
    {
        List<object> listData = new List<object>();
        listData.Add(new { text = "Nancy", id = "0" });
        listData.Add(new { text = "Andrew", id = "1" });
        listData.Add(new { text = "Janet", id = "2" });
        listData.Add(new { text = "Margaret", id = "3" });
        listData.Add(new { text = "Steven", id = "4" });
        listData.Add(new { text = "Laura", id = "5" });
        listData.Add(new { text = "Robert", id = "6" });
        listData.Add(new { text = "Michael", id = "7" });
        listData.Add(new { text = "Albert", id = "8" });
        listData.Add(new { text = "Nolan", id = "9" });

        Random random = new Random();

        for (int i = 10; i < 1000; i++)
        {
            int index = random.Next(0, 10);
            listData.Add(new
            {
                text = listData[index].GetType().GetProperty("text").GetValue(listData[index], null).ToString(),
                id = i.ToString()
            });
        }

        ViewBag.listData = listData;
        return View();
    }
}

