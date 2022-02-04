        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        public object Get()
        {
            List<EmployeeModel> revenue = new List<EmployeeModel>();
            revenue.Add(new EmployeeModel() { Year = "2018-06-13T00:00:00", yValue = 30, color = "red" });
            revenue.Add(new EmployeeModel() { Year = "2018-06-14T00:00:00", yValue = 20, color = "blue" });
            revenue.Add(new EmployeeModel() { Year = "2018-06-15T00:00:00", yValue = 15, color = "green" });
            revenue.Add(new EmployeeModel() { Year = "2018-06-16T00:00:00", yValue = 30, color = "orange" });
            revenue.Add(new EmployeeModel() { Year = "2018-06-17T00:00:00", yValue = 60, color = "skyblue" });
            revenue.Add(new EmployeeModel() { Year = "2018-06-18T00:00:00", yValue = 10, color = "red" });
            revenue.Add(new EmployeeModel() { Year = "2018-06-19T00:00:00", yValue = 70, color = "yellow" });
            revenue.Add(new EmployeeModel() { Year = "2018-06-20T00:00:00", yValue = 50, color = "pink" });
            revenue.Add(new EmployeeModel() { Year = "2018-06-21T00:00:00", yValue = 88, color = "green" });
            revenue.Add(new EmployeeModel() { Year = "2018-06-22T00:00:00", yValue = 35, color = "blue" });

            return new { Items = revenue, Count = revenue.Count() };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        public class EmployeeModel
        {
            // for Paging
            public string Year { get; set; }
            public double yValue { get; set; }
            public string color { get; set; }

        }