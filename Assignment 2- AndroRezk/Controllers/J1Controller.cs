using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2__AndroRezk.Controllers
{
    // <summary>
    // find total calories of meal by choosing list item as array and adding total cost of all arrays chosen
    // </summary>
    // <param> the input is the number of the item on the menu, user picks one item from each menu</param>
    // <returns>The user input is subtracted by 1 as arrays start at 0 index. All the inputs of the user are then added to a total which is the total amount of calories</returns>
    // GET api/J1/Menu/{1}/{1}/{1}/{1} --> 858 calories
    public class J1Controller : ApiController
    {
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu (int burger, int drink, int side, int dessert)
        {
            int [] burgerArr = { 461, 431, 420, 0 };
            int [] drinkArr = { 130, 160, 118, 0 };
            int [] sideArr = { 100, 57, 70, 0 };
            int[] dessertArr = { 167, 266, 75, 0};

            burger = burgerArr[burger-1];
            drink = drinkArr[drink-1];
            side = sideArr[side-1];
            dessert = dessertArr[dessert-1];
            int totalCal = burger + drink + side + dessert;

            return "Your total calorie count is: " + totalCal;

        }
    }
}
