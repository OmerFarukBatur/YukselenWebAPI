using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using YukselenWebAPI.BL.Services;
using YukselenWebAPI.DAL.ViewModel;
using YukselenWebAPI.EntityLayer.Entities;
using YukselenWebAPI.ViewModel;

namespace YukselenWebAPI.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IQuestionService _questionService;

        public UserController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpPost(Name = "register")]
        public IActionResult Register(Deneme user)
        {
            return Ok(user);
        }
        [HttpGet(Name = "get-question")]
        public async Task<IActionResult> GetQuestion([FromBody] string formName)
        {
            List<Question> result = await _questionService.GetQuestionsAsync(formName);
            return Ok(result);
        }
    }
}
