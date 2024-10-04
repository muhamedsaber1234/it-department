using ITDepartment_BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace ItDepartment_presentationlayer.Controllers
{
    public class PropertyController : Controller
    {
      private readonly IPropertyService propertyService;
        public PropertyController(IPropertyService propertyService)
        {
            this.propertyService = propertyService;
        }
        public ActionResult GetAllByCategoryId(int id)
        {
           var properties = propertyService.GetAllByCategoryId(id);
            return Json(properties);
        }
    }
}
