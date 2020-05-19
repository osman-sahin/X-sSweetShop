using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X_sSweetShop.Models;

namespace X_sSweetShop.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
