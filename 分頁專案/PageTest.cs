using NUnit.Framework;
using Page;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;

namespace Tests
{
    public class SalaryData
    {
        public string Name { get; set; }
        public int Salary { get; set; }
    }

        public class Tests
         {
            [Test]
            public void 取得第一頁的第一筆資料_期望產出第一筆資料()
            {
                var salaryData = new List<SalaryData>()
                {
                   new SalaryData(){Name="Summer",Salary=1_000_000},
                   new SalaryData(){Name="CC",Salary=2_000_000 },
                   new SalaryData(){Name="Jame",Salary=3_000_000 },
                   new SalaryData(){Name="Frank",Salary=4_000_000 },
                   new SalaryData(){Name="Cassel",Salary=10 },
                   new SalaryData(){Name="Tom",Salary=5_000_000 }
                };
            var expected = new List<SalaryData>()
                { new SalaryData() { Name = "Summer", Salary = 1_000_000 }
                };
            var resoult = Pageing.ToPageList(salaryData.AsQueryable(), 1, 1);
            resoult.Should().BeEquivalentTo(expected);
            }

        [Test]
        public void 取得第二頁中的第二筆_期望取得第三筆及第四筆()
        {
            var salaryData = new List<SalaryData>()
                {
                   new SalaryData(){Name="Summer",Salary=1_000_000},
                   new SalaryData(){Name="CC",Salary=2_000_000 },
                   new SalaryData(){Name="Jame",Salary=3_000_000 },
                   new SalaryData(){Name="Frank",Salary=4_000_000 },
                   new SalaryData(){Name="Cassel",Salary=10 },
                   new SalaryData(){Name="Tom",Salary=5_000_000 }
                };
            var expected = new List<SalaryData>()
                { new SalaryData(){Name="Jame",Salary=3_000_000 },
                  new SalaryData(){Name="Frank",Salary=4_000_000 }
                };
            var resoult = Pageing.ToPageList(salaryData.AsQueryable(), 2, 2);

            resoult.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void 所在頁數為0_期望產出前兩筆()
        {
            var salaryData = new List<SalaryData>()
                {
                   new SalaryData(){Name="Summer",Salary=1_000_000},
                   new SalaryData(){Name="CC",Salary=2_000_000 },
                   new SalaryData(){Name="Jame",Salary=3_000_000 },
                   new SalaryData(){Name="Frank",Salary=4_000_000 },
                   new SalaryData(){Name="Cassel",Salary=10 },
                   new SalaryData(){Name="Tom",Salary=5_000_000 }
                };
            var expected = new List<SalaryData>()
                {
                 new SalaryData(){Name="Summer",Salary=1_000_000},
                   new SalaryData(){Name="CC",Salary=2_000_000 }
                };

            var resoult = Pageing.ToPageList(salaryData.AsQueryable(), 0, 2);
                resoult.Should().BeEquivalentTo(expected);
           
        }
        [Test]
        public void 一頁幾筆為0_期望無產出資料()
        {
            var salaryData = new List<SalaryData>()
                {
                   new SalaryData(){Name="Summer",Salary=1_000_000},
                   new SalaryData(){Name="CC",Salary=2_000_000 },
                   new SalaryData(){Name="Jame",Salary=3_000_000 },
                   new SalaryData(){Name="Frank",Salary=4_000_000 },
                   new SalaryData(){Name="Cassel",Salary=10 },
                   new SalaryData(){Name="Tom",Salary=5_000_000 }
                };
            var expected = new List<SalaryData>()
                {
              
                };

            var resoult = Pageing.ToPageList(salaryData.AsQueryable(), 1, 0);
            resoult.Should().BeEquivalentTo(expected);

        }

        [Test]
        public void 來源資料為空_期望無期出資料()
        {
            var salaryData = new List<SalaryData>()
            {
            };
            var expected = new List<SalaryData>()
            {
            };

            var resoult = Pageing.ToPageList(salaryData.AsQueryable(), 1, 1);
            //resoult.Should().BeEquivalentTo(expected);
            Assert.AreEqual(0, resoult.Count());
        }

        [Test]
        public void 六筆資料取第一頁的前七筆_期望產出前六筆()
        {
            var salaryData = new List<SalaryData>()
                {
                   new SalaryData(){Name="Summer",Salary=1_000_000},
                   new SalaryData(){Name="CC",Salary=2_000_000 },
                   new SalaryData(){Name="Jame",Salary=3_000_000 },
                   new SalaryData(){Name="Frank",Salary=4_000_000 },
                   new SalaryData(){Name="Cassel",Salary=10 },
                   new SalaryData(){Name="Tom",Salary=5_000_000 }
                };
            var expected = new List<SalaryData>()
            {
                 new SalaryData(){Name="Summer",Salary=1_000_000},
                   new SalaryData(){Name="CC",Salary=2_000_000 },
                   new SalaryData(){Name="Jame",Salary=3_000_000 },
                   new SalaryData(){Name="Frank",Salary=4_000_000 },
                   new SalaryData(){Name="Cassel",Salary=10 },
                   new SalaryData(){Name="Tom",Salary=5_000_000 }

            };

            var resoult = Pageing.ToPageList(salaryData.AsQueryable(), 1, 7);
            resoult.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void 六筆資料取第二頁的前二筆_期望取出第三筆與第四筆()
        {
            var salaryData = new List<SalaryData>()
                {
                   new SalaryData(){Name="Summer",Salary=1_000_000},
                   new SalaryData(){Name="CC",Salary=2_000_000 },
                   new SalaryData(){Name="Jame",Salary=3_000_000 },
                   new SalaryData(){Name="Frank",Salary=4_000_000 },
                   new SalaryData(){Name="Cassel",Salary=10 },
                   new SalaryData(){Name="Tom",Salary=5_000_000 }
                };
            var expected = new List<SalaryData>()
            {
                   new SalaryData(){Name="Jame",Salary=3_000_000 },
                   new SalaryData(){Name="Frank",Salary=4_000_000 }
            };

            var resoult = Pageing.ToPageList(salaryData.AsQueryable(), 2, 2);
            resoult.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void 三筆數字字串取第三頁的第一筆_取出第三筆資料()
        {
            var salaryData = new List<int>() {1,3,4 };
            var expected = new List<int>() {4 };
            var resoult = Pageing.ToPageList(salaryData.AsQueryable(), 3, 1);
            resoult.Should().BeEquivalentTo(expected);
        }
        [Test]
        public void 一頁幾筆為負數_期望無產出資料()
        {
            var salaryData = new List<SalaryData>()
                {
                   new SalaryData(){Name="Summer",Salary=1_000_000},
                   new SalaryData(){Name="CC",Salary=2_000_000 },
                   new SalaryData(){Name="Jame",Salary=3_000_000 },
                   new SalaryData(){Name="Frank",Salary=4_000_000 },
                   new SalaryData(){Name="Cassel",Salary=10 },
                   new SalaryData(){Name="Tom",Salary=5_000_000 }
                };
            var expected = new List<SalaryData>()
            {

            };

            var resoult = Pageing.ToPageList(salaryData.AsQueryable(), 1, -1);
            resoult.Should().BeEquivalentTo(expected);

        }
        [Test]
        public void 所在頁數為負數_期望產生前兩筆()
        {
            var salaryData = new List<SalaryData>()
                {
                   new SalaryData(){Name="Summer",Salary=1_000_000},
                   new SalaryData(){Name="CC",Salary=2_000_000 },
                   new SalaryData(){Name="Jame",Salary=3_000_000 },
                   new SalaryData(){Name="Frank",Salary=4_000_000 },
                   new SalaryData(){Name="Cassel",Salary=10 },
                   new SalaryData(){Name="Tom",Salary=5_000_000 }
                };
            var expected = new List<SalaryData>()
                {
                   new SalaryData(){Name="Summer",Salary=1_000_000},
                   new SalaryData(){Name="CC",Salary=2_000_000 }
                };

            var resoult = Pageing.ToPageList(salaryData.AsQueryable(), -1, 2);
            resoult.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void 六筆資料取第十頁的第一筆_期望無產出資料()
        {
            var salaryData = new List<SalaryData>()
                {
                   new SalaryData(){Name="Summer",Salary=1_000_000},
                   new SalaryData(){Name="CC",Salary=2_000_000 },
                   new SalaryData(){Name="Jame",Salary=3_000_000 },
                   new SalaryData(){Name="Frank",Salary=4_000_000 },
                   new SalaryData(){Name="Cassel",Salary=10 },
                   new SalaryData(){Name="Tom",Salary=5_000_000 }
                };
            var expected = new List<SalaryData>()
            {

            };

            var resoult = Pageing.ToPageList(salaryData.AsQueryable(), 10, 1);
            resoult.Should().BeEquivalentTo(expected);
        }
    }
}