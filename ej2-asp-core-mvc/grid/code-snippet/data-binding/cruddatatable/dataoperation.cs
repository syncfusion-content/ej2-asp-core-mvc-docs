public ActionResult Update(ExpandoObject value)
{
    //Here you can Update a record based on your scenario
    return Json(value, JsonRequestBehavior.AllowGet);
}

       
public ActionResult Insert(ExpandoObject value)
{
    //Here you can Insert a record based on your scenario
	return Json(value, JsonRequestBehavior.AllowGet);
}

		
public ActionResult Delete(int key)
{
    //Here you can Delete a record based on your scenario
    return Json(key, JsonRequestBehavior.AllowGet);
}