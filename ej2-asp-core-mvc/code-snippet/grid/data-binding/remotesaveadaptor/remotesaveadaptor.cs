public ActionResult Index()
{
   var data = OrderRepository.GetAllRecords();
   ViewBag.dataSource = data;
   return View();
}

public ActionResult Update(EditableOrder value)
{
   var data = OrderRepository.Update(value);
   return Json(data, JsonRequestBehavior.AllowGet);
}

public ActionResult Insert(EditableOrder value)
{
   var data = OrderRepository.Add(value);
   return Json(data, JsonRequestBehavior.AllowGet);
}

public ActionResult Delete(int key)
{
   OrderRepository.Delete(key);
   return Json(key, JsonRequestBehavior.AllowGet);
}