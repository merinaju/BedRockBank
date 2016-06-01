using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedRockBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**********Welcome to BedrockBank********");
            string option="";
            Customer customer;
            do
            {
                Console.WriteLine("1.Create an Account");
                Console.WriteLine("2.Deposit into Account");
                Console.WriteLine("3.PrintAccount");
                Console.WriteLine("0.Exit");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        try
                        {
                            customer = VerifyCustomer();
                            Console.Write("what is the name of your account");
                            var accountname = Console.ReadLine();
                            Console.WriteLine("what type of account do you need");
                            Console.WriteLine("1.Checking");
                            Console.WriteLine("2.Saving");
                            var typeofAccount = Console.ReadLine();
                            AccountType accountType = AccountType.saving;
                            if(typeofAccount=="1")
                            {
                                accountType = AccountType.checking;
                            }

                            var account1 = Bank.CreateAccount(accountname, 1234, accountType, customer);
                            account1.Deposit(800);
                            Console.WriteLine("Account Name: {0},Number:{1},typeofAccount:{2},Balance:{3}", account1.AccountName,
                                account1.AccountNumber, account1.TypeofAccount, account1.Balance);

                        }
                        catch(ArgumentNullException ax)
                        {
                            Console.WriteLine("Failed {0}", ax.ParamName);
                        }
                        catch (DbEntityValidationException dx)
                        {
                            Console.WriteLine("Failed to create an account {0}", dx.Message);
                        }
                        catch (Exception)
                        {

                        }
                        break;
                    case "2":
                        customer = VerifyCustomer();
                        break;
                    case "3":
                        customer = VerifyCustomer();
                      //  PrintAccounts();
                        break;
                    case "0":
                        Console.WriteLine("goodbye");
                        break;
                    default:
                        break;



                }
            } while (option!="0");


        }

        private static Customer VerifyCustomer()
        {
            Console.WriteLine("what is your email address");
            var emailaddress = Console.ReadLine();
            var customer = Bank.FindCustomer(emailaddress);
            if (customer == null)
            {
                Console.WriteLine("Please enter the name of the customer");
                var customername = Console.ReadLine();
                customer = Bank.CreateCustomer(emailaddress, customername);
            }

            return customer;
        }
        //public static void PrintAccounts()
        //{
        //    foreach (var account in Bank.accounts)
        //    {
        //        Console.WriteLine("id:{0}, Name: {1}", account.AccountNumber, account.AccountName);
        //    }
        //}

    }
}

