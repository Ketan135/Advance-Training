using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS.Containment
{
    public class Flat
    {
        int falatno;
        string wing;
        string buildingname;
        Member M1 = new Member();


        public Flat()
            {
            }

        public Flat(int falatno, string wing, string buildingname, Member m1)
        {
            this.Falatno = falatno;
            this.Wing = wing;
            this.Buildingname = buildingname;
            M11 = m1;
        }

        public int Falatno { get => falatno; set => falatno = value; }
        public string Wing { get => wing; set => wing = value; }
        public string Buildingname { get => buildingname; set => buildingname = value; }
       public Member M11 { get => M1; set => M1 = value; }
    }
    public class Member
    {
        string name;
        string gender;

        public Member()
        {

        }

        public Member(string name, string gender)
        {
            this.Name = name;
            this.Gender = gender;
        }

        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
    }
    class TestFlat
    {
        static void Main(string[] args)
        {
            Flat f1 = new Flat();
            f1.Buildingname = "Bramha";
            f1.Falatno = 501;
            f1.Wing = "B2";
            f1.M11.Name = "Ketan";
            f1.M11.Gender = "Male";
            Console.WriteLine("Building Name is="+f1.Buildingname);
            Console.WriteLine("Flat No is="+f1.Falatno);
            Console.WriteLine("Wing is="+f1.Wing);
            Console.WriteLine("Member Name is="+f1.M11.Name);
            Console.WriteLine("Gender is="+f1.M11.Gender);


        }
    }
    
}
