using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
	public class Reverse
	{
		public int reverseNum(int number, int result)
		{
				if (number > 0)
			{
	
				return this.reverseNum((int)(number / 10),
				result * 10 + (number % 10));
			}
			return result;
		}
		public int reverse(int number)
		{
			Console.WriteLine("\nBefore Number : [" + number + "]");
			if (number < 0)
			{
				return -this.reverseNum(-number, 0);
			}
			else
			{
				return this.reverseNum(number, 0);
			}
		}
		public static void Main(String[] args)
		{
			var task = new Reverse(); 
			var number = 12345;
			number = task.reverse(number);
			Console.WriteLine("After Number  : [" + number + "]");
			
		}
	}
}
