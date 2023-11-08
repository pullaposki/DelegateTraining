namespace DelegateTraining
{
	class Program
	{
		static void Main(string[] args)
		{
			//https://www.youtube.com/watch?v=3ZfwqWl-YI0&ab_channel=CodeMonkey
			//11:24

			DelegateTest delegateTest = new DelegateTest();

			//delegateTest.AssingSecondFunctionToField();
			//delegateTest.AddSecondFunctionToField();
			//delegateTest.RemoveSecondFunctionFromField();
			//delegateTest.DelegateField();

			//delegateTest.AssignBoolTestFunctionToBoolField();
			//var value = delegateTest.BoolDelegateField(0);
			//Console.WriteLine(value);

			//delegateTest.AssignAnonymousMethodToDelegateField();
			//delegateTest.DelegateField();

			//delegateTest.AssignAnonymousBoolMethodToBoolDelegateField();
			//Console.WriteLine(delegateTest.BoolDelegateField(2));

			//delegateTest.AssignCompactAnonymousBoolMethodToBoolDelegateField();
			//Console.WriteLine(delegateTest.BoolDelegateField(-1));




			BuiltInDelegateTest builtInDelegateTest = new BuiltInDelegateTest();

			//builtInDelegateTest.AssignIntFloatActionWithAnonymousFunction();
			//builtInDelegateTest.TestIntFloatAction(5, 5.5f);

			//builtInDelegateTest.AssignMethodToBoolTestFunc();
			//Console.WriteLine(builtInDelegateTest.BoolTestFunc());

			builtInDelegateTest.AssignAnAnonymousMethodToIntBoolFunc();
			Console.WriteLine(builtInDelegateTest.FuncThatTakesAnIntAndReturnsABool(5));
		}
	}
}
