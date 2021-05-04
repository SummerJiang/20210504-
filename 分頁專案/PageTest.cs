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
            public void ���o�Ĥ@�����Ĥ@�����_���沣�X�Ĥ@�����()
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
        public void ���o�ĤG�������ĤG��_������o�ĤT���βĥ|��()
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
        public void �Ҧb���Ƭ�0_���沣�X�e�ⵧ()
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
        public void �@���X����0_����L���X���()
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
        public void �ӷ���Ƭ���_����L���X���()
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
        public void ������ƨ��Ĥ@�����e�C��_���沣�X�e����()
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
        public void ������ƨ��ĤG�����e�G��_������X�ĤT���P�ĥ|��()
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
        public void �T���Ʀr�r����ĤT�����Ĥ@��_���X�ĤT�����()
        {
            var salaryData = new List<int>() {1,3,4 };
            var expected = new List<int>() {4 };
            var resoult = Pageing.ToPageList(salaryData.AsQueryable(), 3, 1);
            resoult.Should().BeEquivalentTo(expected);
        }
        [Test]
        public void �@���X�����t��_����L���X���()
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
        public void �Ҧb���Ƭ��t��_���沣�ͫe�ⵧ()
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
        public void ������ƨ��ĤQ�����Ĥ@��_����L���X���()
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