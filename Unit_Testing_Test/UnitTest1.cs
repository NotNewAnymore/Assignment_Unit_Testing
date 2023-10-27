namespace Unit_Testing_Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void CheckingWithdraw()
		{
			Assignment_Unit_Testing.Checking checking = new Assignment_Unit_Testing.Checking(250);
			double assumedBalance = 250.0000;
			checking.Withdraw(200);
			assumedBalance -= 200;
			Assert.AreEqual(assumedBalance, checking);	//... the balance is currently Internal. That makes testing impossible.
		}
	}
}