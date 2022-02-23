# Assignment-2--AndroRezk
This Assignment contains three controllers which solve J1, J2, and J3 Junior problems from the waterloo Canadian Computing Competition. 

J1 - Canadian Calorie Counting- Year 2006
    <summary>
    find total calories of meal by choosing list item as array and adding total cost of all arrays chosen
    </summary>
    <param> the input is the number of the item on the menu, user picks one item from each menu</param>
    <returns>The user input is subtracted by 1 as arrays start at 0 index. All the inputs of the user are then added to a total which is the total amount of calories</returns>
    GET api/J1/Menu/{1}/{1}/{1}/{1} --> 858 calories

J2 - Shifty Sum- Year 2017
    // <summary> (This J2 problem is from 2017)
    // this problem calculates the user input (n) sequentially adding the previous sequences, where (k) represents number of sequence and is a maximum of 5.
    // </summary>
    // <param> the input (n) is any number of the user's choosing and the input (k) is the number in the sequence</param>
    // <returns>The user inputs any number of their choosing followed by the number in the sequence. this then runs the switch case statement to give output based on (n) and sequence in (k)</returns>
    // GET api/J2/ShiftSum/{12}/{3} --> 13332 

J3 - Sumac Sequences- Year 2011
    // <summary> (This J3 problem is from 2011)
    // This problem is called a Sumac Sequence. This problem takes two inputs (integers) and subtracts them, producing a third integer which is the difference. The difference is then output and the 3rd and 4th integer are subtracted from eachother and so on until the resulting integer is negative in which case it stops. The return is the amount of number in the sequence.
    // </summary>
    // <param> the input (x) & (y) is any number of the user's choosing, but the (x) must be a higher number otherwise the sequence will default to 0.</param>
    // <returns>The user inputs any numbers of their choosing. This runs the if statement to check the numbers are above 0, and if they are, a while loop runs to check how many numbers are in the sequence of integers before the last integer calculated is less than 0.</returns>
    // GET api/J3/SumacSeq/{120}/{71} --> 5
