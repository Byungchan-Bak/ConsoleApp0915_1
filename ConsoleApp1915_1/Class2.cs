using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0915
{
    class Drama
    {
        public string title;

        private string maleActor;
        public string MaleActor
        {
            get { return maleActor; }
            set { maleActor = value; }
        }
        
        public string FemaleActor { get; set; } //prop + tab + tab -->> 조건 없을 때

        /*
        private string femaleActor;

        public string FemaleActor   //propfull + tab + tab -->> 조건 있을 때
        {
            get { return femaleActor; }
            set { femaleActor = value; }
        }

        public string FemaleActor1 { get => femaleActor; set => femaleActor = value; }
        */
    }
    class Class2
    {
        static void Main()
        {
            Drama d1 = new Drama();
            d1.title = "악의 꽃";

            d1.MaleActor = "이준기";
            d1.FemaleActor = "문채원";
        }
    }
}
