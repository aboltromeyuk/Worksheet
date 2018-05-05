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
        [Required]
        [DisplayName("Имя")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Фамилия")]
        public string Surname { get; set; }

        [Required]
        [DisplayName("Отчество")]
        public string Patronymic { get; set; }

        [Required]
        [DisplayName("Сколько вам лет?")]
        public string Age { get; set; }

        [Required]
        [DisplayName("Адрес электронной почты")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Укажите ваш номер телефона для связи")]
        public string Phone { get; set; }
    }
}
