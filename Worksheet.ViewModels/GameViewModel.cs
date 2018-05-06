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
        [Required(ErrorMessage = "Обязательное поле")]
        public string FirstCommand { get; set; }
        [Required(ErrorMessage = "Обязательное поле")]
        public int ScoreFirstCommand { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public string SecondCommand { get; set; }
        [Required(ErrorMessage = "Обязательное поле")]
        public int ScoreSecondCommand { get; set; }
    }
}
