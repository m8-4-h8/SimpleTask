// See https://aka.ms/new-console-template for more information
//When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
//If no one likes your post, it doesn't display anything.
//If only one person likes your post, it displays: [Friend's Name] likes your post.
//If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
//If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
//Write a program and continuously ask the user to enter different names,
//until the user presses Enter (without supplying a name).
//Depending on the number of names provided, display a message based on the above pattern.

var names = new List<string>();
while (true)
{
    Console.WriteLine("Enter the name:");
    var input = Console.ReadLine();
    if (String.IsNullOrWhiteSpace(input)) { break; }
    names.Add(input);
}
var count = names.Count - 2;
if (names.Count > 2) { Console.WriteLine(names[0] + ", " + names[1] + " and " + count + " others like your post."); }
else if (names.Count > 1) { Console.WriteLine(names[0] + " and " + names[1] + " like your post."); }
else { Console.WriteLine(names[0] + " likes your post."); }
//********************************************************************************************************************
//Write a program and ask the user to enter their name. 
//Use an array to reverse the name and then store the result in a new string.
//Display the reversed name on the console.

//Console.WriteLine("Write your name:");
//var name = Console.ReadLine();
//var nameArr = new char[name.Length];
//for (int i = 0; i < name.Length; i++)
//{
//    nameArr[i] = (char)name[i];
//}
//Array.Reverse(nameArr);
//var str = new string(nameArr);
//Console.WriteLine(str);
//**********************************************************************************************************************
//Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
//If the list is empty or includes less than 5 numbers, 
//display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
//// Ask the user to supply a list of comma separated numbers
//Console.WriteLine("Please enter a list of comma separated numbers: ");
//string userInput = Console.ReadLine();

//// Convert the user input into a list of integers
//List<int> numList = new List<int>();
//try
//{
//    numList = userInput.Split(',').Select(int.Parse).ToList();
//}
//catch (FormatException)
//{
//    Console.WriteLine("Invalid input. Please make sure all inputs are integers.");
//    numList = new List<int>();
//}

//// Check if the list is empty or includes less than 5 numbers
//while (numList.Count < 5)
//{
//    Console.WriteLine("Invalid List. The list must contain at least 5 numbers.");
//    Console.WriteLine("Please re-enter a list of comma separated numbers: ");
//    userInput = Console.ReadLine();

//    // Convert the user input into a list of integers
//    try
//    {
//        numList = userInput.Split(',').Select(int.Parse).ToList();
//    }
//    catch (FormatException)
//    {
//        Console.WriteLine("Invalid input. Please make sure all inputs are integers.");
//        numList = new List<int>();
//    }
//}

//// Display the 3 smallest numbers in the list
//Console.WriteLine("The 3 smallest numbers in the list are: " + string.Join(", ", numList.OrderBy(n => n).Take(3)));
//*******************************************************************************************************************
//Write a program and ask the user to enter 5 numbers. 
//If a number has been previously entered, display an error message and ask the user to re-try. 
//Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

//int[] numbers = new int[5];
//int count = 0;

//while (count < 5)
//{
//    Console.Write($"Enter number {count + 1}: ");
//    if (int.TryParse(Console.ReadLine(), out int inputNumber))
//    {
//        if (Array.IndexOf(numbers, inputNumber) >= 0)
//        {
//            Console.WriteLine("Error: Number already entered. Please enter a different number.");
//        }
//        else
//        {
//            numbers[count] = inputNumber;
//            count++;
//        }
//    }
//    else
//    {
//        Console.WriteLine("Invalid input. Please enter a valid number.");
//    }
//}

//Array.Sort(numbers);

//Console.WriteLine("\nSorted unique numbers:");
//foreach (var num in numbers)
//{
//    Console.Write(num + " ");
//}
//********************************************************************************************************
//Write a program and ask the user to continuously enter a number or type "Quit" to exit.
//The list of numbers may include duplicates.
//Display the unique numbers that the user has entered.

//var listOfNumbers= new List<int>();
//while (true)
//{
//    var input = Console.ReadLine();
//    if (input.ToLower() == "quit")
//        break;
//    else
//        listOfNumbers.Add(Convert.ToInt32(input));
//}
//var unique = new List<int>();
//foreach (var number in listOfNumbers)
//    if(!unique.Contains(number))
//        unique.Add(number);
//foreach(var number in unique)
//Console.WriteLine(number);
//*****************************************************************************************************************************************
//Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.
//For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

//Console.WriteLine("Enter a few numbers separated by a hyphen:");
//var input = Console.ReadLine();
//var charArr = new char[input.Length / 2 + 1];
//try
//{
//    var stringArr = input.Split('-');
//    for (int i = 0; i < charArr.Length; i++)
//        charArr[i] = Convert.ToChar(stringArr[i]);
//    Console.WriteLine("Consecutive");
//}
//catch
//{
//    Console.WriteLine("Not Consecutive");
//}
//************************************************************************************************************
//Write a program and ask the user to enter a few numbers separated by a hyphen. 
//If the user simply presses Enter, without supplying an input, exit immediately; 
//otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

//Console.WriteLine("Enter a few numbers separated by a hyphen:");
//var input = Console.ReadLine();
//if(string.IsNullOrEmpty(input))
//    Environment.Exit(0);
//var charArr = new char[input.Length / 2 + 1];
//try
//{
//    var stringArr = input.Split('-');
//    for (int i = 0; i < charArr.Length; i++)
//        charArr[i] = Convert.ToChar(stringArr[i]);
//    var unique = new List<char>();
//    foreach (char c in charArr)
//        if (!unique.Contains(c))
//            unique.Add(Convert.ToChar(c));
//        else
//            Console.WriteLine("Duplicate");
//}
//catch
//{
//    Console.WriteLine("Not Consecutive");
//}
//*******************************************************************************************************************
//Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
//A valid time should be between 00:00 and 23:59.If the time is valid, display "Ok";
//otherwise, display "Invalid Time".If the user doesn't provide any values, consider it as invalid time.

//Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00):");
//var input = Console.ReadLine();
//var str = input.Split(":");
//var num1 = Convert.ToInt32(str[0]);
//var num2 = Convert.ToInt32(str[1]);
//if(num1 >= 0 && num1 <= 23 && num2 >= 0 && num2 <= 59)
//    Console.WriteLine("Ok");
//else Console.WriteLine("Invalid Time");
//*********************************************************************************************************************
//Write a program and ask the user to enter an English word. 
//Count the number of vowels (a, e, o, u, i) in the word.
//So, if the user enters "inadequate", the program should display 6 on the console.

//Console.WriteLine("Enter an English word");
//var input = Console.ReadLine();
//char[] lettersArray = input.ToCharArray();
//var counter = 0;
//foreach (var str in lettersArray)
//{
//    if (str == 'a' || str == 'e' || str == 'o' || str == 'u' || str == 'i')
//        counter++;
//}
//Console.WriteLine(counter);
//*********************************************************************************************************************
//1 - Write a program that reads a text file and displays the number of words.

//var path = @"d:\temp.txt";
//var content = File.ReadAllText(path);
//var count = 0;
//string[] words = content.Split(' ');
//foreach (string word in words)
//{
//    count++;
//}
//Console.WriteLine(count);

//2- Write a program that reads a text file and displays the longest word in the file.

//var path = @"d:\temp.txt";
//var content = File.ReadAllText(path);
//string[] words = content.Split(' ');
//string longestWord = "";
//foreach (string word in words)
//{
//    if (longestWord.Length < word.Length)
//        longestWord = word;
//}
//Console.WriteLine(longestWord);
//***********************************************************************************************************************















