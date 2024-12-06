using Inventory;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Xml.Serialization;



List<Item> items = new List<Item>
{
//new Item ("Apple", 10, 10),
//new Item ( "Orange", 15, 15),
//new Item ( "Grapes", 20, 20),
//new Item ( "Pineapple", 30, 30),
new Item ( "Carrot", 55, 55),

};
int n = 0;
int totalvalue;
int choice = 0;
bool gameon = true;


const string NewValue = @"
        Please enter the new value:";
const string UpdateQP = @"

What would you like to update?
1. Quantity
2. Price
Please select an option (1-2):";
const string MainMenuText = @"
    ---------------------------- Simple Inventory System ----------------------------
1. View Inventory
2. Add Item to Inventory
3. Remove Item from Inventory
4. Update Item in Inventory
5. Search Item by Name
6. View Total Inventory Value
7. Exit
---------------------------------------------------------------------------------
Please select an option (1-7):";
const string Division = @"
    --------------------------------------------------------------------";
const string RemoveItemTitle = @"
----------------------------Remove Item----------------------------
";
const string ViewItemsTitle = @"
---------------------------- Total Inventory Value ----------------------------";
const string SearchItemTitle = @"
    ----------------------------Search Item----------------------------";
const string UpdateItemTitle = @"
    ----------------------------Update Item----------------------------
";


while (gameon) {

    Console.Clear();
    
    choice = GetValidatedInput(MainMenuText,7);
    Console.Clear();

switch (choice)
{
    case 1:
        ViewInventory();
        break;
    case 2:
           AddItemDisplay();
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
            Console.Clear();
            Console.WriteLine("Goodbye.");
        gameon = false;
        break;
    default:
        break;
}
}
void CalculateTotal()
{
    totalvalue = 0;

    foreach (Item i in items)
    {
        
        n = i.Quantity * i.Price;
        totalvalue += n;

    }
}
void ViewTotal()
{

    CalculateTotal();
    Console.WriteLine(ViewItemsTitle);
    Console.WriteLine($@"
Total Inventory Value: ${totalvalue}
{Division}");
    ReturnToMenu();
}
void SearchItem()
{

    Console.WriteLine(SearchItemTitle);
    if (!items.Any())
    {
        Console.WriteLine("    The inventory is empty.");
    }
    else
    {
        Console.WriteLine(@"
    Please enter the name of the item you want to search for:
");

        var foundItem = PrintItem();

    }
    Console.WriteLine(Division);

    ReturnToMenu();

}
void UpdateItem()
{
    Console.WriteLine(UpdateItemTitle);
    if (!items.Any())
    {
        Console.WriteLine("    The inventory is empty.");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Please enter the name of the item you want to update:");

        var foundItem = PrintItem();

        int option = GetValidatedInput(UpdateQP, 2);

        int value = GetValidatedInput(NewValue, 100);

        if (option == 1)
        {
            foundItem.Quantity = value;
        }
        else
        {
            foundItem.Price = value;
        }

        Console.WriteLine($@"Item successfully updated.");

        ReturnToMenu();
    }
    
}
void RemoveItem()
{
    Console.WriteLine(RemoveItemTitle);
    if (!items.Any())
    {
        Console.WriteLine("    The inventory is empty.");
        Console.ReadLine();
    }

    else
    {
        Console.WriteLine("Please enter the name of the item you want to remove:");
        string findname = FindItem();

        Console.WriteLine(@$"
Are you sure you want to remove {findname} from the inventory? (Y / N) :
{Division}");

    string confirmation = Console.ReadLine().ToUpper();//needs to be a method
    while (string.IsNullOrWhiteSpace(confirmation) || confirmation != "Y" && confirmation != "N")
    {
        Console.WriteLine("Invalid input. Please enter Y/N.");
        confirmation = Console.ReadLine();
    }

    if ( confirmation == "Y")
    {
        items.RemoveAll(i => i.Name == findname);
        Console.WriteLine($@"Item successfully removed.");
    }
    else
    {
        Console.WriteLine("Item was not removed.");
    }

    ReturnToMenu();
    }
}
string FindItem()
{
    string findname = "";
    bool itemnotfound = true;


    while (itemnotfound)
    {

        findname = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(findname))
        {
            Console.WriteLine("Invalid input. Please enter a valid name.");
            findname = Console.ReadLine();
        }
        findname = char.ToUpper(findname[0]) + findname.Substring(1);
        foreach (Item i in items)
        {
            if (i.Name == findname)
            {
                itemnotfound = false;
            }
        }
    }

        if (itemnotfound) { 
        Console.Clear();
        Console.WriteLine("Name not found. Try again.");
        }
    return findname;
}
void AddItemDisplay()
{ //static (name, int, int) AddItemDisplay(){}
    Console.WriteLine(@"
        ----------------------------Add New Item ----------------------------
    Please enter the item name:");
    string name = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(name))
    {
        Console.WriteLine("Invalid input. Please enter a valid name.");
        name = Console.ReadLine().ToUpper();
    }
    Console.WriteLine(@"
    Please enter the item quantity:");
    int quantity;
    while (!int.TryParse(Console.ReadLine(), out quantity) || quantity > 100)
    {
        Console.WriteLine("Invalid input. Please enter a valid number for quantity:");
    }
    Console.WriteLine(@"
    Please enter the item price per unit:");
    int price;
    while (!int.TryParse(Console.ReadLine(), out price) || price > 100)
    {
        Console.WriteLine("Invalid input. Please enter a valid number for price:");
    }
    AddItem(name, quantity, price);
}
void AddItem(string name, int quantity, int price) {
    
    items.Add(new Item(name, quantity, price));
    Console.WriteLine(@$"
    {Division}");

    Console.WriteLine($@"Item successfully added to the inventory.");

    ReturnToMenu();
}
void ViewInventory()
{
    Console.WriteLine(@$"
    ----------------------------Inventory----------------------------
    | Item Name       | Quantity | Price(per unit)| Total Value |
    ---------------------------------------------------------------");

   

    foreach (Item i in items)
    {
        Console.WriteLine(@$"    | {i.Name,-15} | {i.Quantity,8} | {i.Price,14} | {i.Quantity * i.Price,11} |");
        
    }
    if (!items.Any())
    {
        Console.WriteLine("    The inventory is empty.");
    }


    CalculateTotal();

    Console.WriteLine($@"    {Division}
    Total Inventory Value: {totalvalue}
    {Division}");

    ReturnToMenu();

}
void ReturnToMenu()
{
    Console.WriteLine($@"Press any key to return to the main menu.");// This needs to be a method. 
    Console.ReadLine();
}
Item PrintItem()
{
    string findname = FindItem();
    var foundItem = items.FirstOrDefault(i => i.Name == findname);
    Console.WriteLine(@$"

Item found: {foundItem.Name} | Quantity: {foundItem.Quantity} | Price: {foundItem.Price}");
    return foundItem;
}
int GetValidatedInput(string prompt, int maxValue)
{ 
    Console.WriteLine(prompt); 
    int value;
    while (!int.TryParse(Console.ReadLine(), out value) || value > maxValue)
    { 
        Console.WriteLine($"Invalid input. Please enter a number less than {maxValue}:");
    } 
    return value; 
}

