using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WaterCoolerUserPreferences.Models
{
    public class UserPreferences
    {
        public List<Topic> topics { get; set; }
        public List<Frequency>frequency { get; set; }

        public List<WorkingHoursFrom> workingHoursFrom { get; set; }

        public List<WorkingHoursTo> workingHoursTo { get; set; }

    }
}
