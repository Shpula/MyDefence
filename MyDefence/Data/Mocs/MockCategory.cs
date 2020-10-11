using MyDefence.Data.Interfaces;
using MyDefence.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDefence.Data.Mocs
{
    public class MockCategory : INewsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Новости", desc = "Самые обычные новости"},
                    new Category { categoryName = "Потеха", desc = "Смешные новости"}

                };
            }
        }
            
    }
}
