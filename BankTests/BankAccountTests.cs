using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Banco;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UptadesBalance()
        {
            // arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mario das couves ", beginningBalance);

            //act 
            account.Debit(debitAmount);

            //assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "O débito não ocorreu corretamente na conta!");

        }
        [TestMethod]
        public void Debit_whenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            //arrange 
            double beginningBalance = 11.99;
            double debitAmount =  -100.00;
            BankAccount account = new BankAccount("Mario das couves", beginningBalance);

            //Act and Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount) );

        }

    }
}
