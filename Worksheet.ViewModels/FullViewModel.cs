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
        [DisplayName("Вы ознакомились с правилами \"Кубка прогнозов\"? Отвечая да, вы принимаете условия проекта и даёте своё согласие на обработку ваших персональных данных.")]
        public bool Agreement { get; set; }        
    }
}
