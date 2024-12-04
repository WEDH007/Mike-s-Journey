
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using System;
using System.Diagnostics;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.VisualBasic;

string[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };






MainMenu();
int choice = 0;
char choice2 = 'x';
int updatechoice = 0;
int updatedvalue = 0;
string item = null;
int Quantity = 0;
int Price = 0;


switch (choice)
{
    case 1:
        ViewInventory();
        break;
    case 2:
        AddItem();
        break;
    case 3:
        RemoveItem();
        break;
    case 4:
        UpdateItem();
        break;
    case 5:
        SearchItem();
        break;
    case 6:
        ViewTotal();
        break;
    case 7:
        bool gameon = false;
        break;
}



void ViewTotal()
{
    Console.WriteLine($@"
---------------------------- Total Inventory Value ----------------------------
Total Inventory Value: ${Quantity * Price}
---------------------------------------------------------------------------");
    Console.WriteLine($@"Press any key to return to the main menu.");// This needs to be a method. 

}

void SearchItem()
{
    Console.WriteLine($@"
    ----------------------------Search Item----------------------------
Please enter the name of the item you want to search for:
{item}
Item found: Apple - Quantity: 50, Price: $0.50, Total Value: $25.00
--------------------------------------------------------------------");
    Console.WriteLine($@"Press any key to return to the main menu.");// This needs to be a method. 
    
}

void UpdateItem()
{
    Console.WriteLine(@$"
    ----------------------------Update Item----------------------------
Please enter the name of the item you want to update:
{item}
Item found: Apple - Quantity: 50, Price: $0.50

What would you like to update?
1. Quantity
2. Price
Please select an option (1-2):
{updatechoice}
Please enter the new value:
{updatedvalue}
--------------------------------------------------------------------");

Console.WriteLine($@"Item successfully updated.");
    
Console.WriteLine($@"Press any key to return to the main menu.");// This needs to be a method. 


}

void RemoveItem()
{
    Console.WriteLine(@$"
    ----------------------------Remove Item----------------------------
Please enter the name of the item you want to remove:
{item}
Are you sure you want to remove 'ItemName' from the inventory? (Y / N) :
{choice2}
--------------------------------------------------------------------");


Console.WriteLine($@"Item successfully removed.");

Console.WriteLine($@"Press any key to return to the main menu.");// This needs to be a method. 
}

void AddItem()
{
    Console.WriteLine(@$"
    ----------------------------Add New Item ----------------------------
Please enter the item name:
{item}
Please enter the item quantity:
{Quantity}
Please enter the item price per unit:
{Price}
--------------------------------------------------------------------");

Console.WriteLine($@"Item successfully added to the inventory.");

Console.WriteLine($@"Press any key to return to the main menu.");// This needs to be a method. 
}

void ViewInventory()
{
    Console.WriteLine(@$"
    ----------------------------Inventory----------------------------
| Item Name | Quantity | Price(per unit) | Total Value |
---------------------------------------------------------------");
    Console.WriteLine(@$"

| {item} | {Quantity} | {Price} | {Quantity * Price} |
| {item} | {Quantity} | {Price} | {Quantity * Price} |
| {item} | {Quantity} | {Price} | {Quantity * Price} |");

    Console.WriteLine(@$"
---------------------------------------------------------------
Total Inventory Value: {Quantity * Price};
-----------------------------------------------------------------");
}

static void MainMenu()
{
    Console.WriteLine(@"
    ---------------------------- Simple Inventory System ----------------------------
1. View Inventory
2. Add Item to Inventory
3. Remove Item from Inventory
4. Update Item in Inventory
5. Search Item by Name
6. View Total Inventory Value
7. Exit
---------------------------------------------------------------------------------
Please select an option (1-7):");
}
