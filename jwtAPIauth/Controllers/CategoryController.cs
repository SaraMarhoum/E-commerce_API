using jwtAPIauth.Models;
using jwtAPIauth.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwtAPIauth.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _catService;
        public CategoryController(ICategoryService catService)
        {
            _catService = catService;
        }

        [HttpGet("List Cat")]
        public async Task<IEnumerable<Category>> GetCategory()
        {
            return await _catService.GetAll();
        }

        [HttpGet("Category by Id")]
        public async Task<ActionResult<Category>> GetCat(int id)
        {
            return await _catService.GetById(id);
        }

        [HttpPost("Add Category")]
        public async Task<ActionResult<Category>> PostCat([FromBody] Category cat)
        {
            var newcat = await _catService.Create(cat);
            return CreatedAtAction(nameof(GetCategory), new { id = newcat.CatID }, newcat);
        }

        [HttpPut("Update Category")]
        public async Task<ActionResult> PutCat(int id, [FromBody] Category cat)
        {
            if (id != cat.CatID)
            {
                return BadRequest();
            }

            await _catService.Update(cat);

            return NoContent();
        }

        [HttpDelete("Delete Category")]
        public async Task<ActionResult> Delete(int id)
        {
            var catToDelete = await _catService.GetById(id);
            if (catToDelete == null)
                return NotFound();

            await _catService.Delete(catToDelete.CatID);
            return NoContent();
        }

    }
}
