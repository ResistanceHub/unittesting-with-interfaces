using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinFlipLibrary;

namespace CoinFlipUnitTests.mocks
{
	public class MockRandomGenerator : IRandomGenerator
	{
		private readonly int mockResult;
		private int min;
		private int max;


		public MockRandomGenerator(int mockResult)
		{
			this.mockResult = mockResult;
		}

		public double Min => min;
		public double Max => max;

		public int Next(int min, int max)
		{
			this.min = min;
			this.max = max;
			return mockResult;
		}
	}
}
