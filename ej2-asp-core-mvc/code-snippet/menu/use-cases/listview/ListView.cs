// Mobile view data
public ActionResult ListView()
{
    List<object> Items = new List<object>() {
        new {
            text = "Appliances",
            id = "list1",
            child = new List<object>() {
                new {
                    text = "Kitchen",
                    id = "list1_1",
                    child = new List<object>() {
                        new { id = "list1_1_1" , text= "Electric Cookers" },
                        new { id = "list1_1_2" , text= "Coffee Makers" },
                        new { id = "list1_1_3" , text= "Blenders" }
                    }
                },
                new {
                    text = "Washing Machine",
                    id = "list1_2",
                    child = new List<object>() {
                        new { id = "list1_2_1" , text= "Fully Automatic" },
                        new { id = "list1_2_2" , text= "Semi Automatic" }
                    }
                },
                new {
                    text = "Air Conditioners",
                    id = "list1_3",
                    child = new List<object>() {
                        new { id = "list1_3_1" , text= "Inverter ACs" },
                        new { id = "list1_3_2" , text= "Split ACs" },
                        new { id = "list1_3_3" , text= "Window ACs" }
                    }
                }
            }
        },
        new {
            text = "Accessories",
            id = "list2",
            child = new List<object>() {
                new {
                    text = "Mobile",
                    id = "list2_1",
                    child = new List<object>() {
                        new { id = "list2_1_1", text= "Headphones" },
                        new { id = "list2_1_2", text= "Memory Cards" },
                        new { id = "list2_1_3",  text= "Power Banks" }
                    }
                },
                new {
                    text = "Computer",
                    id = "list2_2",
                    child = new List<object>() {
                        new {  id = "list2_2_1", text= "Pendrives" },
                        new {  id = "list2_2_2", text= "External Hard Disks" },
                        new {  id = "list2_2_3", text= "Monitors" }
                    }
                }
            }
        },
        new {
            text = "Fashion",
            id =  "list3",
            child = new List<object>() {
                new { id= "list3_1", text = "Men" },
                new { id= "list3_2", text = "Women" }
                }
        },
        new {
            text = "Home & Living",
            id = "list4",
            child = new List<object>() {
                new { id= "list4_1", text = "Furniture" },
                new { id= "list4_2", text = "Decor" }
                }
        },
          new {
            text = "Entertainment",
            id = "list5",
            child = new List<object>() {
                new { id= "list5_1", text = "Televisions" },
                new { id= "list5_2", text = "Home Theatres" },
                new { id= "list5_3", text = "Gaming Laptops" },
                }
        }
    };
    ViewBag.Items = Items;
    return View();
}