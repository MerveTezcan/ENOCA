using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENOCA.APPLICATION.ViewModels
{
    public class UpdateCompany
    {
        public int Id { get; set; }
        public bool OrderStatus { get; set; }
        public DateTime OrderStartTime { get; set; }
        public DateTime OrderFinishTime { get; set; }
    }
}
