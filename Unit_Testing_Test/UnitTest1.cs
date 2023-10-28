namespace Unit_Testing_Test
{
	[TestClass]
	public class CheckingTest
	{
		[TestMethod]
		public void CheckingWithdraw()
		{
			Assignment_Unit_Testing.Checking checking = new Assignment_Unit_Testing.Checking(250);
			double assumedBalance = 250.0000;
			checking.Withdraw(200);
			assumedBalance -= 200;
			Assert.AreEqual(assumedBalance, checking.Balance);	//... the balance is currently Internal. That makes testing impossible.
		}
		[TestMethod]
		public void CheckingWithdrawOverdraft()
		{
			Assignment_Unit_Testing.Checking checking = new Assignment_Unit_Testing.Checking(25);
			double assumedBalance = 25.0000;
			checking.Withdraw(200);
			assumedBalance -= 200;
			Assert.AreNotEqual(assumedBalance, checking.Balance);
		}
		[TestMethod]
		public void CheckingDeposit()
		{
			Assignment_Unit_Testing.Checking checking = new Assignment_Unit_Testing.Checking(25);
			double assumedBalance = 25.0000;
			checking.Deposit(200);
			assumedBalance += 200;
			Assert.AreEqual(assumedBalance, checking.Balance);
		}
		[TestMethod]
		public void CheckingNegativeDeposit()
		{
			Assignment_Unit_Testing.Checking checking = new Assignment_Unit_Testing.Checking(25);
			double assumedBalance = 25.0000;
			checking.Deposit(-200);
			assumedBalance -= 200;
			Assert.AreNotEqual(assumedBalance, checking.Balance);
		}
	}
	[TestClass]
	public class SavingsTest
	{
		[TestMethod]
		public void SavingsWithdraw()
		{
			Assignment_Unit_Testing.Savings savings = new Assignment_Unit_Testing.Savings(250);
			double assumedBalance = 250.0000;
			savings.Withdraw(200);
			assumedBalance -= 200;
			Assert.AreEqual(assumedBalance, savings.Balance);
		}
		[TestMethod]
		public void SavingsWithdrawNegative()
		{
			Assignment_Unit_Testing.Savings savings = new Assignment_Unit_Testing.Savings(250);
			double assumedBalance = 250.0000;
			savings.Withdraw(-200);
			assumedBalance -= -200;
			Assert.AreNotEqual(assumedBalance, savings.Balance);
		}
		[TestMethod]
		public void SavingsDeposit()
		{
			Assignment_Unit_Testing.Savings savings = new Assignment_Unit_Testing.Savings(250);
			double assumedBalance = 250.0000;
			savings.Deposit(200);
			assumedBalance += 200;
			assumedBalance += 5; //Gotta remember interest! 
			Assert.AreEqual(assumedBalance, savings.Balance);
		}
		[TestMethod]
		public void SavingsDepositNegative()
		{
			Assignment_Unit_Testing.Savings savings = new Assignment_Unit_Testing.Savings(250);
			double assumedBalance = 250.0000;
			savings.Deposit(-200);
			assumedBalance -= 200;
			Assert.AreNotEqual(assumedBalance, savings.Balance);
		}
	}
}