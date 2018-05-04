using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Worksheet.Data
{
    public class ThirdPlace
    {
        [Key]
        [ForeignKey("Standing")]
        public int Id { get; set; }

        public string FirstCommand { get; set; }
        public int ScoreFirstCommand { get; set; }

        public string SecondCommand { get; set; }
        public int ScoreSecondCommand { get; set; }

        public Standing Standing { get; set; }
    }
}
