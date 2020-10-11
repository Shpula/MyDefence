using Microsoft.AspNetCore.Authentication;
using MyDefence.Data.Interfaces;
using MyDefence.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyDefence.Data.Mocs
{
    public class MockNews : IAllNews    
    {
        private readonly INewsCategory _categoryNews = new MockCategory();
        public IEnumerable<News> News
        {
            get
            {
                return new List<News>
                {
                    new News{ShortDesk = "Утка украла варенье", LongDesk = "Утка урала варенье, вкусно покушала, и легла спать",
                        img = "http://i.mycdn.me/i?r=AzEPZsRbOZEKgBhR0XGMT1Rk5n5XDmQfQoVji9WlXqmDVKaKTM5SRkZCeTgDn6uOyic"
                        , isfavorite = true//, PostTime = new DateTime(2020, 00, 00)//разобраться как установить текущее время
                        , Category = _categoryNews.AllCategories.Last()}
                };
            }
        }
        public IEnumerable<News> GetFavNews { get; set; }

        public News getObjNews(int newsid)
        {
            throw new NotImplementedException();
        }
    }
}
