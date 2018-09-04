using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipLibrary
{
    public class Coin
    {
	    private readonly IRandomGenerator randomGenerator;

	    public Coin(IRandomGenerator randomGenerator)
	    {
		    this.randomGenerator = randomGenerator;
	    }
	    public Sides Flip()
	    {
		    return (Sides) randomGenerator.Next(0, 2);
	    }
    }
}
