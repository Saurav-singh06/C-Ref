﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Variable


//string charName = "Saurav";
//int age;
//age = 35;
//Console.WriteLine("My name is " + charName);
//Console.WriteLine(age);
//charName = "Singh";
//Console.WriteLine(charName);

//Datatypes


// string ,char,int , double , bool

//Working with String


/*Console.WriteLine("Saurav\nSingh"); // for new line
Console.WriteLine("Saurav\"Singh");

string name = "Saurav Singh";*/

//String Method \


/*Console.WriteLine(name.Length);
Console.WriteLine(name.ToUpper());
Console.WriteLine(name.Contains("Singh"));
Console.WriteLine(name.Substring(7,2));*/


// Working with number


/*int age = 8;
age++;
Console.WriteLine(age);*/

//Math methods


/*Console.WriteLine(Math.Pow(age, 2));
Console.WriteLine(Math.Sqrt(9));
Console.WriteLine(Math.Max(68,90));
Console.WriteLine(Math.Round(3.8));*/


// Get input from user


/*Console.WriteLine("Enter your name : ");
string name_01 = Console.ReadLine();
Console.WriteLine("Hello " + name_01);*/


// Calculator

/*int num = Convert.ToInt32("45");
Console.WriteLine(num + num);

Console.WriteLine("Enter a num1: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter a num2: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(num2 + num1); */

// Building a Mad Libs Game

//string color, pluralNoun, celebrity;

//Console.WriteLine("Enter a color : ");
//color = Console.ReadLine();
//Console.WriteLine("Enter a Plural Noun : ");
//pluralNoun = Console.ReadLine();
//Console.WriteLine("Enter a celebrity : ");
//celebrity = Console.ReadLine();

//Console.WriteLine("Roses are " + color);
//Console.WriteLine(pluralNoun + "are blue");
//Console.WriteLine("I hate " + celebrity);


// Arrays

/*int[] arr = { 4, 6, 7, 14, 65, 34 };
arr[2] = 600;
Console.WriteLine(arr[2]);

string[] friend = new string[5];  // this arr hold only 5 value

*/

//method


/*static void SayHi(string name)
{
    Console.WriteLine("Hello " + name);
}*/

/*SayHi("Saurav");

Console.WriteLine(cube(5));*/


// return statements  

/*static int cube(int num)
{
    int result = num * num * num;
    return result;

}*/

// if statements

/*bool isMale = false;
bool isTall = true;

if (isMale && isTall)
{
    Console.WriteLine("you are male");
}
else
{
    Console.WriteLine("error");
}

Console.WriteLine(GetMax(3, 43));*/


/*static int GetMax(int num1, int num2)
{
    int result;
    if (num1 > num2)
    {
        result = num1;
    }
    else
    {
        result = num2;
    }
    return result;
}*/

/*Console.WriteLine("Enter num1: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Operator: ");
string op  = Console.ReadLine();

Console.WriteLine("Enter num2: ");
double num2 = Convert.ToDouble(Console.ReadLine());

if (op == "+")
{
    Console.WriteLine(num1 + num2);
}else if (op == "-")
{
    Console.WriteLine(num1 - num2);
}else if(op == "*")
{
    Console.WriteLine(num2 * num1);
}
else
{
    Console.WriteLine("Error");
}
*/

// switch

/*Console.WriteLine(GetDay(0));*/

/*static string GetDay(int dayNum)
{
    string dayName;

    switch (dayNum)
    {
        case 0:
            dayName = "Sunday";
            break;
        case 1:
            dayName = "Mon";
            break;
        case 2:
            dayName = "Tues";
            break;
        case 3:
            dayName = "Web";
            break;
        case 4:
            dayName = "Thus";
            break;
        case 5:
            dayName = "Fri";
            break;
        case 6:
            dayName = "Sat";
            break;
        default:
            dayName = "Error";
            break;
    }
    return dayName;
}*/

/*int index = 1;
while(index <= 5)
{
    Console.WriteLine(index);
    index++;
}*/

string secretWord = "Hello";
string guess = "";
int guessCount = 0;
int guessLimit = 3;
bool outOfGuesses = false;

while(guess != secretWord && !outOfGuesses)
{
    if(guessCount < guessLimit)
    {
        Console.WriteLine("Enter guess: ");
        guess = Console.ReadLine();
        guessCount++;

    }
    else
    {
        outOfGuesses = true;
    }
    
}
if (outOfGuesses)
{
    Console.WriteLine("you loss");
}
else
{
    Console.WriteLine("You Win");
}