using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Worksheet.ViewModels
{
    public class FullViewModel
    {
        public UserViewModel User { get; set; }

        public AnswerViewModel Answer { get; set; }

        public StandingViewModel Standing { get; set; }

        [Required]
        [DisplayName("Вы ознакомились с правилами \"Кубка прогнозов\"? Отвечая да, вы принимаете условия проекта.")]
        public bool Agreement { get; set; }        
    }
}
