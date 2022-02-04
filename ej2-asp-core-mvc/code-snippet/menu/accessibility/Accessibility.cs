public ActionResult Index()
{
    // Multi Level Menu
    List<object> menuItems = new List<object>();
    menuItems.Add(new
    {
        text = "Fashion",
        items = new List<object>()
        {
            new {
                text = "Men Fashion",
                items = new List<object>()
                {
                    new {
                        text = "Personal Care",
                                items = new List<object>()
                                {
                                    new {
                                        text = "Trimmers"
                                    },
                                    new {
                                        text = "Shavers"
                                    }
                                }
                            },
                            new {
                                text = "Clothing",
                                items = new List<object>()
                                {
                                    new {
                                        text = "Shirts"
                                    },
                                    new {
                                        text = "Jackets"
                                    },
                                    new {
                                        text = "Track Suits"
                                    }
                                }
                            },
                            new { text = "Footwear"}
                        }
                    },
                    new {
                        text = "Women Fashion",
                        items = new List<object>()
                        {
                            new {
                                text = "Clothing",
                                 items = new List<object>()
                                {
                                    new {
                                        text = "Kurtas"
                                    },
                                    new {
                                        text = "Salwars"
                                    },
                                    new {
                                        text = "Sarees"
                                    }
                                }

                            },
                            new {
                                text = "Jewellery",
                                 items = new List<object>()
                                {
                                    new {
                                        text = "Nosepins"
                                    },
                                    new {
                                        text = "Anklets"
                                    }
                                }
                            }
                        }
                    }
                }
    });
    menuItems.Add(new
    {
        text = "Home & Living",
        items = new List<object>()
                {
                   new {
                          text = "Washing Machine",
                           items = new List<object>()
                           {
                               new {
                                      text = "Fully Automatic"
                                },
                                new {
                                     text = "Semi Automatic"
                                   }
                           }
                       },
                    new {
                         text = "Air Conditioners",
                         items = new List<object>()
                            {
                               new {
                                      text = "Inverter ACs"
                                },
                                new {
                                     text = "Split ACs"
                                   }
                                }
                       }
                    }

    });
    menuItems.Add(new
    {
        text = "Sports",
    });
    menuItems.Add(new
    {
        text = "Gaming",
    });

    ViewBag.menuItems = menuItems;
    return View();
}