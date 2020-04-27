using System;
namespace Final_Project.Data.Models
{
    public class Soldier
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public string Surname { set; get; }

        public string ShortDesc { set; get; }

        public string LongDesc { set; get; }

        public int BirthDay { set; get; }

        public string Img { set; get; }

        public int Categoryid { set; get; }

        public virtual Category Category { set; get; }
    }
}
