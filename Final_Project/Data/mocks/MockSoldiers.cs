using System;
using System.Collections.Generic;
using System.Linq;
using Final_Project.Data.Intefaces;
using Final_Project.Data.Models;
/*
namespace Final_Project.Data.mocks
{
    public class MockSoldiers : IAllSoldiers
    {
        private readonly ISoldiersCategory _categorySoldiers = new MockCategory();

        public IEnumerable<Soldier> Soldiers {
            get{
                return new List<Soldier> {
                    new Soldier{
                        Name="Azamat",
                        Surname= "Yerbosyn",
                        ShortDesc="ready",
                        LongDesc= "bvdsnkdajiwehufb",
                        BirthDay=30,
                        Img="/img/as1.jpg",//OSYLAY ZHAZ NA VSE
                        Category = _categorySoldiers.AllCategoryies.First()
                    },
                    new Soldier{
                        Name="Asyl",
                        Surname= "Balatursyn",
                        ShortDesc="not ready",
                        LongDesc= "just for task",
                        BirthDay=9,
                        Img="https://vk.com/photo198672416_457241455",
                        Category = _categorySoldiers.AllCategoryies.Last()
                    }
                };
            }

                }

        public Soldier getObjectSoldier(int soldierId)
        {
            throw new NotImplementedException();
        }
    }
}
*/