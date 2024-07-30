public ActionResult Demo()
{
    MultiColumnComboBoxRecord model = new MultiColumnComboBoxRecord();
    model.Records = new MultiColumnComboBoxRecord().GenerateTasks(150);
    ViewBag.EmpData = model;
    return View(model);
}

public class MultiColumnComboBoxRecord
{
    public int TaskID { get; set; }
    public string Engineer { get; set; }
    public string Designation { get; set; }
    public int Estimation { get; set; }
    public string Status { get; set; }

    public List<MultiColumnComboBoxRecord> Records { get; set; }

    public List<MultiColumnComboBoxRecord> GenerateTasks(int count)
    {
        var names = new List<string> { "John", "Alice", "Bob", "Mario Pontes", "Yang Wang", "Michael", "Nancy", "Robert King" };
        var hours = new List<int> { 8, 12, 16 };
        var status = new List<string> { "Pending", "Completed", "In Progress" };
        var designation = new List<string> { "Engineer", "Manager", "Tester" };
        var result = new List<MultiColumnComboBoxRecord>();
        for (var i = 0; i < count; i++)
        {
            result.Add(new MultiColumnComboBoxRecord
            {
                TaskID = i + 1,
                Engineer = names[new Random().Next(names.Count)],
                Designation = designation[new Random().Next(designation.Count)],
                Estimation = hours[new Random().Next(hours.Count)],
                Status = status[new Random().Next(status.Count)]
            });
        }
        return result;
    }
}