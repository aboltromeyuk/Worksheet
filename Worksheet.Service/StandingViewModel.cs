using System.Collections.Generic;
using System.ComponentModel;

namespace Worksheet.ViewModels
{
    public class StandingViewModel
    {
        [DisplayName("1/8 финала")]
        public List<OneEigthViewModel> OneEigths { get; set; }

        [DisplayName("1/4 финала")]
        public List<OneQuarterViewModel> OneQuarters { get; set; }

        [DisplayName("Полуфинал")]
        public List<SemifinalViewModel> Semifinals { get; set; }

        [DisplayName("Игра за 3-е место")]
        public ThirdPlaceViewModel ThirdPlace { get; set; }

        [DisplayName("Финал")]
        public FinalViewModel Final { get; set; }
    }
}
