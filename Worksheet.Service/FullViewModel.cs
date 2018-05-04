using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.ViewModels
{
    public class FullViewModel
    {
        public UserViewModel User { get; set; }

        public AnswerViewModel Answer { get; set; }

        public StandingViewModel Standing { get; set; }
    }
}
