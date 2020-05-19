using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace X_sSweetShop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
