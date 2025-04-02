 public IActionResult Index()
 { 
   // Timezone List for Dropdown.
   List<TimeZoneData> timeZones = new List<TimeZoneData>
   {
      new TimeZoneData { Value = -12, Text = "-12:00 UTC" },
      new TimeZoneData { Value = -11, Text = "-11:00 UTC" },
      new TimeZoneData { Value = -10, Text = "-10:00 UTC" },
      new TimeZoneData { Value = -9, Text = "-09:00 UTC" },
      new TimeZoneData { Value = -8, Text = "-08:00 UTC" },
      new TimeZoneData { Value = -7, Text = "-07:00 UTC" },
      new TimeZoneData { Value = -6, Text = "-06:00 UTC" },
      new TimeZoneData { Value = -5, Text = "-05:00 UTC" },
      new TimeZoneData { Value = -4, Text = "-04:00 UTC" },
      new TimeZoneData { Value = -3, Text = "-03:00 UTC" },
      new TimeZoneData { Value = -2, Text = "-02:00 UTC" },
      new TimeZoneData { Value = -1, Text = "-01:00 UTC" },
      new TimeZoneData { Value = 0, Text = "+00:00 UTC" },
      new TimeZoneData { Value = 1, Text = "+01:00 UTC" },
      new TimeZoneData { Value = 2, Text = "+02:00 UTC" },
      new TimeZoneData { Value = 3, Text = "+03:00 UTC" },
      new TimeZoneData { Value = 4, Text = "+04:00 UTC" },
      new TimeZoneData { Value = 5, Text = "+05:00 UTC" },
      new TimeZoneData { Value = 5.5, Text = "+05:30 UTC" },
      new TimeZoneData { Value = 6, Text = "+06:00 UTC" },
      new TimeZoneData { Value = 7, Text = "+07:00 UTC" },
      new TimeZoneData { Value = 8, Text = "+08:00 UTC" },
      new TimeZoneData { Value = 9, Text = "+09:00 UTC" },
      new TimeZoneData { Value = 10, Text = "+10:00 UTC" },
      new TimeZoneData { Value = 11, Text = "+11:00 UTC" },
      new TimeZoneData { Value = 12, Text = "+12:00 UTC" },
      new TimeZoneData { Value = 13, Text = "+13:00 UTC" },
      new TimeZoneData { Value = 14, Text = "+14:00 UTC" }
   };

   ViewBag.TimeZones = timeZones;
   return View();
 }

      