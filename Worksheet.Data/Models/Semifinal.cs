namespace Worksheet.Data
{
    public class Semifinal
    {
        public int Id { get; set; }

        public string FirstCommand { get; set; }
        public int ScoreFirstCommand { get; set; }

        public string SecondCommand { get; set; }
        public int ScoreSecondCommand { get; set; }

        public int? StandingId { get; set; }
        public Standing Standing { get; set; }
    }
}
