using ITDepartment_BusinessLogic.Services;
using ITDepartment_DataAccess.models;
using Microsoft.AspNetCore.Mvc;
using ITDepartment_BusinessLogic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ItDepartment_presentationlayer.Controllers
{

    namespace ItDepartment_presentationlayer.Controllers
    {
        public class DeviceController : Controller
        {
            private readonly IDeviceService _deviceService;
            private readonly ICategoryService _categoryService;

            public DeviceController(IDeviceService deviceService, ICategoryService categoryService, ILogger<DeviceController> logger)
            {
                _deviceService = deviceService;
                _categoryService = categoryService;
            }

            [HttpGet]
            public IActionResult Index()
            {
                try
                {
                    var devices = _deviceService.GetAllWithCategory();
                    return View(devices);
                }
                catch (Exception ex)
                {
                    return View("Error", new { Message = "An error occurred while retrieving devices. Please try again later." });
                }
            }

            [HttpGet]
            public IActionResult Create()
            {
                try
                {
                    ViewBag.Categories = new SelectList(_categoryService.GetAll(), "Id", "Name");
                    return View();
                }
                catch (Exception ex)
                {

                    return View("Error", new { Message = "An error occurred while preparing to create a device. Please try again later." });

                }
                

            }

            [HttpPost]
            public IActionResult Create(Device device, List<PropertyValue> propertyValues)
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        _deviceService.AddDevice(device, propertyValues);
                        return RedirectToAction("Index");
                    }
                    return View(device);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "An error occurred while creating the device. Please try again later.");
                    ViewBag.Categories = new SelectList(_categoryService.GetAll(), "Id", "Name");
                    return View(device);
                }
            }

            [HttpGet]
            public IActionResult Edit(int id)
            {
                try
                {
                    var device = _deviceService.GetDeviceById(id);
                    if (device == null)
                    {
                        return NotFound();
                    }

                    ViewBag.Categories = new SelectList(_categoryService.GetAll(), "Id", "Name");
                    return View(device);
                }
                catch (Exception ex)
                {
                    return View("Error", new { Message = "An error occurred while retrieving the device. Please try again later." });
                }
            }

            [HttpPost]
            public IActionResult Edit(int id, Device device, List<PropertyValue> propertyValues)
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        _deviceService.UpdateDevice(device, propertyValues);
                        return RedirectToAction("Index");
                    }
                    return View(device);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "An error occurred while updating the device. Please try again later.");
                    ViewBag.Categories = new SelectList(_categoryService.GetAll(), "Id", "Name");
                    return View(device);
                }
            }
        }
    }
}
