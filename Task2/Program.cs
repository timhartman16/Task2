using System;
using System.Globalization;

class Program
{
	static readonly IFormatProvider _ifp = CultureInfo.InvariantCulture;

	class Number
	{
		readonly int _number;

		public Number(int number)
		{
			_number = number;
		}
		
		//Добавил перегрузку оператора сложения 
		public static string operator +(Number someValue1, string someValue2)
        {
			return new Number(someValue1._number + Int32.Parse(someValue2)).ToString();
        }

		public override string ToString()
		{
			return _number.ToString(_ifp);
		}
	}

	static void Main(string[] args)
	{
		int someValue1 = 10;
		int someValue2 = 5;
        
		string result = new Number(someValue1) + someValue2.ToString(_ifp);
		Console.WriteLine(result); //теперь выведется не 105, а 15
		Console.ReadKey();
	}
}
