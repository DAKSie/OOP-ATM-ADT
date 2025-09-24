using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLab.Models;

namespace OOPLab.ViewModels
{
    public class AccountViewModel
    {
        public List<Account> GetAccounts()
        {
            using var db = new ATMContext();
            return db.Accounts.ToList();
        }

        public void AddAccount(Account account)
        {
            using var db = new ATMContext();
            db.Accounts.Add(account);
            db.SaveChanges();
        }
    }
}