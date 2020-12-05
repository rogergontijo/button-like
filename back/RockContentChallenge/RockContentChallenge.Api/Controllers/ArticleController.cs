using Microsoft.AspNetCore.Mvc;
using RockContentChallenge.Aplication.Dtos;
using RockContentChallenge.Aplication.Interfaces;
using System;

namespace RockContentChallenge.Api.Controllers
{
    [Route("api/articles")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleAppService _articleAppService;
        public ArticleController(IArticleAppService articleAppService)
        {
            _articleAppService = articleAppService; 
        }

        [HttpPut]        
        public IActionResult UpdateLike(ArticleDto articleDto)
        {
            try
            {
                return new OkObjectResult(_articleAppService.UpdateAsync(articleDto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
