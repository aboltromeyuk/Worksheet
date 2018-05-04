using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Worksheet.Data
{
    public class Standing
    {
        [Key]
        [ForeignKey("User")]
        public int Id { get; set; }

        public User User { get; set; }
        public Final Final { get; set; }
        public ThirdPlace ThirdPlace { get; set; }
        public ICollection<OneEighth> OneEighths { get; set; }
        public ICollection<OneQuarter> OneQuarters { get; set; }
        public ICollection<Semifinal> Semifinals { get; set; }                        

        public Standing()
        {
            OneEighths = new List<OneEighth>();
            OneQuarters = new List<OneQuarter>();
            Semifinals = new List<Semifinal>();
        }
    }
}
