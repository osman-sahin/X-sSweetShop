using System.Collections.Generic;
using X_sSweetShop.Models;

namespace X_sSweetShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}