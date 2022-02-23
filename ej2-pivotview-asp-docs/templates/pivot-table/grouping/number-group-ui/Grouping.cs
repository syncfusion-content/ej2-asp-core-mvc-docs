public ActionResult Index()
{
    var data = GetGroupData();
    ViewBag.DataSource = data;
    return View();
}

public List<PivotData> GetGroupData()
{
    List<PivotData> pivotData = new List<PivotData>();
    pivotData.Add(new PivotData { Date = "Thu Jan 01 2015 20:18:15 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1001, Sold = 6, Products = "Bottles and Cages", Amount = 12 });
    pivotData.Add(new PivotData { Date = "Thu Jan 01 2015 20:18:15 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 9, Products = "Cleaners", Amount = 27 });
    pivotData.Add(new PivotData { Date = "Thu Jan 01 2015 20:18:15 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1003, Sold = 15, Products = "Fenders", Amount = 120 });
    pivotData.Add(new PivotData { Date = "Thu Jan 01 2015 20:18:15 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1004, Sold = 3, Products = "Mountain Bikes", Amount = 180 });
    pivotData.Add(new PivotData { Date = "Thu Jan 01 2015 20:18:15 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1005, Sold = 3, Products = "Road Bikes", Amount = 225 });
    pivotData.Add(new PivotData { Date = "Thu Jan 01 2015 20:18:15 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1007, Sold = 6, Products = "Gloves", Amount = 18 });
    pivotData.Add(new PivotData { Date = "Thu Jan 01 2015 20:18:15 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1008, Sold = 3, Products = "Jerseys", Amount = 15 });
    pivotData.Add(new PivotData { Date = "Thu Jan 01 2015 20:18:15 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1009, Sold = 9, Products = "Shorts", Amount = 36 });
    pivotData.Add(new PivotData { Date = "Mon Jan 05 2015 20:19:15 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1003, Sold = 9, Products = "Fenders", Amount = 72 });
    pivotData.Add(new PivotData { Date = "Mon Feb 02 2015 10:22:07 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 12, Products = "Cleaners", Amount = 36 });
    pivotData.Add(new PivotData { Date = "Tue Feb 10 2015 10:23:07 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 3, Products = "Cleaners", Amount = 9 });
    pivotData.Add(new PivotData { Date = "Mon Jan 05 2015 20:19:15 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1004, Sold = 9, Products = "Mountain Bikes", Amount = 540 });
    pivotData.Add(new PivotData { Date = "Mon Feb 02 2015 10:22:07 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1005, Sold = 6, Products = "Road Bikes", Amount = 450 });
    pivotData.Add(new PivotData { Date = "Tue Feb 10 2015 10:23:07 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1006, Sold = 12, Products = "Touring Bikes", Amount = 780 });
    pivotData.Add(new PivotData { Date = "Mon Jan 05 2015 20:19:15 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1008, Sold = 24, Products = "Jerseys", Amount = 120 });
    pivotData.Add(new PivotData { Date = "Mon Feb 02 2015 10:22:07 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1009, Sold = 3, Products = "Shorts", Amount = 12 });
    pivotData.Add(new PivotData { Date = "Tue Feb 10 2015 10:23:07 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1010, Sold = 18, Products = "Vests", Amount = 36 });
    pivotData.Add(new PivotData { Date = "Fri Feb 20 2015 11:25:07 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 24, Products = "Cleaners", Amount = 72 });
    pivotData.Add(new PivotData { Date = "Sat Mar 07 2015 05:11:50 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1001, Sold = 12, Products = "Bottles and Cages", Amount = 24 });
    pivotData.Add(new PivotData { Date = "Fri Mar 13 2015 05:11:55 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1005, Sold = 6, Products = "Road Bikes", Amount = 450 });
    pivotData.Add(new PivotData { Date = "Tue Sep 01 2015 04:14:43 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1004, Sold = 3, Products = "Mountain Bikes", Amount = 180 });
    pivotData.Add(new PivotData { Date = "Tue Sep 01 2015 04:14:43 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1010, Sold = 6, Products = "Vests", Amount = 12 });
    pivotData.Add(new PivotData { Date = "Sat Sep 05 2015 05:14:43 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1008, Sold = 30, Products = "Jerseys", Amount = 150 });
    pivotData.Add(new PivotData { Date = "Sat Sep 12 2015 04:14:43 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1007, Sold = 9, Products = "Gloves", Amount = 27 });
    pivotData.Add(new PivotData { Date = "Fri Sep 25 2015 04:15:43 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1007, Sold = 6, Products = "Gloves", Amount = 18 });
    pivotData.Add(new PivotData { Date = "Tue Sep 29 2015 05:14:43 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1009, Sold = 9, Products = "Shorts", Amount = 36 });
    pivotData.Add(new PivotData { Date = "Sat Sep 05 2015 05:14:43 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1004, Sold = 6, Products = "Mountain Bikes", Amount = 360 });
    pivotData.Add(new PivotData { Date = "Sat Sep 12 2015 04:14:43 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1001, Sold = 9, Products = "Bottles and Cages", Amount = 18 });
    pivotData.Add(new PivotData { Date = "Fri Sep 25 2015 04:15:43 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 6, Products = "Cleaners", Amount = 18 });
    pivotData.Add(new PivotData { Date = "Tue Sep 29 2015 05:14:43 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1008, Sold = 21, Products = "Jerseys", Amount = 105 });
    pivotData.Add(new PivotData { Date = "Sat Oct 03 2015 18:11:47 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1003, Sold = 3, Products = "Fenders", Amount = 24 });
    pivotData.Add(new PivotData { Date = "Sun Jan 03 2016 17:26:11 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 20, Products = "Cleaners", Amount = 60 });
    pivotData.Add(new PivotData { Date = "Mon Jan 04 2016 15:26:11 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1001, Sold = 16, Products = "Bottles and Cages", Amount = 32 });
    pivotData.Add(new PivotData { Date = "Tue Jan 05 2016 17:30:11 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 12, Products = "Cleaners", Amount = 36 });
    pivotData.Add(new PivotData { Date = "Fri Jan 08 2016 07:26:11 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1003, Sold = 8, Products = "Fenders", Amount = 64 });
    pivotData.Add(new PivotData { Date = "Sat Oct 03 2015 18:11:47 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1005, Sold = 3, Products = "Road Bikes", Amount = 225 });
    pivotData.Add(new PivotData { Date = "Sun Jan 03 2016 17:26:11 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1004, Sold = 4, Products = "Mountain Bikes", Amount = 240 });
    pivotData.Add(new PivotData { Date = "Mon Jan 04 2016 15:26:11 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1005, Sold = 4, Products = "Road Bikes", Amount = 300 });
    pivotData.Add(new PivotData { Date = "Tue Jan 05 2016 17:30:11 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1005, Sold = 4, Products = "Road Bikes", Amount = 300 });
    pivotData.Add(new PivotData { Date = "Fri Jan 08 2016 07:26:11 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1006, Sold = 4, Products = "Touring Bikes", Amount = 260 });
    pivotData.Add(new PivotData { Date = "Sun Jan 10 2016 17:26:25 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1007, Sold = 28, Products = "Gloves", Amount = 84 });
    pivotData.Add(new PivotData { Date = "Thu Feb 11 2016 18:51:14 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1010, Sold = 12, Products = "Vests", Amount = 24 });
    pivotData.Add(new PivotData { Date = "Fri Feb 12 2016 19:51:14 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1001, Sold = 8, Products = "Bottles and Cages", Amount = 16 });
    pivotData.Add(new PivotData { Date = "Fri Feb 19 2016 18:51:14 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 20, Products = "Cleaners", Amount = 60 });
    pivotData.Add(new PivotData { Date = "Sun Mar 20 2016 06:31:12 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 4, Products = "Cleaners", Amount = 12 });
    pivotData.Add(new PivotData { Date = "Fri Feb 19 2016 18:51:14 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1006, Sold = 4, Products = "Touring Bikes", Amount = 260 });
    pivotData.Add(new PivotData { Date = "Sun Mar 20 2016 06:31:12 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1010, Sold = 20, Products = "Vests", Amount = 40 });
    pivotData.Add(new PivotData { Date = "Wed Mar 23 2016 05:33:12 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 16, Products = "Cleaners", Amount = 48 });
    pivotData.Add(new PivotData { Date = "Sun Mar 06 2016 06:31:20 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1005, Sold = 4, Products = "Road Bikes", Amount = 300 });
    pivotData.Add(new PivotData { Date = "Wed May 04 2016 21:41:15 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1004, Sold = 4, Products = "Mountain Bikes", Amount = 240 });
    pivotData.Add(new PivotData { Date = "Wed May 11 2016 21:45:15 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1009, Sold = 20, Products = "Shorts", Amount = 80 });
    pivotData.Add(new PivotData { Date = "Sun Mar 20 2016 06:31:12 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1001, Sold = 16, Products = "Bottles and Cages", Amount = 32 });
    pivotData.Add(new PivotData { Date = "Fri Feb 19 2016 18:51:14 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 8, Products = "Cleaners", Amount = 24 });
    pivotData.Add(new PivotData { Date = "Sun Mar 20 2016 06:31:12 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1008, Sold = 4, Products = "Jerseys", Amount = 20 });
    pivotData.Add(new PivotData { Date = "Wed Mar 23 2016 05:33:12 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1001, Sold = 4, Products = "Bottles and Cages", Amount = 8 });
    pivotData.Add(new PivotData { Date = "Sun Mar 06 2016 06:31:20 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1004, Sold = 4, Products = "Mountain Bikes", Amount = 240 });
    pivotData.Add(new PivotData { Date = "Wed May 04 2016 21:41:15 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1005, Sold = 4, Products = "Road Bikes", Amount = 300 });
    pivotData.Add(new PivotData { Date = "Wed May 11 2016 21:45:15 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1010, Sold = 8, Products = "Vests", Amount = 16 });
    pivotData.Add(new PivotData { Date = "Fri Jun 17 2016 07:09:27 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1003, Sold = 16, Products = "Fenders", Amount = 128 });
    pivotData.Add(new PivotData { Date = "Fri Jul 01 2016 03:47:38 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1005, Sold = 8, Products = "Road Bikes", Amount = 600 });
    pivotData.Add(new PivotData { Date = "Sat Jul 02 2016 05:47:38 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1007, Sold = 20, Products = "Gloves", Amount = 60 });
    pivotData.Add(new PivotData { Date = "Thu Sep 08 2016 11:50:17 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1008, Sold = 8, Products = "Jerseys", Amount = 40 });
    pivotData.Add(new PivotData { Date = "Fri Dec 02 2016 16:05:33 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 4, Products = "Cleaners", Amount = 12 });
    pivotData.Add(new PivotData { Date = "Fri Jun 17 2016 07:09:27 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1001, Sold = 8, Products = "Bottles and Cages", Amount = 16 });
    pivotData.Add(new PivotData { Date = "Fri Jul 01 2016 03:47:38 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1004, Sold = 4, Products = "Mountain Bikes", Amount = 240 });
    pivotData.Add(new PivotData { Date = "Sat Jul 02 2016 05:47:38 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1009, Sold = 16, Products = "Shorts", Amount = 64 });
    pivotData.Add(new PivotData { Date = "Thu Sep 08 2016 11:50:17 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 8, Products = "Cleaners", Amount = 24 });
    pivotData.Add(new PivotData { Date = "Fri Dec 02 2016 16:05:33 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1003, Sold = 12, Products = "Fenders", Amount = 96 });
    pivotData.Add(new PivotData { Date = "Sun Jan 01 2017 20:18:15 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1001, Sold = 4, Products = "Bottles and Cages", Amount = 8 });
    pivotData.Add(new PivotData { Date = "Sun Jan 01 2017 20:18:15 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 6, Products = "Cleaners", Amount = 18 });
    pivotData.Add(new PivotData { Date = "Sun Jan 01 2017 20:18:15 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1003, Sold = 10, Products = "Fenders", Amount = 80 });
    pivotData.Add(new PivotData { Date = "Sun Jan 01 2017 20:18:15 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1004, Sold = 2, Products = "Mountain Bikes", Amount = 120 });
    pivotData.Add(new PivotData { Date = "Sun Jan 01 2017 20:18:15 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1005, Sold = 2, Products = "Road Bikes", Amount = 150 });
    pivotData.Add(new PivotData { Date = "Sun Jan 01 2017 20:18:15 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1007, Sold = 4, Products = "Gloves", Amount = 12 });
    pivotData.Add(new PivotData { Date = "Sun Jan 01 2017 20:18:15 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1008, Sold = 2, Products = "Jerseys", Amount = 10 });
    pivotData.Add(new PivotData { Date = "Sun Jan 01 2017 20:18:15 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1009, Sold = 6, Products = "Shorts", Amount = 24 });
    pivotData.Add(new PivotData { Date = "Thu Jan 05 2017 20:19:15 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1003, Sold = 6, Products = "Fenders", Amount = 48 });
    pivotData.Add(new PivotData { Date = "Thu Feb 02 2017 10:22:07 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 8, Products = "Cleaners", Amount = 24 });
    pivotData.Add(new PivotData { Date = "Fri Feb 10 2017 10:23:07 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 2, Products = "Cleaners", Amount = 6 });
    pivotData.Add(new PivotData { Date = "Thu Jan 05 2017 20:19:15 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1004, Sold = 6, Products = "Mountain Bikes", Amount = 360 });
    pivotData.Add(new PivotData { Date = "Thu Feb 02 2017 10:22:07 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1005, Sold = 4, Products = "Road Bikes", Amount = 300 });
    pivotData.Add(new PivotData { Date = "Fri Feb 10 2017 10:23:07 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1006, Sold = 8, Products = "Touring Bikes", Amount = 520 });
    pivotData.Add(new PivotData { Date = "Thu Jan 05 2017 20:19:15 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1008, Sold = 16, Products = "Jerseys", Amount = 80 });
    pivotData.Add(new PivotData { Date = "Thu Feb 02 2017 10:22:07 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1009, Sold = 2, Products = "Shorts", Amount = 8 });
    pivotData.Add(new PivotData { Date = "Fri Feb 10 2017 10:23:07 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1010, Sold = 12, Products = "Vests", Amount = 24 });
    pivotData.Add(new PivotData { Date = "Mon Feb 20 2017 11:25:07 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 16, Products = "Cleaners", Amount = 48 });
    pivotData.Add(new PivotData { Date = "Tue Mar 07 2017 05:11:50 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1001, Sold = 8, Products = "Bottles and Cages", Amount = 16 });
    pivotData.Add(new PivotData { Date = "Mon Mar 13 2017 05:11:55 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1005, Sold = 4, Products = "Road Bikes", Amount = 300 });
    pivotData.Add(new PivotData { Date = "Fri Sep 01 2017 04:14:43 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1004, Sold = 2, Products = "Mountain Bikes", Amount = 120 });
    pivotData.Add(new PivotData { Date = "Fri Sep 01 2017 04:14:43 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1010, Sold = 4, Products = "Vests", Amount = 8 });
    pivotData.Add(new PivotData { Date = "Tue Sep 05 2017 05:14:43 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1008, Sold = 20, Products = "Jerseys", Amount = 100 });
    pivotData.Add(new PivotData { Date = "Tue Sep 12 2017 04:14:43 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1007, Sold = 6, Products = "Gloves", Amount = 18 });
    pivotData.Add(new PivotData { Date = "Mon Sep 25 2017 04:15:43 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1007, Sold = 4, Products = "Gloves", Amount = 12 });
    pivotData.Add(new PivotData { Date = "Fri Sep 29 2017 05:14:43 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1009, Sold = 6, Products = "Shorts", Amount = 24 });
    pivotData.Add(new PivotData { Date = "Tue Sep 05 2017 05:14:43 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1004, Sold = 4, Products = "Mountain Bikes", Amount = 240 });
    pivotData.Add(new PivotData { Date = "Tue Sep 12 2017 04:14:43 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1001, Sold = 6, Products = "Bottles and Cages", Amount = 12 });
    pivotData.Add(new PivotData { Date = "Mon Sep 25 2017 04:15:43 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 4, Products = "Cleaners", Amount = 12 });
    pivotData.Add(new PivotData { Date = "Fri Sep 29 2017 05:14:43 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1008, Sold = 14, Products = "Jerseys", Amount = 70 });
    pivotData.Add(new PivotData { Date = "Tue Oct 03 2017 18:11:47 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1003, Sold = 2, Products = "Fenders", Amount = 16 });
    pivotData.Add(new PivotData { Date = "Wed Jan 03 2018 17:26:11 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 25, Products = "Cleaners", Amount = 81 });
    pivotData.Add(new PivotData { Date = "Thu Jan 04 2018 15:26:11 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1001, Sold = 20, Products = "Bottles and Cages", Amount = 44 });
    pivotData.Add(new PivotData { Date = "Fri Jan 05 2018 17:30:11 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 15, Products = "Cleaners", Amount = 51 });
    pivotData.Add(new PivotData { Date = "Mon Jan 08 2018 07:26:11 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1003, Sold = 10, Products = "Fenders", Amount = 96 });
    pivotData.Add(new PivotData { Date = "Tue Oct 03 2017 18:11:47 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1005, Sold = 2, Products = "Road Bikes", Amount = 150 });
    pivotData.Add(new PivotData { Date = "Wed Jan 03 2018 17:26:11 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1004, Sold = 5, Products = "Mountain Bikes", Amount = 420 });
    pivotData.Add(new PivotData { Date = "Thu Jan 04 2018 15:26:11 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1005, Sold = 5, Products = "Road Bikes", Amount = 525 });
    pivotData.Add(new PivotData { Date = "Fri Jan 05 2018 17:30:11 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1005, Sold = 5, Products = "Road Bikes", Amount = 525 });
    pivotData.Add(new PivotData { Date = "Mon Jan 08 2018 07:26:11 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1006, Sold = 5, Products = "Touring Bikes", Amount = 455 });
    pivotData.Add(new PivotData { Date = "Wed Jan 10 2018 17:26:25 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1007, Sold = 35, Products = "Gloves", Amount = 111 });
    pivotData.Add(new PivotData { Date = "Sun Feb 11 2018 18:51:14 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1010, Sold = 15, Products = "Vests", Amount = 34 });
    pivotData.Add(new PivotData { Date = "Mon Feb 12 2018 19:51:14 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1001, Sold = 10, Products = "Bottles and Cages", Amount = 24 });
    pivotData.Add(new PivotData { Date = "Mon Feb 19 2018 18:51:14 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 25, Products = "Cleaners", Amount = 81 });
    pivotData.Add(new PivotData { Date = "Tue Mar 20 2018 06:31:12 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 5, Products = "Cleaners", Amount = 21 });
    pivotData.Add(new PivotData { Date = "Mon Feb 19 2018 18:51:14 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1006, Sold = 5, Products = "Touring Bikes", Amount = 455 });
    pivotData.Add(new PivotData { Date = "Tue Mar 20 2018 06:31:12 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1010, Sold = 25, Products = "Vests", Amount = 54 });
    pivotData.Add(new PivotData { Date = "Fri Mar 23 2018 05:33:12 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 20, Products = "Cleaners", Amount = 66 });
    pivotData.Add(new PivotData { Date = "Tue Mar 06 2018 06:31:20 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1005, Sold = 5, Products = "Road Bikes", Amount = 525 });
    pivotData.Add(new PivotData { Date = "Fri May 04 2018 21:41:15 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1004, Sold = 5, Products = "Mountain Bikes", Amount = 420 });
    pivotData.Add(new PivotData { Date = "Fri May 11 2018 21:45:15 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1009, Sold = 25, Products = "Shorts", Amount = 108 });
    pivotData.Add(new PivotData { Date = "Tue Mar 20 2018 06:31:12 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1001, Sold = 20, Products = "Bottles and Cages", Amount = 44 });
    pivotData.Add(new PivotData { Date = "Mon Feb 19 2018 18:51:14 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 10, Products = "Cleaners", Amount = 36 });
    pivotData.Add(new PivotData { Date = "Tue Mar 20 2018 06:31:12 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1008, Sold = 5, Products = "Jerseys", Amount = 35 });
    pivotData.Add(new PivotData { Date = "Fri Mar 23 2018 05:33:12 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1001, Sold = 5, Products = "Bottles and Cages", Amount = 14 });
    pivotData.Add(new PivotData { Date = "Tue Mar 06 2018 06:31:20 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1004, Sold = 5, Products = "Mountain Bikes", Amount = 420 });
    pivotData.Add(new PivotData { Date = "Fri May 04 2018 21:41:15 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1005, Sold = 5, Products = "Road Bikes", Amount = 525 });
    pivotData.Add(new PivotData { Date = "Fri May 11 2018 21:45:15 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1010, Sold = 10, Products = "Vests", Amount = 24 });
    pivotData.Add(new PivotData { Date = "Sun Jun 17 2018 07:09:27 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1003, Sold = 20, Products = "Fenders", Amount = 176 });
    pivotData.Add(new PivotData { Date = "Sun Jul 01 2018 03:47:38 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1005, Sold = 10, Products = "Road Bikes", Amount = 900 });
    pivotData.Add(new PivotData { Date = "Mon Jul 02 2018 05:47:38 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1007, Sold = 25, Products = "Gloves", Amount = 81 });
    pivotData.Add(new PivotData { Date = "Sat Sep 08 2018 11:50:17 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1008, Sold = 10, Products = "Jerseys", Amount = 60 });
    pivotData.Add(new PivotData { Date = "Sun Dec 02 2018 16:05:33 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 5, Products = "Cleaners", Amount = 21 });
    pivotData.Add(new PivotData { Date = "Sun Jun 17 2018 07:09:27 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1001, Sold = 10, Products = "Bottles and Cages", Amount = 24 });
    pivotData.Add(new PivotData { Date = "Sun Jul 01 2018 03:47:38 GMT+0530 (India Standard Time)", Product_Categories = "Bikes", Product_ID = 1004, Sold = 5, Products = "Mountain Bikes", Amount = 420 });
    pivotData.Add(new PivotData { Date = "Mon Jul 02 2018 05:47:38 GMT+0530 (India Standard Time)", Product_Categories = "Clothings", Product_ID = 1009, Sold = 20, Products = "Shorts", Amount = 88 });
    pivotData.Add(new PivotData { Date = "Sat Sep 08 2018 11:50:17 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1002, Sold = 10, Products = "Cleaners", Amount = 36 });
    pivotData.Add(new PivotData { Date = "Sun Dec 02 2018 16:05:33 GMT+0530 (India Standard Time)", Product_Categories = "Accessories", Product_ID = 1003, Sold = 15, Products = "Fenders", Amount = 136 });
    return pivotData;
}

public class PivotData
{
    public int Sold { get; set; }
    public double Amount { get; set; }
    public string Date { get; set; }
    public string Product_Categories { get; set; }
    public double Product_ID { get; set; }
    public string Products { get; set; }
}