public class KanbanDataModels
    {
    public string Id { get; set; }
    public string OrderID { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
    public string Size { get; set; }
    public string Status { get; set; }
    public string Category { get; set; }
    public string Price { get; set; }
    public string Description { get; set; }
    public string Tags { get; set; }
    public string ImageURL { get; set; }

         public List<KanbanDataModels> KanbanPizzaData()
        {
            List<KanbanDataModels> PizzaData = new List<KanbanDataModels>();
            PizzaData.Add(new KanbanDataModels { Id = "1", OrderID = "Order ID - #16365", Title = "Mexican Green Wave", Type = "Vegetarian", Size = "Small", Category = "Order", Description = "Stromboli sandwich with chili sauce.", Tags = "Onions Pepper Cheese", ImageURL = "menu_01" });
            PizzaData.Add(new KanbanDataModels { Id = "2", OrderID = "Order ID - #16366", Title = "Milan Veg Fantasy", Type = "Vegetarian", Size = "Medium", Category = "Order", Description = "Zucchini wrapped in spicy grilled seasoning along with tomato and jalapeno.", Tags = "Onions Pepper Tomato Zucchini", ImageURL = "menu_01" });
            PizzaData.Add(new KanbanDataModels { Id = "3", OrderID = "Order ID - #16367", Title = "Peppy Paneer", Type = "Vegetarian", Size = "Large", Category = "Ready to Serve", Description = "It's made using toppings of tomato mozzarella cheese and fresh basil which represent the red white and green of the Italian flag.", Tags = "Onions Pepper Cheese", ImageURL = "menu_02" });
            PizzaData.Add(new KanbanDataModels { Id = "4", OrderID = "Order ID - #16368", Title = "Margherita", Type = "Vegetarian", Size = "Small", Category = "Menu", Description = "Lebanese Pizza topped with tomato sauce.", Tags = "Onions Pepper Cheese", ImageURL = "menu_03", Price = "$4.79" });
            PizzaData.Add(new KanbanDataModels { Id = "5", OrderID = "Order ID - #16369", Title = "Farm House", Type = "Vegetarian", Size = "Small", Category = "Delivered", Description = "Stromboli sandwich with chili sauce.", Tags = "Onions Pepper Cheese", ImageURL = "menu_04" });
            PizzaData.Add(new KanbanDataModels { Id = "6", OrderID = "Order ID - #16370", Title = "BBQ Chicken", Type = "Non-Vegetarian", Size = "Medium", Category = "Ready to Serve", Description = "BBQ Chicken with chili sauce.", Tags = "Onions Pepper Chicken BBQ", ImageURL = "menu_05", Price = "$4.79" });
            PizzaData.Add(new KanbanDataModels { Id = "7", OrderID = "Order ID - #16371", Title = "Tandoori Chicken", Type = "Non-Vegetarian", Size = "Large", Category = "Ready to Serve", Description = "Tandoori Chicken with chili sauce.", Tags = "Onions Tandoori Pepper Chicken", ImageURL = "menu_06" });
            PizzaData.Add(new KanbanDataModels { Id = "8", OrderID = "Order ID - #16372", Title = "BBQ Prawn", Type = "Non-Vegetarian", Size = "Large", Category = "Order", Description = "BBQ Prawn with chili sauce.", Tags = "Onions BBQ Pepper Prawn", ImageURL = "menu_07" });
            PizzaData.Add(new KanbanDataModels { Id = "9", OrderID = "Order ID - #16373", Title = "Italian Chicken", Type = "Non-Vegetarian", Size = "Medium", Category = "Menu", Description = "Italian Chicken with White sauce.", Tags = "Onions Pepper Italian Chicken", ImageURL = "menu_08", Price = "$11.99" });
            PizzaData.Add(new KanbanDataModels { Id = "10", OrderID = "Order ID - #16374", Title = "Garlic Prawn", Type = "Non-Vegetarian", Size = "Small", Category = "Delivered", Description = "Prawn with chili sauce.", Tags = "Onions Garlic Pepper Prawn", ImageURL = "menu_13" });
            PizzaData.Add(new KanbanDataModels { Id = "11", OrderID = "Order ID - #16375", Title = "Double Cheese Margherita", Type = "Vegetarian", Size = "Medium", Category = "Delivered", Description = "Margherita with chili sauce and double Cheese.", Tags = "Onions, Pepper, Cheese", ImageURL = "menu_10", Price = "$11.99" });
            PizzaData.Add(new KanbanDataModels { Id = "12", OrderID = "Order ID - #16376", Title = "Veggie Delight", Type = "Vegetarian", Size = "Large", Category = "Menu", Description = "Veggie Delight with chili sauce and extra toppings.", Tags = "Onions, Capsicum, Pepper, Cheese", ImageURL = "menu_11", Price = "$14.99" });
            PizzaData.Add(new KanbanDataModels { Id = "13", OrderID = "Order ID - #16377", Title = "Paneer Tikka", Type = "Vegetarian", Size = "Large", Category = "Order", Description = "Paneer Tikka with chili sauce.", Tags = "Onions, Paneer, Pepper, Tikka", ImageURL = "menu_12", Price = "$14.99" });
            PizzaData.Add(new KanbanDataModels { Id = "14", OrderID = "Order ID - #16378", Title = "Chicken Tikka", Type = "Non-Vegetarian", Size = "Medium", Category = "Ready to Serve", Description = "Chicken Tikka with White sauce.", Tags = "Onions, Pepper, Chicken, Tikka, Boneless", ImageURL = "menu_14", Price = "$11.99" });
            PizzaData.Add(new KanbanDataModels { Id = "15", OrderID = "Order ID - #16379", Title = "Kadai Chicken", Type = "Non-Vegetarian", Size = "Small", Category = "Menu", Description = "Kadai Chicken with chili sauce.", Tags = "Onions, Pepper, Chicken", ImageURL = "menu_15", Price = "$4.79" });
            PizzaData.Add(new KanbanDataModels { Id = "16", OrderID = "Order ID - #16380", Title = "Hot Vege", Type = "Vegetarian", Size = "Medium", Category = "Delivered", Description = "Capsicum with chili sauce and Double Cheese with extra toppings.", Tags = "Onions, Pepper, Capsicum, Cheese", ImageURL = "menu_16", Price = "$11.99" });
            PizzaData.Add(new KanbanDataModels { Id = "17", OrderID = "Order ID - #16381", Title = "Kadai Paneer", Type = "Vegetarian", Size = "Large", Category = "Menu", Description = "Kadai Paneer with chili sauce and extra toppings.", Tags = "Onions, Capsicum, Pepper, Paneer", ImageURL = "menu_17", Price = "$14.99" });
            PizzaData.Add(new KanbanDataModels { Id = "18", OrderID = "Order ID - #16382", Title = "Tomato Pizza", Type = "Vegetarian", Size = "Large", Category = "Served", Description = "Tomato Pizza with chili sauce and extra toppings.", Tags = "Onions, Tomato, Pepper, Capsicum", ImageURL = "menu_18", Price = "$14.99" });
            return PizzaData;
        }
    }
