using BoxShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoxShop.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Gloves> Gloves{ get; set; }
    }
}
