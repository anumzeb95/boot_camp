using Microsoft.AspNetCore.Mvc;
using user.Models;
using user.Services;

namespace user.Controllers
{
    public class studentController : Controller
    {
        public IActionResult Add()
        {
            return View(userService.GetAll());
        }
     //Create

        [HttpPost]
        public IActionResult Add(userModel model)
        {
            userService.Add(model);
            return View(userService.GetAll());
        }

        //Delete
        public IActionResult Delete()
        {
            return View(userService.GetAll());
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            userService.Delete(id);
            return RedirectToAction("Add");
        }

        //Update
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateData(userModel tempmodel)
        {
            userService.Update(tempmodel);
            return RedirectToAction("Add");
        }


    }
}
