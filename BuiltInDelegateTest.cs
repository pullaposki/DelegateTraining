using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTraining
{
	internal class BuiltInDelegateTest
	{
		Action _testAction;
		public Action<int, float> TestIntFloatAction;
		public Func<bool> BoolTestFunc;

		public Func<int, bool> FuncThatTakesAnIntAndReturnsABool;
		// Same as below delegate
		//public delegate bool BoolTestDelegate(int number);

		public void AssignIntFloatActionWithAnonymousFunction()
		{
			TestIntFloatAction = (int i, float f) => { Console.WriteLine(i + " and a " + f); };
		}

		public void AssignMethodToBoolTestFunc()
		{
			BoolTestFunc = BoolTestFunction;
		}

		public void AssignAnAnonymousMethodToIntBoolFunc()
		{
			FuncThatTakesAnIntAndReturnsABool = (int i) => i > 5;
		}

		bool BoolTestFunction()
		{
			Console.WriteLine("Func has a return type an action doesn't.");
			
			return true;
		}
	}
}
