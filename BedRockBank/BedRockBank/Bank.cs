using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedRockBank
{
   public static class Bank
    {
        #region Variables
        public static BankModel db= new BankModel();
        #endregion
        /// <summary>
        /// creating a bank class to create an account
        /// </summary>
        /// <param name="accountname">name of account</param>
        /// <param name="ssn">social security number</param>
        /// <param name="typeOfAccount">type of account</param>
        /// <returns></returns>
        /// 

        public static Customer FindCustomer(string emailaddress)
        {
            if(string.IsNullOrEmpty(emailaddress))
            {
                throw new ArgumentNullException("Email address cannot be null or empty");
            }
            return db.Customers.Where(c => c.Email == emailaddress).FirstOrDefault();
        }

        public static Customer CreateCustomer(string emailaddress,string customername)
        {
            var customer = new Customer() { CustomerName = customername, Email = emailaddress };
            db.Customers.Add(customer);
            db.SaveChanges();
            return customer;
        }
        public static Account CreateAccount(string accountname,int ssn,AccountType typeOfAccount,Customer customer)
        {
            var account = new Account { AccountName = accountname, SSN = ssn, TypeofAccount = typeOfAccount ,customer=customer};
            db.Accounts.Add(account);
            db.SaveChanges();
            return account;
        }

       
    }
}
