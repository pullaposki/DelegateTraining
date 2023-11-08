namespace DelegateTraining
{
	class Program
	{
		static void Main(string[] args)
		{
			//https://www.youtube.com/watch?v=3ZfwqWl-YI0&ab_channel=CodeMonkey
			//5:11

			DelegateTest delegateTest = new DelegateTest();
			
			delegateTest.AssingSecondFunctionToField();
			delegateTest.AddSecondFunctionToField();
			delegateTest.RemoveSecondFunctionFromField();
			delegateTest.DelegateField();
		}
	}
}
