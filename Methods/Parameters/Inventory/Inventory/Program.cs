using Inventory;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Xml.Serialization;



List<Item> items = new List<Item>
{
new Item { Name = "Apple", Quantity = 10, Price = 10 },
new Item { Name = "Orange", Quantity = 10, Price = 10 },
new Item { Name = "Lemon", Quantity = 10, Price = 10 },
new Item { Name = "Pineapple", Quantity = 10, Price = 10 },
new Item { Name = "Carrot", Quantity = 10, Price = 10 }

};


int n = 0;
int totalvalue;
int choice = 0;
bool gameon = true;
bool itemnotfound = true;


//int choice = 0;
//char choice2 = 'x';
//int updatechoice = 0;
//int updatedvalue = 0;
//string item = null;
//int Quantity = 0;
//int Price = 0;

while (gameon) {

    Console.Clear();
    MainMenu();
    while (!int.TryParse(Console.ReadLine(), out choice))
    {
        Console.WriteLine("Invalid input. Please enter a valid number (1-7)");
    }
    Console.Clear();

switch (choice)
{
    case 1:
        ViewInventory();
        break;
    case 2:
           AddItemDisplay();
            //var (name, quantity, price) = AddItemDisplay();
            //Additem(name, quantity, price);
            break;
    case 3:
            string findname = FindItem();
            RemoveItem(findname);
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
    
    Console.WriteLine(@$"
---------------------------- Total Inventory Value ----------------------------
Total Inventory Value: ${totalvalue}
---------------------------------------------------------------------------");
    ReturnToMenu();
}
void SearchItem()
{
    Console.WriteLine(@"
    ----------------------------Search Item----------------------------
Please enter the name of the item you want to search for:
{item}
Item found: Apple - Quantity: 50, Price: $0.50, Total Value: $25.00
--------------------------------------------------------------------");
    ReturnToMenu();

}
void UpdateItem()
{
    Console.WriteLine(@"
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

    ReturnToMenu();

    
}
void RemoveItem(string findname)
{
    Console.WriteLine(@$"
Are you sure you want to remove {findname} from the inventory? (Y / N) :

--------------------------------------------------------------------");
    string confirmation = Console.ReadLine().ToUpper();//needs to be a method
    while (string.IsNullOrWhiteSpace(confirmation)|| confirmation != "Y" && confirmation!= "N")
    {
        Console.WriteLine("Invalid input. Please enter Y/N.");
        confirmation = Console.ReadLine();
    }

    if( confirmation == "Y")
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
string FindItem()
{
    string findname ="";
    while (itemnotfound)
    {

        Console.WriteLine(@"
----------------------------Remove Item----------------------------
Please enter the name of the item you want to remove:");


        findname = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(findname))
        {
            Console.WriteLine("Invalid input. Please enter a valid name.");
            findname = Console.ReadLine().ToUpper();
        }
        foreach (Item i in items)
        {
            if (i.Name == findname)
            {
                itemnotfound = false;
            }


        }
        Console.Clear();
        Console.WriteLine("Name not found.");
    }
    return findname; ;
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
    Additem(name, quantity, price);
}
void Additem(string name, int quantity, int price) {
    
    items.Add(new Item { Name = name, Quantity = quantity, Price = price });
    Console.WriteLine(@"
    --------------------------------------------------------------------");

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
    CalculateTotal();

    Console.WriteLine($@"    ---------------------------------------------------------------
    Total Inventory Value: {totalvalue};
    -----------------------------------------------------------------");

    ReturnToMenu();

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
void ReturnToMenu()
{
    Console.WriteLine($@"Press any key to return to the main menu.");// This needs to be a method. 
    Console.ReadLine();
}