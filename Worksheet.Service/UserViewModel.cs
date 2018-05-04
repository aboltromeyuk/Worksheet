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
        [DisplayName("Имя")]
        public string Age { get; set; }
    }
}
