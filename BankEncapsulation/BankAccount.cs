using System;
using System.Collections.Generic;
using System.Linq;
namespace BankEncapsulation
{
	public class BankAccount
	{
		public BankAccount()
		{
		}

		private double balance = 0;

		public void Deposit()
		{
			Console.WriteLine("How much would you like to deposit?: ");
			balance += Convert.ToDouble(Console.ReadLine());
		}

		public void GetBalance()
		{
			string unit;

			if (balance <= 0.99)
			{
				unit = "cents";
			}

			else if (balance == 1)
			{
				unit = "dollar";
			}

			else
			{
				unit = "dollars";
			}

			Console.WriteLine($"Your current balance is: {balance} {unit}");
		}
	}
}

