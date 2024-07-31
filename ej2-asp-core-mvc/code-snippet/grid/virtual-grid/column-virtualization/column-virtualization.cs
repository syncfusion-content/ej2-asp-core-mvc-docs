public ActionResult Index()
   {
          // Call the method to generate the data
      ViewBag.dataSource = GenerateData(10000);
      return View();
}

private List<object> GenerateData(int count)
      {
          var names = new[]
          {
         "hardire", "abramjo01", "aubucch01", "Hook", "Rumpelstiltskin", "Belle", "Emma", "Regina", "Aurora", "Elsa", "Anna",
         "Snow White", "Prince Charming", "Cora", "Zelena", "August", "Mulan", "Graham", "Discord", "Will", "Robin Hood",
         "Jiminy Cricket", "Henry", "Neal", "Red", "Aaran", "Aaren", "Aarez", "Aarman", "Aaron", "Aaron-James", "Aarron",
         "Aaryan", "Aaryn", "Aayan", "Aazaan", "Abaan", "Abbas", "Abdallah", "Abdalroof", "Abdihakim", "Abdirahman",
         "Abdisalam", "Abdul", "Abdul-Aziz", "Abdulbasir", "Abdulkadir", "Abdulkarem", "Abdulkhader", "Abdullah",
         "Abdul-Majeed", "Abdulmalik", "Abdul-Rehman", "Abdur", "Abdurraheem", "Abdur-Rahman", "Abdur-Rehmaan", "Abel",
         "Abhinav", "Abhisumant", "Abid", "Abir", "Abraham", "Abu", "Abubakar", "Ace", "Adain", "Adam", "Adam-James",
         "Addison", "Addisson", "Adegbola", "Adegbolahan", "Aden", "Adenn", "Adie", "Adil", "Aditya", "Adnan", "Adrian",
         "Adrien", "Aedan", "Aedin", "Aedyn", "Aeron", "Afonso", "Ahmad", "Ahmed", "Ahmed-Aziz", "Ahoua", "Ahtasham",
         "Aiadan", "Aidan", "Aiden", "Aiden-Jack", "Aiden-Vee"
        };

          var random = new Random();
          var data = new List<object>();

          for (int i = 0; i < count; i++)
          {
              data.Add(new
              {
                  SNo = i + 1,
                  Field1 = names[random.Next(names.Length)],
                  Field2 = 1967 + (i % 10),
                  Field3 = random.Next(200),
                  Field4 = random.Next(100),
                  Field5 = random.Next(2000),
                  Field6 = random.Next(1000),
                  Field7 = random.Next(100),
                  Field8 = random.Next(10),
                  Field9 = random.Next(10),
                  Field10 = random.Next(100),
                  Field11 = random.Next(100),
                  Field12 = random.Next(1000),
                  Field13 = random.Next(10),
                  Field14 = random.Next(10),
                  Field15 = random.Next(1000),
                  Field16 = random.Next(200),
                  Field17 = random.Next(300),
                  Field18 = random.Next(400),
                  Field19 = random.Next(500),
                  Field20 = random.Next(700),
                  Field21 = random.Next(800),
                  Field22 = random.Next(1000),
                  Field23 = random.Next(2000),
                  Field24 = random.Next(150),
                  Field25 = random.Next(1000),
                  Field26 = random.Next(100),
                  Field27 = random.Next(400),
                  Field28 = random.Next(600),
                  Field29 = random.Next(500),
                  Field30 = random.Next(300)
              });
          }

          return data;
      
  }