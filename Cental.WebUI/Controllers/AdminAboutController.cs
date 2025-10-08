using Cental.BusinessLayer.Abstract;
using Cental.DataTransferObjectLayer.Dtos.AboutDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;

namespace Cental.WebUI.Controllers
{
    public class AdminAboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AdminAboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            return View(_aboutService.TGetAll().Select(x => new ToListAboutDto
            {
                AboutId = x.AboutId,
                Mission = x.Mission,
                Vision = x.Vision
            }).ToList());
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto model)
        {

            //Manuel olarak object to object mapping
            _aboutService.TCreate(new About
            {
                Description1 = model.Description1,
                Description2 = model.Description2,
                ImageUrl1 = model.ImageUrl1,
                ImageUrl2 = model.ImageUrl2,
                Item1 = model.Item1,
                Item2 = model.Item2,
                Item3 = model.Item3,
                Item4 = model.Item4,
                JobTitle = model.JobTitle,
                Mission = model.Mission,
                NameSurname = model.NameSurname,
                ProfilePicture = model.ProfilePicture,
                StartYear = model.StartYear,
                Vision = model.Vision

            });

            return RedirectToAction("Index");
        }

        public IActionResult DeleteAbout(int id)
        {
            _aboutService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var model = _aboutService.TGetById(id);

            return View(new UpdateAboutDto
            {
                AboutId = model.AboutId,
                Description1 = model.Description1,
                Description2 = model.Description2,
                ImageUrl1 = model.ImageUrl1,
                ImageUrl2 = model.ImageUrl2,
                Item1 = model.Item1,
                Item2 = model.Item2,
                Item3 = model.Item3,
                Item4 = model.Item4,
                JobTitle = model.JobTitle,
                Mission = model.Mission,
                NameSurname = model.NameSurname,
                ProfilePicture = model.ProfilePicture,
                StartYear = model.StartYear,
                Vision = model.Vision
            });
        }

        [HttpPost]
        public IActionResult UpdateAbout(UpdateAboutDto model)
        {
            _aboutService.TUpdate(new About
            {
                AboutId = model.AboutId,
                Description1 = model.Description1,
                Description2 = model.Description2,
                ImageUrl1 = model.ImageUrl1,
                ImageUrl2 = model.ImageUrl2,
                Item1 = model.Item1,
                Item2 = model.Item2,
                Item3 = model.Item3,
                Item4 = model.Item4,
                JobTitle = model.JobTitle,
                Mission = model.Mission,
                NameSurname = model.NameSurname,
                ProfilePicture = model.ProfilePicture,
                StartYear = model.StartYear,
                Vision = model.Vision
            });
            return RedirectToAction("Index");
        }
    }
}
