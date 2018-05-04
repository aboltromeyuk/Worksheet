using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.ViewModels
{
    public class AnswerViewModel
    {
        [Required]
        [DisplayName("Вы часто играете в футбол?")]
        public string OftenPlay { get; set; }

        [Required]
        [DisplayName("В вашей семье есть дети от 4 до 17 лет?")]
        public string HasChildren { get; set; }

        [Required]
        [DisplayName("Хотели бы привести своего ребёнка в футбольную школу? ")]
        public string FootballSchool { get; set; }

        [Required]
        [DisplayName("За команду какой страны будете болеть на предстоящем чемпионате?")]
        public string CountryIll { get; set; }

        [Required]
        [DisplayName("Команда какой страны станет чемпионом в 2018 году?")]
        public string CountryСhampion { get; set; }

        [Required]
        [DisplayName("Против команды какой страны будет играть чемпион в финале?")]
        public string CountryPreChampion { get; set; }

        [Required]
        [DisplayName("С каким счетом завершится финал?")]
        public string ScoreFinal { get; set; }

        [Required]
        [DisplayName("Команда какой страны победит в матче за 3 место?")]
        public string CountryThird { get; set; }

        [Required]
        [DisplayName("Какая страна дойдет до полуфинала, но займет 4 место?")]
        public string CountryFourth { get; set; }

        [Required]
        [DisplayName("С каким счётом закончится матч в борьбе за третье место?")]
        public string ScoreThird { get; set; }

        [Required]
        [DisplayName("Какие 8 стран точно сыграют в 1/4 финала? Перечислите через запятую.")]
        public string EightСountries { get; set; }
    }
}
