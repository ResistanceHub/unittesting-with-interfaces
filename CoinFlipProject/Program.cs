using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinFlipLibrary;

namespace CoinFlipProject
{
	class Program
	{
		static void Main(string[] args)
		{
			var generator = new RandomNumberGenerator();
			var coin = new Coin(generator);
			var result = coin.Flip();
			Console.WriteLine("The result was: " + result);
			Console.ReadKey();
		}
	}
}
