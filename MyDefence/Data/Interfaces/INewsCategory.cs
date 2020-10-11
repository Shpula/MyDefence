using Microsoft.AspNetCore.SignalR;
using MyDefence.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDefence.Data.Interfaces
{
    public interface INewsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
