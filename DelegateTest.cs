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

		//Create a field of type TestDelegate
		public TestDelegate DelegateField;

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

		void MyTestDelegateFunction()
		{
			Console.WriteLine("function 1 executed");
		}

		void MyTestDelegateFunction2()
		{
			Console.WriteLine("function 2 executed");
		}
	}
}
