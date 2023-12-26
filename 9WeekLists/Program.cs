
 
while (true)
{
    Console.WriteLine("Add an item (add)/ Exit (exit):");
    string userChoice = Console.ReadLine();

    if (userChoice == "add")
    {
        Console.WriteLine("Enter an item:");
        string userItem = Console.ReadLine();
        myShoppingList.Add(userItem);
    }
    else 
    {
        Console.WriteLine("Bye!");
        break;
    }
}
}

int listLength = myShoppingList.Count;
Console.WriteLine($"You have added {listLength} items");

foreach (string item in myShoppingList)
{ 
    Console.WriteLine(item); 
}

int i = 1;
foreach (string item in myShoppingList) 
{
    Console.WriteLine($"{i}.{item}");
    i++;
}
Console.ReadKey();
