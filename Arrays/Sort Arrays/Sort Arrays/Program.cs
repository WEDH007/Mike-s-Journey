
using System.ComponentModel;

string[] myNumbers = { "December 26, 2024","January 8, 2022", "March 16,2001", "June 9,1998", "August 13, 2010" };
DateTime[] myDates;
DateTime parseddate;
foreach (string i in myNumbers)
{
    Console.WriteLine(i);
}



Array.Sort(myNumbers);


foreach (string i in myNumbers)
{
    parseddate = DateTime.Parse(i);
    myDates.Add(parseddate);
    Console.WriteLine(parseddate);
}



// Un loop foreach lee cada valor 







Array.Sort(parseddate);

Console.ReadLine();