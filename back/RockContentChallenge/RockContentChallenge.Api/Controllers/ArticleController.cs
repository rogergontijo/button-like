using Microsoft.AspNetCore.Mvc;
using RockContentChallenge.Aplication.Dtos;
using RockContentChallenge.Aplication.Interfaces;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace RockContentChallenge.Api.Controllers
{
    [Route("articles")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleAppService _articleAppService;
        public ArticleController(IArticleAppService articleAppService)
        {
            _articleAppService = articleAppService; 
        }

        [HttpPut]        
        public async Task<IActionResult> UpdateAsync(ArticleDto articleDto)
        {
            try
            {
                await _articleAppService.UpdateAsync(articleDto);

                return new OkResult();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            try
            {
                var guid = new Guid(id);                

                return new OkObjectResult(await _articleAppService.GetByIdAsync(guid));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
