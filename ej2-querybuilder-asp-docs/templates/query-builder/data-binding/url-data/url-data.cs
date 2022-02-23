public IActionResult QBDatasource([FromBody]DataManagerRequest dm) 
        { 
            IEnumerable DataSource = employeeData; 
            DataOperations operation = new DataOperations(); 
            if (dm.Where != null && dm.Where.Count > 0) //Filtering 
            { 
                DataSource = operation.PerformFiltering(DataSource, dm.Where, dm.Where[0].Operator); 
            } 
            int count = DataSource.Cast<OrdersDetails>().Count(); 
            if (dm.Skip != 0) 
            { 
                DataSource = operation.PerformSkip(DataSource, dm.Skip);         //Paging 
            } 
            if (dm.Take != 0) 
            { 
                DataSource = operation.PerformTake(DataSource, dm.Take); 
            } 
            return dm.RequiresCounts ? Json(new { result = DataSource, count = count }) : Json(DataSource); 
        } 