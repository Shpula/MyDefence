using Microsoft.AspNetCore.Mvc;
using MyDefence.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDefence.Controllers
{
    public class NewsController : Controller
    {
        private readonly IAllNews _allNews;
        private readonly INewsCategory _AllNewsCategorys;

        public NewsController(IAllNews iAllNews, INewsCategory iNewsCategory)
        {
            _allNews = iAllNews;
            _AllNewsCategorys = iNewsCategory;

        }

        public ViewResult NewsList()
        {
            var news = _allNews.News;
            return View(news);
        }
    }
}
