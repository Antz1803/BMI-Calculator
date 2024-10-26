using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.MVVM.Model
{
    public class ViewModel
    {
        public BMI BMI { get; set; } = new BMI { Height = 170, Weight = 70 };
    }
}
