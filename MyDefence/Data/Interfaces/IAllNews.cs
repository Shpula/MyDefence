using MyDefence.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyDefence.Data.Interfaces
{
    public interface IAllNews
    {
        IEnumerable<News> News { get;}
        IEnumerable<News> GetFavNews { get; set; }
        News getObjNews(int newsid);
    }
}
