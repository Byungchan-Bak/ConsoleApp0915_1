using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0915
{
    class AccuontManager
    {
        BankAccount account;
        public static int money;

        public void PrintMenu()
        {
            //System.Windows.Froms.MessageBox.Show("Hello", "title");

            Console.WriteLine("\n*****Menu*****");
            Console.WriteLine("1. 계좌 개설");
            Console.WriteLine("2. 입금");
            Console.WriteLine("3. 출금");
            Console.WriteLine("4. 잔액 조회");
            Console.WriteLine("5. 프로그램 종료");
        }

        public void MakeAccount()   //계좌 개설
        {
            Console.Write("계좌번호 : ");
            string accNum = Console.ReadLine();
            Console.Write("예금주 명 : ");
            string accName = Console.ReadLine();

            account = new BankAccount(accNum, accName);
        }

        private bool CheckAccount()
        {
            if (account == null)
            {
                Console.WriteLine("계좌개설을 진행하여 주십시오.");
                return false;
            }

            else
                return true;
        }

        public void Deposit()   //입금
        {
            if(CheckAccount() == false)
                return;
            Console.Write("입금하실 금액 : ");
            money = int.Parse(Console.ReadLine());
            account.InputMoney(money);
        }

        public void Withdraw()  //출금
        {
            if (CheckAccount() == false)
                return;
            Console.Write("출금하실 금액 : ");
            money = int.Parse(Console.ReadLine());
            account.OutputMoney(money);
        }

        public void ViewAccount()
        {
            account.PrintAccInfo();
        }
    }
    class AccountProgram
    {
        static void Main()
        {
            AccuontManager manager = new AccuontManager();
            Console.WriteLine(manager.ToString());

            
            while (true)
            {
                manager.PrintMenu();
                Console.Write("선택 : ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        manager.MakeAccount();
                        break;

                    case 2:
                        manager.Deposit();
                        break;

                    case 3:
                        manager.Withdraw();
                        break;

                    case 4:
                        manager.ViewAccount();
                        break;

                    case 5:
                        return; //Environment.Exit(0)와 break추가하여 사용

                    default:
                        Console.WriteLine("다시 선택하시오.");
                        break;
                }
            }
        }
    }
}
