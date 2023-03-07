using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class BankAcount
    {
        private readonly string m_customerName;// Cliente
        private double m_balance; // Saldo

        private BankAcount() { }
        public BankAcount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }
        public string CustomerName
        {
            get { return m_customerName;  }
        }
        public double Balance 
        {
            get { return m_balance; }
        }
        public void Debit(double amount)
        {
            if (amount > m_balance) 
            {
                throw new ArgumentException();
            }
        }

    }
}
