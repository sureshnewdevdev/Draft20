using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatch.Interfaces
{
    public interface IAccount
    {
        public int Cr { get; set; }
        public int Dr { get; set; }
        public string Particulars { get; set; }
        public DateTime TranscationDate { get; set; }

        public string GetAccountInfo();
    }

    public interface IAccountService
    {
        public void AddAccount(IAccount account);
        public void UpdateAccount(IAccount account);
      
    }

    public class FinAccount : IAccount, IAccountService
    {
        public int Cr { get; set; }
        public int Dr { get; set; }
        public string Particulars { get; set; }
        public DateTime TranscationDate { get; set; }

        public void AddAccount(IAccount account)
        {
           
        }

        public void DeleteAccount(IAccount account)
        {
            
        }

        public string GetAccountInfo()
        {
            return $"Cr: {Cr}, Dr: {Dr}, Particulars: {Particulars}, Transcation Date: {TranscationDate}";
        }

        void IAccountService.AddAccount(IAccount account)
        {
            new FinAccount().AddAccount(account);
        }
 

        void IAccountService.UpdateAccount(IAccount account)
        {
            new FinAccount().AddAccount(account);

        }
    }
}
