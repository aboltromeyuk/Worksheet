using System.Collections.Generic;

namespace Worksheet.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Age { get; set; }      
        
        public Answer Answer { get; set; }
        public Standing Standing { get; set; }  
    }
}
