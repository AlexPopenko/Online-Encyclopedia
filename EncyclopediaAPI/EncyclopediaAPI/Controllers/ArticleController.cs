using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using 
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
            public IEnumerable<Models.Article> Get()
            {
                return 
                    Id = id;
                    Name = name;
                    Tag = tag;
                    Creator = creator;
                    CreationDate = Models.Article.SetCreationDate();
                    Content = content;
            })
                .ToArray();
            }
        }
    
}
