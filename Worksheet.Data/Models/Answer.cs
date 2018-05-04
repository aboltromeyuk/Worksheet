using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Worksheet.Data
{
    public class Answer
    {
        [Key]
        [ForeignKey("User")]
        public int Id { get; set; }

        public string OftenPlay { get; set; }

        public string HasChildren { get; set; }

        public string FootballSchool { get; set; }

        public string CountryIll { get; set; }

        public string CountryСhampion { get; set; }

        public string CountryPreChampion { get; set; }

        public string ScoreFinal { get; set; }

        public string CountryThird { get; set; }

        public string CountryFourth { get; set; }

        public string ScoreThird { get; set; }

        public string EightСountries { get; set; }

        public User User { get; set; }
    }
}
