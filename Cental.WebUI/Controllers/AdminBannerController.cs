using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DataTransferObjectLayer.Dtos.BannerDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    public class AdminBannerController : Controller
    {
        private readonly IBannerService _bannerService;
        private readonly IMapper _mapper;

        public AdminBannerController(IBannerService bannerService, IMapper mapper)
        {
            _bannerService = bannerService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_mapper.Map<IList<ToListBannerDto>>(_bannerService.TGetAll()));
        }

        [HttpGet]
        public IActionResult CreateBanner()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBanner(CreateBannerDto CreateBanner)
        {
            _bannerService.TCreate(_mapper.Map<Banner>(CreateBanner));

            return RedirectToAction("Index");
        }
    }
}
