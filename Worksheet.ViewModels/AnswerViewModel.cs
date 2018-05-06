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
        [Required(ErrorMessage = "Обязательное поле")]
        [DisplayName("Вы часто играете в футбол?")]
        public string OftenPlay { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DisplayName("В вашей семье есть дети от 4 до 17 лет?")]
        public string HasChildren { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DisplayName("Хотели бы привести своего ребёнка в футбольную школу? ")]
        public string FootballSchool { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DisplayName("За команду какой страны будете болеть на предстоящем чемпионате?")]
        public string CountryIll { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DisplayName("Команда какой страны станет чемпионом в 2018 году?")]
        public string CountryСhampion { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DisplayName("Против команды какой страны будет играть чемпион в финале?")]
        public string CountryPreChampion { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DisplayName("С каким счетом завершится финал?")]
        public string ScoreFinal { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DisplayName("Команда какой страны победит в матче за 3 место?")]
        public string CountryThird { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DisplayName("Какая страна дойдет до полуфинала, но займет 4 место?")]
        public string CountryFourth { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DisplayName("С каким счётом закончится матч в борьбе за третье место?")]
        public string ScoreThird { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DisplayName("Какие 8 стран точно сыграют в 1/4 финала? Перечислите через запятую.")]
        public string EightСountries { get; set; }
    }
}
