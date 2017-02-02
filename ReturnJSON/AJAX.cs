 //Return Json List in AJAX request...
 [HttpPost]
        public ActionResult ViewName(<Parameters>)
        {
            var client = new JsonServiceClient("<Url WebApi>");
            var Items = client.Get<Dto>("To complete url request");     
            var model = Items.Where(x => x.cod.Trim() == line).Select(x => x.art).Distinct().ToList();
            List<string> jsonList = h5;
            return Json(jsonList, JsonRequestBehavior.AllowGet);
            
        }
