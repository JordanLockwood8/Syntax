//switched int to var
var answer = 4;
//use ctl+k+c
//string response;
//if (answer < 9)
//{
//    response = answer + " is less than nine";
//}
//else
//{
//    response = answer + " is greater than or equal to nine";
//}
//write out my ternary operator to match above ,if else
var response = (answer < 9) ? $" {answer} less than nine " : $" {answer} greater than or equal to nine ";
Console.WriteLine(response);
Console.WriteLine();

// extra practice was just looking at basic stuff
string animals = "dogs";
string name = "gus";
int age = 3;
var thisdog = $" this {animals} name is {name} and it is {age}";
Console.WriteLine(thisdog);

