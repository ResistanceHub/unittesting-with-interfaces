using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipLibrary
{
	public interface IRandomGenerator
	{
		/// <summary>
		/// Returns a random int
		/// </summary>
		/// <param name="min">Inclusive min number</param>
		/// <param name="max">Exclusive max number</param>
		/// <returns></returns>
		int Next(int min, int max);
	}
}
