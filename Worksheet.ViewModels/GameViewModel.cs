using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.ViewModels
{
    public class GameViewModel
    {
        [Required]
        public string FirstCommand { get; set; }
        [Required]
        public int ScoreFirstCommand { get; set; }

        [Required]
        public string SecondCommand { get; set; }
        [Required]
        public int ScoreSecondCommand { get; set; }
    }
}
