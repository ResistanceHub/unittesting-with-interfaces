using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CoinFlipLibrary;
using CoinFlipUnitTests.mocks;
using NUnit.Framework;

namespace CoinFlipUnitTests
{
	[TestFixture]
	public class CoinTest
    {

	    [SetUp]
	    public void BeforeEach()
	    {
		    
	    }

	    [TearDown]
	    public void AfterEach()
	    {
		    
	    }

	    [Test]
	    public void CallRamdomGeneratorWithCorrectInputs()
	    {
		    // Given | Arrange
		    var mockRandomGenertor = new MockRandomGenerator(0);
			var coin = new Coin(mockRandomGenertor);
			// When  | Act
		    coin.Flip();
		    // Then  | Assert 
			Assert.AreEqual(0, mockRandomGenertor.Min);
			Assert.AreEqual(2, mockRandomGenertor.Max);
		}

		[Test]
		public void FlipReturnsTails()
		{
			// failing, pass, refactor
			// red, green, refactor 

			// Given | Arrange
			var mockRandomGenertor = new MockRandomGenerator(1);
			var coin = new Coin(mockRandomGenertor);
			// When  | Act
			var actual = coin.Flip();
			// Then  | Assert 
			Assert.AreEqual(Sides.Tails, actual);
		}

		public void FlipReturnsHeads()
		{
			// Given | Arrange
			var mockRandomGenertor = new MockRandomGenerator(0);
			var coin = new Coin(mockRandomGenertor);
			// When  | Act
			var actual = coin.Flip();
			// Then  | Assert 
			Assert.AreEqual(Sides.Heads, actual);
		}



	}
}
