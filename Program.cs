using System.Linq;
using System;
using System.Collections;

namespace b2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>{
                new Member{
                    FirstName = "Nguyen Van",
                    LastName = "A",
                    Gender = "Male",
                    DateOfBirth = new DateTime(2001, 11, 25),
                    PhoneNumber = "0782151236",
                    BirthPlace = "Hai Phong",
                    IsGraduated = false
                },
                new Member{
                    FirstName = "Nguyen Thi",
                    LastName = "B",
                    Gender = "Female",
                    DateOfBirth = new DateTime(2000, 1, 20),
                    PhoneNumber = "0124124241",
                    BirthPlace = "Ha Noi",
                    IsGraduated = false
                },
                new Member{
                    FirstName = "Nguyen Thi",
                    LastName = "C",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1999, 8, 2),
                    PhoneNumber = "0487424412",
                    BirthPlace = "Thai Binh",
                    IsGraduated = true
                },
                new Member{
                    FirstName = "Nguyen Van",
                    LastName = "D",
                    Gender = "Male",
                    DateOfBirth = new DateTime(2001, 4, 6),
                    PhoneNumber = "0345751244",
                    BirthPlace = "Ha Noi",
                    IsGraduated = false
                },
            };

            Console.WriteLine("Cau 1");

            var maleMembers = members.Where(x => x.Gender == "Male").ToList();

            maleMembers.ForEach(x => Console.WriteLine(x.Info));

            Console.WriteLine("-------------------");
            Console.WriteLine("Cau 2");

            var maxAge = members.Max(x => x.Age);

            var oldestMember = members.Find(x => x.Age == maxAge);
            // var oldestMember1 = members.First(x => x.Age == maxAge);
            // var oldestMember2 = members.FirstOrDefault(x => x.Age == maxAge);
            // var oldestMember3 = members.Where(x => x.Age == maxAge).Take(1);

            Console.WriteLine(oldestMember.Info);

            Console.WriteLine("-------------------");
            Console.WriteLine("Cau 3");

            List<string> fullNameList = members.Select(m => m.FirstName + " " + m.LastName).ToList();

            fullNameList.ForEach(m => Console.WriteLine(m));

            Console.WriteLine("-------------------");
            Console.WriteLine("Cau 4");

            List<Member> age2000 = members.Where(m => m.DateOfBirth.Year == 2000).ToList();

            List<Member> ageGreater2000 = members.Where(m => m.DateOfBirth.Year > 2000).ToList();

            List<Member> ageLess2000 = members.Where(m => m.DateOfBirth.Year < 2000).ToList();

            Console.WriteLine("Members have year born is 2000");

            age2000.ForEach(m => Console.WriteLine(m.Info));

            Console.WriteLine("-------------------");
            Console.WriteLine("Members have year born is greater than 2000");

            ageGreater2000.ForEach(m => Console.WriteLine(m.Info));
            
            Console.WriteLine("-------------------");
            Console.WriteLine("Members have year born is less than 2000");

            ageLess2000.ForEach(m => Console.WriteLine(m.Info));

            Console.WriteLine("-------------------");
            Console.WriteLine("Cau 5");

            var firstPersonBornInHanoi = members.Where(m => m.BirthPlace.ToLower().Equals("ha noi") && !string.IsNullOrEmpty(m.BirthPlace)).FirstOrDefault();

            if (firstPersonBornInHanoi != null)
                Console.WriteLine(firstPersonBornInHanoi.Info);
        }
    }
}