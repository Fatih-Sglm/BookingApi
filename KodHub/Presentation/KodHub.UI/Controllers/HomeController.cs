using AutoMapper;
using KodHub.Application.Interfaces.Repositories;
using KodHub.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KodHub.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public HomeController(ILogger<HomeController> logger, ICategoryRepository categoryRepository, IMapper mapper)
        {
            _logger = logger;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        //public async Task<IActionResult> CreateAsync(CategoryDto dto)
        //{
        //    await _categoryRepository.AddAsync(_mapper.Map<Category>(dto));
        //    await _categoryRepository.SaveAsync();
        //    return RedirectToAction("Index", "Home");
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}