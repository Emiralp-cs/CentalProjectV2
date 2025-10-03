using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.EntityLayer.Entities
{
    public class CarCategory
    {
        public int CarCategoriesId { get; set; }
        public string CategoryName { get; set; }
        public List<Car> Cars { get; set; }
    }
}
