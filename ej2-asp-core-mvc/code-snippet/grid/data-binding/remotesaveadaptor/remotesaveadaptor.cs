public ActionResult Index()
{
   var data = OrderRepository.GetAllRecords();
   ViewBag.dataSource = data;
   return View();
}

public ActionResult Update(EditableOrder value)
{
   OrderRepository.Update(value);
   var data = OrderRepository.GetAllRecords();
   return Json(data, JsonRequestBehavior.AllowGet);
}

public ActionResult Insert(EditableOrder value)
{
   OrderRepository.Add(value);
   var data = OrderRepository.GetAllRecords();
   return Json(data, JsonRequestBehavior.AllowGet);
}

public ActionResult Delete(int key)
{
   OrderRepository.Delete(key);
   var data = OrderRepository.GetAllRecords();
   return Json(data, JsonRequestBehavior.AllowGet);
}