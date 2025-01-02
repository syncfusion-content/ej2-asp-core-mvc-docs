public ActionResult Index()
{
    List<object> data = new List<object>()
    {
        new { No= "1",  ReleasedOn= "1994",  Title= "Forrest Gump",  Rating= "5 Stars",  Casts= "Tom Hanks, Robin Wright, Gary Sinise",  DirectedBy= "Robert Zemeckis", Genre= "Drama", Comments= "Based on the 1986 novel of the same name by Winston Groom" },
        new { No= "2",  ReleasedOn= "1946",  Title= "It’s a Wonderful Life",  Rating= "2 Stars",  Casts= "James Stewart, Donna Reed, Lionel Barrymore",  DirectedBy= "Frank Capra", Genre= "Drama", Comments= "Colorized version"  },
        new { No= "3",  ReleasedOn= "1988",  Title= "Big",  Rating= "4 Stars",  Casts= "Tom Hanks, Elizabeth Perkins, Robert Loggia",  DirectedBy= "Penny Marshall", Genre= "Comedy", Comments= "A thirteen-year-old boy wishes to be big, and his wish comes true."  },
        new { No= "4",  ReleasedOn= "1954",  Title= "Rear Window",  Rating= "4 Stars",  Casts= "James Stewart, Grace Kelly, Wendell Corey",  DirectedBy= "Alfred Hitchcock" , Genre= "Suspense", Comments= "Truly suspenseful and masterfully crafted" },
    };
    ViewBag.DefaultData = data;
    return View();
}