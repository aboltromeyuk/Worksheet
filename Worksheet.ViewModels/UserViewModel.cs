using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet.ViewModels
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Обязательное поле")]
        [DisplayName("Имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DisplayName("Фамилия")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DisplayName("Отчество")]
        public string Patronymic { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DisplayName("Сколько вам лет?")]
        public string Age { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [EmailAddress(ErrorMessage = "Некорректный адрес")]
        [DisplayName("Адрес электронной почты")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Phone(ErrorMessage = "Некорректный номер телефона")]
        [DisplayName("Укажите ваш номер телефона для связи")]
        public string Phone { get; set; }
    }
}
