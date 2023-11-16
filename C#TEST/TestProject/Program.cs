// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;
// }

// if (total >= 15)
// {
//     Console.WriteLine("You win!");
// }

// if (total < 15)
// {
//     Console.WriteLine("Sorry, you lose.");
// }  

// string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

// foreach (string orderID in orderIDs){
//     if (orderID.StartsWith("B")) {
//         Console.WriteLine(orderID);
//     }
// }


// initialize variables - graded assignments
// int currentAssignments = 5;

// int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
// int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
// int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
// int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// // Student names
// string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

// int[] studentScores = new int[10];

// string currentStudentLetterGrade = "";

// // Display the Report Header
// Console.WriteLine("Student\t\tGrade\n");

// foreach (string name in studentNames)
// {
//     string currentStudent = name;

//     if (currentStudent == "Sophia")
//         // assign Sophia's scores to the studentScores array 
//         studentScores = sophiaScores;

//     else if (currentStudent == "Andrew")
//         // assign Andrew's scores to the studentScores array 
//         studentScores = andrewScores;

//     else if (currentStudent == "Emma")
//         // assign Emma's scores to the studentScores array 
//         studentScores = emmaScores;

//     else if (currentStudent == "Logan")
//         // assign Logan's scores to the studentScores array 
//         studentScores = loganScores;

//     // initialize/reset the sum of scored assignments
//     int sumAssignmentScores = 0;

//     // initialize/reset the calculated average of exam + extra credit scores
//     decimal currentStudentGrade = 0;

//     foreach (int score in studentScores)
//     {
//         // add the exam score to the sum
//         sumAssignmentScores += score;
//     }

//     currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

//     if (currentStudentGrade >= 97)
//         currentStudentLetterGrade = "A+";

//     else if (currentStudentGrade >= 93)
//         currentStudentLetterGrade = "A";

//     else if (currentStudentGrade >= 90)
//         currentStudentLetterGrade = "A-";

//     else if (currentStudentGrade >= 87)
//         currentStudentLetterGrade = "B+";

//     else if (currentStudentGrade >= 83)
//         currentStudentLetterGrade = "B";

//     else if (currentStudentGrade >= 80)
//         currentStudentLetterGrade = "B-";

//     else if (currentStudentGrade >= 77)
//         currentStudentLetterGrade = "C+";

//     else if (currentStudentGrade >= 73)
//         currentStudentLetterGrade = "C";

//     else if (currentStudentGrade >= 70)
//         currentStudentLetterGrade = "C-";

//     else if (currentStudentGrade >= 67)
//         currentStudentLetterGrade = "D+";

//     else if (currentStudentGrade >= 63)
//         currentStudentLetterGrade = "D";

//     else if (currentStudentGrade >= 60)
//         currentStudentLetterGrade = "D-";

//     else
//         currentStudentLetterGrade = "F";

//     Console.WriteLine($"{name}\t\t{currentStudentGrade}\t?");
// }

// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();

// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// using System.Net.Http.Headers;
// using System.Runtime.InteropServices;

// Random coin = new Random();
// int coinSide = coin.Next(0, 2);
// Console.WriteLine( (coinSide == 0) ? "heads" : "tails");

// string permission = "Admin|Manager";
// int level = 15;

// if (permission.Contains("Admin")) 
// {
//     if (level > 55) 
//     {
//         Console.WriteLine ("Welcome, Super Admin user."); 
//     }  
//     else 
//     {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// }    

// else if (permission.Contains("Manager"))
//     {
//         if (level >= 20)
//         {
//             Console.WriteLine("Contact an Admin for access.");
//         }
//         else 
//         {
//             Console.WriteLine("You do not have sufficient privileges.");
//         }
//     }

// else 
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }


// bool flag = true;
// int value = 5;

// if (flag)
//     {
//         value = 10;
//         Console.WriteLine("Inside of code block: " + value);
//     }   
// Console.WriteLine("Outside of code block: " + value);


// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;
// bool found = false;

// foreach (int number in numbers)
// {
//     total += number;
//     if (number == 42)
//         found = true;
// }

// if (found)
//     Console.WriteLine("Set contains 42");

// Console.WriteLine($"Total: {total}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>

// int employeeLevel = 100;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])

// {   case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// switch (product[1])

// {   case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;
// }

// switch (product[2])

// {   case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// // (int i = 0; i < names.Length; i++)
// {
//     Console.WriteLine(names[i]);
// }


// for (int i = 1; i < 101; i++)
// {
//     if ((i % 3 == 0) && (i % 5 == 0))
//         Console.WriteLine($"{i} - FizzBuzz");
//     else if (i % 3 == 0)
//         Console.WriteLine($"{i} - Fizz");
//     else if (i % 5 == 0)
//         Console.WriteLine($"{i} - Buzz");
//     else
//         Console.WriteLine($"{i}");
// }

// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);


// You must use either the do-while statement or the while statement as an outer game loop.
// The hero and the monster will start with 10 health points.
// All attacks will be a value between 1 and 10.
// The hero will attack first.
// Print the amount of health the monster lost and their remaining health.
// If the monster's health is greater than 0, it can attack the hero.
// Print the amount of health the hero lost and their remaining health.
// Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
// Print the winner.

// Monster was damaged and lost 1 health and now has 9 health.
// Hero was damaged and lost 1 health and now has 9 health.
// Monster was damaged and lost 7 health and now has 2 health.
// Hero was damaged and lost 6 health and now has 3 health.
// Monster was damaged and lost 9 health and now has -7 health.
// Hero wins!

// int hero = 10;
// int monster = 10;

// Random attack = new Random();

// do 
// {  
//     int newAttack = attack.Next(1, 11);
//     monster -= newAttack;
//     Console.WriteLine($"Monster was damaged and lost {newAttack} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     newAttack = attack.Next(1, 11);
//     hero -= newAttack;
//     Console.WriteLine($"Hero was damaged and lost {newAttack} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

// string? readResult;
// Console.WriteLine("Enter a string:");
// do
// {
//     readResult = Console.ReadLine();
// } while (readResult == null);

// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult.Length >= 3)
//         {
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while (validEntry == false);

// // capture user input in a string variable named readResult

// int numericValue = 0;
// bool validNumber = false;

// validNumber = int.TryParse(readResult, out numericValue);
// -----------------------------------------------------------

//Project 1

// string? readResult;
// string valueEntered = "";
// int numValue = 0;
// bool validNumber = false;

// Console.WriteLine("Enter an integer value between 5 and 10");

// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         valueEntered = readResult;
//     }

//     validNumber = int.TryParse(valueEntered, out numValue);

//     if (validNumber == true)
//     {
//         if (numValue <= 5 || numValue >= 10)
//         {
//             validNumber = false;
//             Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
//         }
//     }
//     else 
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }
// } while (validNumber == false);

// Console.WriteLine($"Your input value ({numValue}) has been accepted.");

// readResult = Console.ReadLine();

// --------------------------------------

//Project 2

// string? readResult;
// string roleName = "";
// bool validEntry = false;

// do 
// {
//     Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         roleName = readResult.Trim();
//     }
//     if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user");
//     {
//         validEntry = true;
//     }
//     else
//     {
//         Console.WriteLine($"The role name that you entered, \"{roleName}\" is not valid.");
//     }
// }

// while (validEntry == false);

// Console.WriteLine($"Your input value ({roleName}) has been accepted");
// readResult = Console.ReadLine();

// -------------------------------------------------------------------------------

//Project 3

// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// int stringsCount = myStrings.Length;

// string myString = "";
// int periodLocation = 0;

// for (int i = 0; i < stringsCount; i++)
// {
//     myString = myStrings[i];
//     periodLocation = myString.IndexOf(".");

//     string mySentence;

//     // extract sentences from each string and display them one at a time
//     while (periodLocation != -1)
//     {

//         // first sentence is the string value to the left of the period location
//         mySentence = myString.Remove(periodLocation);

//         // the remainder of myString is the string value to the right of the location
//         myString = myString.Substring(periodLocation + 1);

//         // remove any leading white-space from myString
//         myString = myString.TrimStart();

//         // update the comma location and increment the counter
//         periodLocation = myString.IndexOf(".");

//         Console.WriteLine(mySentence);
//     }

//     mySentence = myString.Trim();
//     Console.WriteLine(mySentence);
// }

//--------------------------------------------------------------------------------------

// DATA TYPES

// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

//-------------------------------------------------------------------------------------

// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);

//----------------------------------------------------------------------------------------

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// decimal total = 0m;
// string message = "";

// foreach (var value in values)
// {
//     decimal number; // stores the TryParse "out" value
//     if (decimal.TryParse(value, out number))
//     {
//         total += number;
//     } else
//     {
//         message += value;
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

//----------------------------------------------------------------------------------------

// int value1 = 12;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
//Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
//Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
//Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// Convert.ToInt32() rounds up the way you would expect.
//int result1 = Convert.ToInt32((decimal)value1 / value2);
//Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

//decimal result2 = value2 / (decimal)value3;
//Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

//float result3 = value3 / value1;
//Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

//----------------------------------------------------------------------------------------

// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets); 
// Here you're using the Sort() method of the Array class to sort the items in the array alphanumerically.

// foreach (var pallet in pallets) 
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reverses...");
// Array.Reverse(pallets);
//To reverse the order of the pallets

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"--{pallet}");
// }

// string[] pallets = { "B24", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
//Here you're using the Array.Clear() method to clear the values stored in the elements of the pallets array starting at index 0 and clearing 2 elements.

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0]}");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After: {pallets[0]}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
//Here, you're calling the Resize() method passing in the pallets array by reference, using the ref keyword.

// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

//---------------------------------------------------------------------------------

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

//----------------------------------------------------------------------------------

//Split(), ToCharArray(), Array.Reverse(), and String.Join()

//string pangram = "The quick brown fox jumps over the lazy dog";

//Split the pangram string on the space character to create the string array message
// string[] message = pangram.Split(' ');

//Create a new newMessagearray that will store a reversed copy of the "word" string from the message array.
// string[] newMessage = new string[message.Length]; 

//Loop through each element in the message array, reverse it and store this element in newMessage array.
// for (int i = 0; i < message.Length; i++)
// {
//     char[] words = message[i].ToCharArray();
//     Array.Reverse(words);
//     newMessage[i] = new string(words);
//     Console.WriteLine(words);
// }

//Join "word" strings from the array newMessage, using a space again, to create the desired single string to write to the console.
// string result = String.Join(" ", newMessage);

// Console.WriteLine(result);

//-----------------------------------------------------------------------------------

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// string[] items = orderStream.Split(',');

// Array.Sort(items);

// foreach (var item in items)
// {
//     if (item.Length != 4) 
//     {
//         Console.WriteLine(item + "\t- Error");
//     }
//     else 
//     {
//     Console.WriteLine(item);
//     }
// }

//------------------------------------------------------------------------------------

// string first = "Hello";
// string second = "World";
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);
//output
//Hello World!
//World Hello!
//Hello Hello Hello!

//Formatting currency ----------------------------------------------------------------
// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})"); //Price: $123.45 (Save $50.00)

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N4} units");
// By default, the N numeric format specifier displays only two digits after the decimal point.
// To display more precision, add a number after the specifier.

//Formatting percentages ----------------------------------------------------------------

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");
// Tax rate: 36.79 %

//Combining formatting approaches --------------------------------------------------------

// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
// Console.WriteLine(yourDiscount);

//

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");

// output
// Invoice Number: 1201
//    Shares: 25.457 Product
//      Sub Total: $2,750.00
//            Tax: 15.83%
//      Total Billed: $3,185.19

// string paymentId = "769C";
//  string payeeName = "Mr. Stephen Ortega";
//  string paymentAmount = "$5,000.00";

//  var formattedLine = paymentId.PadRight(6);
//  formattedLine += payeeName.PadRight(24);
//  formattedLine += paymentAmount.PadLeft(10);

//  Console.WriteLine("1234567890123456789012345678901234567890");
//  Console.WriteLine(formattedLine);

// Output

//  1234567890123456789012345678901234567890
//  769C  Mr. Stephen Ortega       $5,000.00

//String interpolation to a form letter ----------------------------------------------

// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// Console.WriteLine($"Dear {customerName},"); 
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}. Given your current volume, your potential profit would be {newProfit:N}.\n");
// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", currentProfit).PadLeft(20);

// comparisonMessage += "/n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", newProfit).PadLeft(20);

// Console.WriteLine(comparisonMessage);

//-------------------------------------------------------------------------------------------
//Use the string's IndexOf() and Substring() helper methods

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

//Output 13 36

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length)); //Output (inside the parentheses
// ------------------------------
// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// openingPosition += 1;

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length)); //Output: inside the parentheses

// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

//-------------------------------------------------------------------------------------
// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length)); //Output: set of parentheses

//-------------------------------------------------------------------------------------

// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     // Note the overload of the Substring to return only the remaining 
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1);
// } //Output: What if more than set of parentheses

//--------------------------------------------------------------------------------------

//Work with different types of symbol sets

// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 6;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition: {message.Substring(openingPosition)}");
// Output: 
// Searching THIS message: Help (find) the {opening symbols}
// Found WITHOUT using startPosition: (find) the {opening symbols}
// Found WITH using startPosition 6: {opening symbols}

// using System.Runtime.CompilerServices;

//----------------------------------------------------------------------------

//string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

// char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     // Now  find the matching closing symbol
//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     // To find the closingPosition, use an overload of the IndexOf method to specify 
//     // that the search for the matchingSymbol should start at the openingPosition in the string. 

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     // Finally, use the techniques you've already learned to display the sub-string:

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }

//closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//Output: 
// What if
// different symbols
// open symbol
// matching closing symbol

//----------------------------------------------------------------------------------

//Use the Remove() method

// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);
//Output: 123455000  3

//Use the Replace() method

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

// Output: This is example data

//----------------------------------------------------------------------------------

//Create your first method

// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();

// void DisplayRandomNumbers() 
// {
//     Random random = new Random();

//     for (int i = 0; i < 5; i++) 
//     {
//         Console.Write($"{random.Next(1, 100)} ");
//     }

//     Console.WriteLine();
// }

//------------------------------------------------------------------------------------

//using System;

// int[] times = {800, 1200, 1600, 2000};
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");
// DisplayTimes();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjjustTimes();
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");
// DisplayTimes();

// void DisplayTimes()
// {
//     /* Format and display medicine times */
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }

//     Console.WriteLine();
// } 

// void AdjjustTimes()
// {
//     //Adjust the times by additing the difference, keeping the value within 24 hours 
//     for (int i = 0; i < times.Length; i++)
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }

