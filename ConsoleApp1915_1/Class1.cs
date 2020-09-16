using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0915
{
    class MyCat
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }
    }
    class Class1    //default : internal
    {
        public int Sum(int x, int y)   //default : private
        {
            return x + y;
        }

        static void Main()  //Main메서드는 프로그램의 시작점이기 때문에 인스턴스를 할 메서드가 존재하지 않아 무조건 static
        {
            Class1 c1 = new Class1();   //상위 Sum메서드는 인스턴스이므로 static 메서드인 Main은 인스턴스 선언 후 Sum메서드를 활용
            MyCat b1 = new MyCat();
            int result = c1.Sum(5, 3);

            Random rnd = new Random();
            rnd.Next(1, 101);

            int result00 = MyCat.Sum(5, 3);
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = MyCat.Sum(5, i);
        }
    }
}
