using ITDepartment_BusinessLogic.Services;
using ITDepartment_DataAccess.models;
using Microsoft.AspNetCore.Mvc;
using ITDepartment_BusinessLogic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ItDepartment_presentationlayer.Controllers
{
    public class DeviceController : Controller
    {
        private readonly IDeviceService _deviceService;
        private readonly ICategoryService _categoryService;

        public DeviceController(IDeviceService deviceService,ICategoryService categoryService)
        {
            _deviceService = deviceService;
            _categoryService= categoryService;

        }
        [HttpGet]
        public IActionResult Index()
        {
            var devices = _deviceService.GetAllWithCategory();
            return View(devices);
        }
        [HttpGet]
        public IActionResult Create()
        {
            
            ViewBag.Categories = new SelectList(_categoryService.GetAll(), "Id", "Name");
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(Device device, List<PropertyValue> propertyValues)
        {
            if (ModelState.IsValid)
            {
                _deviceService.AddDevice(device, propertyValues);
                return RedirectToAction("Index");
            }
            return View(device);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var device = _deviceService.GetDeviceById(id);
            if (device == null)
            {
                return NotFound();
            }
            
            ViewBag.Categories = new SelectList(_categoryService.GetAll(), "Id", "Name");
            return View(device);
        }

        [HttpPost]
        public IActionResult Edit(int id, Device device, List<PropertyValue> propertyValues)
        {
            if (ModelState.IsValid)
            {
                _deviceService.UpdateDevice(device, propertyValues);
                return RedirectToAction("Index");
            }
            return View(device);

        }

    }
}
