using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2__AndroRezk.Controllers
{
    // <summary> (This J2 problem is from 2017)
    // this problem calculates the user input (n) sequentially adding the previous sequences, where (k) represents number of sequence and is a maximum of 5.
    // </summary>
    // <param> the input (n) is any number of the user's choosing and the input (k) is the number in the sequence</param>
    // <returns>The user inputs any number of their choosing followed by the number in the sequence. this then runs the switch case statement to give output based on (n) and sequence in (k)</returns>
    // GET api/J2/ShiftSum/{12}/{3} --> 13332 
    public class J2Controller : ApiController
    {
        [HttpGet]
        [Route("api/J2/ShiftSum/{n}/{k}")]
        public int ShiftSum (int n, int k)
        {
            int case1 = n;
            int case2 = n * 10;
            int case3 = n * 100;
            int case4 = n * 1000;
            int case5 = n * 1000;
            int case6 = n * 10000;
           

            switch(k)
            {
                case 1:
                return case1 + case2;
                    break;

                case 2:
                    return case1 + case2 + case3;
                    break;

                case 3:
                    return case1 + case2 + case3 + case4;
                    break;

                case 4:
                    return case1 + case2 + case3 + case4 + case5;
                    break;

                case 5:
                    return case1 + case2 + case3 + case4 + case5 + case6;
                    break;

                default:
                    return n;
                    break;
            } 
            
            
        }

    }
}
