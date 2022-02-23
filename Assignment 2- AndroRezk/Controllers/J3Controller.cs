using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2__AndroRezk.Controllers
{
    // <summary> (This J3 problem is from 2011)
    // This problem is called a Sumac Sequence. This problem takes two inputs (integers) and subtracts them, producing a third integer which is the difference. The difference is then output and the 3rd and 4th integer are subtracted from eachother and so on until the resulting integer is negative in which case it stops. The return is the amount of number in the sequence.
    // </summary>
    // <param> the input (x) & (y) is any number of the user's choosing, but the (x) must be a higher number otherwise the sequence will default to 0.</param>
    // <returns>The user inputs any numbers of their choosing. This runs the if statement to check the numbers are above 0, and if they are, a while loop runs to check how many numbers are in the sequence of integers before the last integer calculated is less than 0.</returns>
    // GET api/J3/SumacSeq/{120}/{71} --> 5
    public class J3Controller : ApiController
    {
        [HttpGet]
        [Route("api/J3/SumacSeq/{x}/{y}")]
        public int SumacSeq (int x, int y)
        {
            int SumacOutput;
            int NextTerm;
            if((x>= 0) && (y>= 0))
            {
                NextTerm = x - y;
                SumacOutput = 3;

            while(NextTerm >= 0)
                {
                    x = y;
                    y = NextTerm;
                    NextTerm = x - y;
                    SumacOutput++;
                }
            } else
            {
                SumacOutput = 0;
            }
            return SumacOutput;
        }  
    }
}
