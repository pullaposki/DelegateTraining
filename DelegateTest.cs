using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTraining
{
	internal class DelegateTest
	{
		//Create a delegate
		public delegate void TestDelegate();

		public delegate bool BoolTestDelegate(int number);

		//Create a field of type TestDelegate
		public TestDelegate DelegateField;

		public BoolTestDelegate BoolDelegateField;


		public void AssignFirstFunctionToField()
		{
			DelegateField = MyTestDelegateFunction;
		}

		public void AssingSecondFunctionToField()
		{
			DelegateField = MyTestDelegateFunction2;
		}

		public void AddFirstFunctionToField()
		{
			DelegateField += MyTestDelegateFunction;
		}

		public void AddSecondFunctionToField()
		{ 
			DelegateField += MyTestDelegateFunction2;
		}

		public void RemoveFirstFunctionFromField()
		{
			DelegateField -= MyTestDelegateFunction;
		}

		public void RemoveSecondFunctionFromField()
		{
			DelegateField -= MyTestDelegateFunction2;
		}

		public void AssignBoolTestFunctionToBoolField()
		{
			BoolDelegateField = BoolDelegateTestFunction;
		}

		// If you need to remove a method from a delegate field later,
		// don't use anonymous methods.

		public void AssignAnonymousMethodToDelegateField()
		{
			DelegateField = delegate () 
			{ 
				Console.WriteLine("Anonymous method"); 
			};

			DelegateField += () => { Console.WriteLine("Anonymous method using Lambda"); };
		}

		public void AssignAnonymousBoolMethodToBoolDelegateField()
		{
			BoolDelegateField = (int i) => { return i > 0; };
		}

		public void AssignCompactAnonymousBoolMethodToBoolDelegateField()
		{
			BoolDelegateField = (int i) => i > 0;
		}

		void MyTestDelegateFunction()
		{
			Console.WriteLine("function 1 executed");
		}

		void MyTestDelegateFunction2()
		{
			Console.WriteLine("function 2 executed");
		}

		bool BoolDelegateTestFunction(int i)
		{
			return i > 0;
		}
	}
}
