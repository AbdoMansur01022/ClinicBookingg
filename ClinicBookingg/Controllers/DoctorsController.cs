using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ClinicBookingg.Data;
using ClinicBookingg.Models;

namespace ClinicBookingg.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly DoctorRepository _repository;

        public DoctorsController(DoctorRepository repository)
        {
            _repository = repository;
        }

        // عرض الأطباء متاح للجميع
        public IActionResult Index()
        {
            var doctors = _repository.GetAll();
            return View(doctors);
        }

        // Q4 & Q6: الإضافة والتعديل والحذف مسموحة فقط للـ Admin

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Create(Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(doctor);
                return RedirectToAction(nameof(Index));
            }
            return View(doctor);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var doctor = _repository.GetById(id);
            if (doctor == null) return NotFound();
            return View(doctor);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Edit(Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(doctor);
                return RedirectToAction(nameof(Index));
            }
            return View(doctor);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}