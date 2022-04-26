using BookingHotelAPI.Application.Repositories.CategoryRepositories;
using BookingHotelAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingHotel.API.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        readonly ICategoryReadRepository _categoryReadRepository;
        readonly ICategoryWriteRepository _categoryWriteRepository;

        public CategoryController(ICategoryReadRepository categoryReadRepository, ICategoryWriteRepository categoryWriteRepository)
        {
            _categoryReadRepository = categoryReadRepository;
            _categoryWriteRepository = categoryWriteRepository;
        }

        [HttpGet]
        public async Task GetAsync()
        {
            await _categoryWriteRepository.AddAsync(new() { Id = Guid.NewGuid(), CategoryName = "Blabla" });
            await _categoryWriteRepository.SaveAsync();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategory()
        {
            IQueryable<Category> categories = _categoryReadRepository.GetAll();
            return Ok(categories);
            
        }

        [HttpGet]
        public async Task Update()
        {
           Category category = await _categoryReadRepository.GetByIdAsync("42773386-7b76-42c9-8b83-eb8b6ccfe837");
            category.CategoryName = "naberAli";
            category.Status = true;
            await _categoryWriteRepository.SaveAsync();
        }   

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            Category category = await _categoryReadRepository.GetByIdAsync(id);
            return Ok(category);
        }



    }
}
