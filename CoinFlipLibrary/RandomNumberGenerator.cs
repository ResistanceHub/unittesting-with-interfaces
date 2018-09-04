using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipLibrary
{
	public class RandomNumberGenerator : IRandomGenerator 
	{
		private Random random;

		public RandomNumberGenerator()
		{
			random = new Random();
		}

		public int Next(int min, int max)
		{
			return random.Next(min, max);
		}
	}
}
