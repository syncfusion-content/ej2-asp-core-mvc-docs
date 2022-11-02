public IActionResult Index()
{
    ViewBag.Data = dbquery.GetSQLResult();
    return View();
}

public class DbaseQuery
{
    public dynamic GetSQLResult()
    {
        string conSTR = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory + @"\App_Data\Database1.mdf;Integrated Security=True";
        string xquery = "SELECT * FROM table1";
        SqlConnection sqlConn = new SqlConnection(conSTR);
        sqlConn.Open();
        SqlCommand cmd = new SqlCommand(xquery, sqlConn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        for (var i = 0; i < dt.Rows.Count; i++)
        {
            for (var j = 0; j < dt.Rows[i].ItemArray.Length; j++)
            {
                dt.Rows[i].ItemArray[j] = dt.Rows[i].ItemArray[j].ToString().Trim();
            }
        }
        return dt;
    }
}