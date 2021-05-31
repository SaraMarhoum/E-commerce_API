
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jwtAPIauth.Dto;
using jwtAPIauth.Dto.Responses;
using jwtAPIauth.Dto.Responses.category;
using jwtAPIauth.IntelviaData;
using jwtAPIauth.Models;

using jwtAPIauth.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace jwtAPIauth.Controllers
{
    [Route("/api")]

    public class CategoryController : Controller
    {
        private readonly ICategoryData _categoriesService;

        public CategoryController(ICategoryData categoriesService)
        {
            _categoriesService = categoriesService;
        }

        [HttpGet]
        [Route("Category")]
        public async Task<IActionResult> GetCategories([FromQuery] int page = 1, [FromQuery] int pageSize = 5)
        {
            var categories = await _categoriesService.FetchPage(page, pageSize);
            var basePath = Request.Path;

            return StatusCodeAndDtoWrapper.BuildSuccess(CategoryListDtoResponse.Build(categories.Item2, basePath,
                currentPage: page, pageSize: pageSize, totalItemCount: categories.Item1));
        }

        [HttpPost]
        [Route("Category")]
        public async Task<IActionResult> CreateCategory(string name, string description, List<IFormFile> images)
        {

            // If the user sends `images` POST param then the list<IFormFile> will be populated, if the user sends `images[]` instead, then it will be empty
            // this is why I populate that list with this little trick
            if (images?.Count == 0)
                images = Request.Form.Files.GetFiles("images[]").ToList();

            Category category = await _categoriesService.Create(name, description, images);
            return StatusCodeAndDtoWrapper.BuildSuccess(CategoryDto.Build(category), "Category created successfully");
        }


        [HttpGet]
        [Route("Category by Id")]
        public async Task<ActionResult<Category>> GetCat(int id)
        {
            return await _categoriesService.GetById(id);
        }

        [HttpPut("Update Category")]
        public async Task<ActionResult> PutCat(int id, [FromBody] Category cat)
        {
            if (id != cat.CatID)
            {
                return BadRequest();
            }

            await _categoriesService.Update(cat);

            return NoContent();
        }

        [HttpDelete("Delete Category")]
        public async Task<ActionResult> Delete(int id)
        {
            var catToDelete = await _categoriesService.GetById(id);
            if (catToDelete == null)
                return NotFound();

            await _categoriesService.Delete(catToDelete.CatID);
            return NoContent();
        }
    }
}
