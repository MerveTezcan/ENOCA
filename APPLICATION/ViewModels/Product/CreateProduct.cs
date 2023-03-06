using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENOCA.APPLICATION.ViewModels
{
    public class CreateProduct
    {
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public string ProductName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
