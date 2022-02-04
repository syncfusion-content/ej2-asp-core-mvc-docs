public class Model
{
    public static List<object> GetLocalData()
    {
        List<object> data = new List<object>()
            {
                new
                {
                    continent = "Asia",
                    countries = new List<object>()
                    {
                        new
                        {
                            country = "China",
                            languages = new List<object>()
                            {
                                new { language= "Chinese"},
                                new { language= "Cantonese"}
                            }
                        },
                        new {
                            country = "India",
                            languages =new List<object>() {
                                new { language= "English"},
                                new { language= "Hindi"},
                                new { language= "Tamil"}
                            }
                        },
                        new {
                            country = "Japan",
                            languages =new List<object>() {
                                new { language= "Japanese"}
                            }
                        }
                    }
                },
                new
                {
                    continent = "Africa",
                    countries = new List<object>()
                    {
                        new {
                            country = "Nigeria",
                            languages =new List<object>() {
                                new { language= "English"},
                                new { language= "Hausa"}
                            }
                        },
                        new
                        {
                            country = "Egypt",
                            languages =new List<object>() {
                                new { language= "Arabic"}
                            }
                        },
                        new
                        {
                            country = "South Africa",
                            languages =new List<object>() {
                                new { language= "Tswana"},
                                new { language= "Swati"}
                            }
                        }
                    }
                },
                new
                {
                    continent = "North America",
                    countries = new List<object>()
                    {
                        new
                        {
                            country = "Canada",
                            languages =new List<object>() {
                                new { language= "French"}
                            }
                        },
                        new
                        {
                            country = "Mexico",
                            languages =new List<object>() {
                                new { language= "Spanish"}
                            }
                        },
                        new
                        {
                            country = "USA",
                            languages =new List<object>() {
                                new { language= "English"}
                            }
                        }
                    }
                },
                new
                {
                    continent = "South America",
                    countries = new List<object>()
                    {
                        new
                        {
                            country = "Brazil",
                            languages =new List<object>() {
                                new { language= "Portuguese"}
                            }
                        },
                        new
                        {
                            country = "Colombia",
                            languages =new List<object>() {
                                new { language= "Spanish"}
                            }
                        },
                        new
                        {
                            country = "Argentina",
                            languages =new List<object>() {
                                new { language= "Spanish"},
                            }
                        }
                    }
                },
                new
                {
                    continent = "Oceania",
                    countries = new List<object>()
                    {
                        new { country = "Australia"},
                        new { country = "New Zealand"},
                        new { country = "Samoa"}
                    }
                }
            };
        return data;
    }
}