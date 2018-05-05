using System.Collections.Generic;
using Worksheet.Data;
using Worksheet.ViewModels;

namespace Worksheet.Service
{
    public class WorksheetService
    {
        public void SaveData(FullViewModel model)
        {
            var user = new User();

            user.Name = model.User.Name;
            user.Patronymic = model.User.Patronymic;
            user.Surname = model.User.Surname;
            user.Email = model.User.Email;
            user.Age = model.User.Age;
            user.Phone = model.User.Phone;

            using (var context = new WorksheetContext())
            {
                context.Users.Add(user);
                context.SaveChanges();

                var answer = new Answer
                {
                    Id = user.Id,
                    CountryFourth = model.Answer.CountryFourth,
                    CountryIll = model.Answer.CountryIll,
                    CountryPreChampion = model.Answer.CountryPreChampion,
                    CountryThird = model.Answer.CountryThird,
                    CountryСhampion = model.Answer.CountryСhampion,
                    EightСountries = model.Answer.EightСountries,
                    FootballSchool = model.Answer.FootballSchool,
                    HasChildren = model.Answer.HasChildren,
                    OftenPlay = model.Answer.OftenPlay,
                    ScoreFinal = model.Answer.ScoreFinal,
                    ScoreThird = model.Answer.ScoreThird                                
                };

                context.Answers.Add(answer);
                context.SaveChanges();

                var standing = new Standing
                {
                    Id = user.Id                    
                };

                context.Standings.Add(standing);
                context.SaveChanges();

                var oneEighths = new List<OneEighth>();

                foreach(var item in model.Standing.OneEigths)
                {
                    oneEighths.Add(new OneEighth
                    {
                         FirstCommand = item.FirstCommand,
                         ScoreFirstCommand = item.ScoreFirstCommand,
                         SecondCommand = item.SecondCommand,
                         ScoreSecondCommand = item.ScoreSecondCommand,
                         Standing = standing
                    });
                }

                context.OneEighths.AddRange(oneEighths);
                context.SaveChanges();

                var oneQuarters = new List<OneQuarter>();

                foreach (var item in model.Standing.OneQuarters)
                {
                    oneQuarters.Add(new OneQuarter
                    {
                        FirstCommand = item.FirstCommand,
                        ScoreFirstCommand = item.ScoreFirstCommand,
                        SecondCommand = item.SecondCommand,
                        ScoreSecondCommand = item.ScoreSecondCommand,
                        Standing = standing
                    });
                }

                context.OneQuarters.AddRange(oneQuarters);
                context.SaveChanges();

                var semifinals = new List<Semifinal>();

                foreach (var item in model.Standing.Semifinals)
                {
                    semifinals.Add(new Semifinal
                    {
                        FirstCommand = item.FirstCommand,
                        ScoreFirstCommand = item.ScoreFirstCommand,
                        SecondCommand = item.SecondCommand,
                        ScoreSecondCommand = item.ScoreSecondCommand,
                        Standing = standing
                    });
                }

                context.Semifinals.AddRange(semifinals);
                context.SaveChanges();

                var final = new Final
                {
                    Id = standing.Id,
                    FirstCommand = model.Standing.Final.FirstCommand,
                    ScoreFirstCommand = model.Standing.Final.ScoreFirstCommand,
                    SecondCommand = model.Standing.Final.SecondCommand,
                    ScoreSecondCommand = model.Standing.Final.ScoreSecondCommand
                };

                context.Finals.Add(final);
                context.SaveChanges();                

                var thirdPlace = new ThirdPlace
                {
                    Id = standing.Id,
                    FirstCommand = model.Standing.ThirdPlace.FirstCommand,
                    ScoreFirstCommand = model.Standing.ThirdPlace.ScoreFirstCommand,
                    SecondCommand = model.Standing.ThirdPlace.SecondCommand,
                    ScoreSecondCommand = model.Standing.ThirdPlace.ScoreSecondCommand
                };

                context.ThirdPlaces.Add(thirdPlace);
                context.SaveChanges();
            }            
        }
    }
}
