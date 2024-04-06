using EncyclopediaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EncyclopediaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {
       

        private readonly ILogger<ArticleController> _logger;

        public ArticleController(ILogger<ArticleController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetArticles")]
        public IEnumerable<Article> Get() => Article.GetArticles();
        
   
    }
}