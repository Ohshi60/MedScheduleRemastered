using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedScheduleRemastered
{
    public class DayShift : Shift
    {
        public DayShift(DateTime d) : base(d)
        {
            _nursesPerShift = 1;
        }
        public override string ToString()
        {
            return "DayShift";
        }
    }
}
