using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("ثبت اطلاعات کاربران");
        while (true)
        {
            Console.WriteLine("لطفا نام خود را وارد نمایید");
            string FirstName = Console.ReadLine();
            if (FirstName == null)
            {
                Console.WriteLine("نام کاربر نمیتواند خالی باشد");

            }
            else
            {
                break;

            }


        }
        while (true)
        {
            Console.WriteLine("لطفا نام خانوادگی خود را وارد کنید ");
            String lastName = Console.ReadLine();
            if (lastName == null)
            {
                Console.WriteLine("نام خانوادگی نمیتواند خالی باشد");

            }
            else
            {
                break;
            }
        }
        while (true)
        {
            {
                Console.WriteLine("لطفا سن خود را وارد کنید");
            }
            int Age;
            int age = Convert.ToInt32(Console.ReadLine());

            if (age == null)
            {
                Console.WriteLine("سن نمیتواند خالی باشد");

            }
            else if (age >= 0)
            {
                Console.WriteLine("لطفا سن خود را به درستی وارد نمایید");
            }
            else
            {
                break;
            }
        }

        while (true)
        {
            Console.WriteLine("لطفا شماره موبایل خود را وارد نمایید ");


            string MobileNumber = Console.ReadLine();

            if (MobileNumber == null)
            {
                Console.WriteLine("شماره موبایل نمی‌تواند خالی باشد. لطفاً دوباره تلاش کنید.");

            }

            else if (!Regex.IsMatch(MobileNumber, @"^0[0-9]{10}$"))
            {
                Console.WriteLine("شماره موبایل باید با '0' شروع شده و دقیقاً 11 رقم باشد. لطفاً دوباره تلاش کنید.");
                continue;
            }
            else
            {
                Console.WriteLine($"شماره موبایل معتبر وارد شد: {MobileNumber}");
                break;
            }

            Console.ReadKey();


        }

    }


}
