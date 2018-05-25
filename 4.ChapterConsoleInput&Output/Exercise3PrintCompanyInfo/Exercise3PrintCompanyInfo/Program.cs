using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3PrintCompanyInfo
{
    class Company
    {
        static void Main(string[] args)
        {
            Console.Write("Enter company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Enter Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Enter company web site: ");
            string companyWebSite = Console.ReadLine();
            Console.Write("Enter company telephone number: ");
            int companyPhoneNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter company fax number: ");
            int companyFaxNumber = int.Parse(Console.ReadLine());


            Console.Write("\nEnter manager name: ");
            string managerName = Console.ReadLine();
            Console.Write("Enter manager surname: ");
            string managerSurame = Console.ReadLine();
            Console.Write("Enter manager phone number: ");
            int managerPhone = int.Parse(Console.ReadLine());

            Console.WriteLine("\nCompany name: {0}\nCompany address: {1}\nCompany web: {2}\nCompany phone: {3}\nCompany fax: {4}\n"
                , companyName, companyAddress, companyWebSite, companyPhoneNumber, companyFaxNumber);
            Console.WriteLine("Company manager: {0} {1}\nManager phone: {2}", managerName, managerSurame, managerPhone);
        }
    }
}
