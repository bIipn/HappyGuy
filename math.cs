using System.Globalization;

//int firstValue = 500;
//int secondValue = 600;

//Console.WriteLine("The Largest value is ");
//Console.WriteLine( Math.Max(firstValue , secondValue));
///thus this method is not efficient enough.
int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
//but it will return highest value
|
|
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);


int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))

    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You get +6 bonus points");
        total += 6;
    } 
    else
    {
        Console.WriteLine("You get +2 bonus points");
        total += 2;
    }

if (total >= 15)
{
    Console.WriteLine("You Win!!");
}

else 
{
    Console.WriteLine("You Lose!!");
}

|
|
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
//
//finding the fruad\
string[] fruadulentOrderIDs = new string[3];

fruadulentOrderIDs[0] = "A123";
fruadulentOrderIDs[1] = "B456";
fruadulentOrderIDs[2] = "C789";


Console.WriteLine($"First: {fruadulentOrderIDs[0]}");
Console.WriteLine($"Second: {fruadulentOrderIDs[1]}");
Console.WriteLine($"Third: {fruadulentOrderIDs[2]}");

fruadulentOrderIDs[0] = "f000";

Console.WriteLine($"Reassign: {fruadulentOrderIDs[0]}");

Console.WriteLine($"There are {fruadulentOrderIDs.Length} fruadulent ID's");

///////////////////////
int[] inventory = { 20, 39, 49, 44, 99 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
sum += items;
bin++;
Console.WriteLine($"bin {bin} = {items} items (running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");

string[] name = new string[7];
name[0] = "B123";
name[1] = "C234";
name[2] = "A345";
name[3] = "C15";
name[4] = "B177";
name[5] = "G3333";
name[6] = "C233";
name[7] = "B179";

int  bee = 0;

if (name.StartsWith("B"))
{
    Console.WriteLine("");
}//got stuck solution down below ////////////////////////////////////////////////////
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}

string firstName = "Everett";
int widgetsPurchased = 7;
/*Testing a update to the code....
/ int widgetsSold = 7; 
 Console.WriteLine($"{firstName} has sold {widgetsSold} widget's.")
*/
Console.WriteLine($"{firstName} has bought a total of {widgetsPurchased} widget's.");

//////////////////////////////
Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}


string str = "The quick brown fox jumps over the lazy dog.";

// convert the message into a char array
char[] charMessage = str.ToCharArray();

// Reverse the chars
Array.Reverse(charMessage);
int x = 0;

// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }

// convert it back to a string
string new_message = new String(charMessage);

// print it out...

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");
//////
//////\
//////



string myValue = "a";
Console.WriteLine(myValue != "a");

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

////////////works without {}

string name = "steve";
if (name == "bob") 
Console.WriteLine("Found Bob");

else if (name == "steve") 
Console.WriteLine("Found Steve");

else 
Console.WriteLine("Found Chuck");

//////////////
.///////////////
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;
foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found) 
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");