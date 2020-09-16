using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp0915
{
    public class BankAccount
    {
        private static double interest = 0.002;   //이자율
        private string accNum;           //계좌번호
        private string name;             //예금주명
        private int balance;         //잔액
        private int count = 0;
        #region property
        public string AccNum    //속성 -->> 괄호(x), value를 통해 데이터 전달
        {
            get { return accNum; }
            set { accNum = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //잔액조회
        public int CheckMoney   //읽기전용 속성
        {
            get { return balance; }
        }
        #endregion

        #region ctor
        public BankAccount()
        {
            balance = 10;
        }
        public BankAccount(string accNum, string accname)
        {
            this.accNum = accNum;   //파라미터와 멤버변수의 이름이 동일하여 구분 지을 때 this
            Name = accname;
        }
        #endregion

        #region method
        //출금
        public void OutputMoney(int amount)
        {
            if (amount > balance)
            {
                Console.WriteLine($"잔액이 부족합니다.(현재잔액 : {balance})");
                return;
            }

            balance = balance - amount;
        }

        //예금
        public void InputMoney(int amount)
        {
            balance = balance + amount + (int)(amount * interest);
        }

        //계좌정보
        public void PrintAccInfo()
        {
            Console.WriteLine($"예금주 명 : {this.Name}");  //this는 인스턴스
            Console.WriteLine($"계좌번호 : {this.accNum}");
            Console.WriteLine($"잔액 : {this.balance}");
            Console.WriteLine($"이율 : {BankAccount.interest * 100}%");  //static인 interest는 인스턴스가 아니므로 this불가
        }

        //이자율 변경
        public static void SetInterest(double interest) //정적 메서드는 인스턴스에 접근불가
        {
            BankAccount.interest = interest;
            //balance += 10;
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] menu = new string[3] { "입금", "출금", "통장조회" };
            int user, money;
            bool error = true;

            BankAccount acc0 = new BankAccount();

            while (true)
            {
                Console.Write("사용자의 이름을 입력하시오. : ");
                acc0.Name = Console.ReadLine();
                Console.Write("사용자의 계좌번호를 입력하시오.(-포함) : ");
                acc0.AccNum = Console.ReadLine();

                Console.WriteLine($"{menu[0]}(1), {menu[1]}(2), {menu[2]}(3)");
                Console.Write("원하시는 메뉴를 선택하시오. : ");
                user = int.Parse(Console.ReadLine());

                if (user != 1 && user != 2 && user != 3)
                {
                    error = false;
                    Console.WriteLine("다시 입력하시오.");
                }

                if ((user == 1 || user == 2) && error == true)
                {
                    Console.Write($"{menu[user - 1]}하시려는 금액을 입력하시오. : ");
                    money = int.Parse(Console.ReadLine());

                    if (user == 1)
                        acc0.InputMoney(money);

                    else
                        acc0.OutputMoney(money);
                }

                if (user == 3)
                {
                    acc0.PrintAccInfo();
                }
            }
        }
    }
}
