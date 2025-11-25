using Administration.Services.Implements;
using Administration.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<ArticleController> _logger;
        private readonly IMemoryCache _cache;
        private readonly IArticleService _iArticleService ;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ArticleController(ILogger<ArticleController> logger,
                IMemoryCache cache, IConfiguration configuration, IHttpContextAccessor httpContextAccessor, IArticleService iArticleService)
        {
            _cache = cache;
            _logger = logger;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _iArticleService = iArticleService;
        }
        public IActionResult Search()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SearchArticle(string tranCode, string articleCode,string articleDescription,string articleSupplement)
        {
            try
            {
                var data = _iArticleService.SearchArticle(tranCode ?? "", articleCode ?? "", articleDescription ?? "", articleSupplement ?? "");

                var result = (from d in data.AsEnumerable()
                              select d.Table.Columns.Cast<DataColumn>()
                                  .ToDictionary(
                                      col => col.ColumnName,
                                      col => d[col.ColumnName]?.ToString()
                                  )).ToList();
                return Json(result);


            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

        }
    }
}
