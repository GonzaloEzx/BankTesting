﻿using BankAccountNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        /* [TestMethod]
         public void Debit_WithValidAmount_UpdatesBalance()
         {
             // Arrange
             double beginningBalance = 11.99;
             double debitAmount = 4.55;
             double expected = 7.44;
             BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
             // Act
             account.Debit(debitAmount);
             // Assert
             double actual = account.Balance;
             Assert.AreEqual(expected, actual, 0.001, "La cuenta no se debitó correctamente");

         }*/

        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance() // nombre del TC
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "La cuenta no se debitó correctamente");
        }
    }
}
