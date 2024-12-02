
//7. 2D Array Search
//Description: Implement a program that will let you reserve a specific plane seat. 
//Program asks to assign seats on a small airplane that has 7 rows and 4 columns. after a seat has been selected by user input, an X is to appear in that spot and the new display is to be displayed
//user input letter A,B,C,D and a number.

Console.WriteLine("Welcome To UnitedAirlines");
char[,] seats = {
{ 'A', 'B', 'C', 'D' },//0
{ 'A', 'B', 'C', 'D' },//1
{ 'A', 'B', 'C', 'D' },//2
{ 'A', 'X', 'C', 'D' },//3
{ 'A', 'B', 'C', 'D' },//4
{ 'A', 'B', 'C', 'D' },//5
{ 'A', 'B', 'C', 'D' },//6
};

Console.WriteLine(seats[3, 1]);
Console.ReadLine();
