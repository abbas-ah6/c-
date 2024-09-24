/*string[] fradulentOrderIDs = new string[3];

fradulentOrderIDs[0] = "A123";
fradulentOrderIDs[1] = "B456";
fradulentOrderIDs[2] = "C789";

Console.WriteLine($"First: {fradulentOrderIDs[0]}");
fradulentOrderIDs[0] = "D000";
Console.WriteLine($"Reassign First: {fradulentOrderIDs[0]}");
Console.WriteLine($"Second: {fradulentOrderIDs[1]}");
Console.WriteLine($"Third: {fradulentOrderIDs[2]}"); */

/*string[] fradulentOrderIDs = { "A123", "B456", "C789" };
Console.WriteLine($"First: {fradulentOrderIDs[0]}");
Console.WriteLine($"Second: {fradulentOrderIDs[1]}");
Console.WriteLine($"Third: {fradulentOrderIDs[2]}");

Console.WriteLine($"There are {fradulentOrderIDs.Length} fradulent orders to process."); */

// string[] names = { "Abbas", "Awais", "Saad" };
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");