
// Practical 1. Task1 User enters name and current age. Output also provides the user's age in 5 years time
Console.WriteLine("Please enter your name");
string name = Console.ReadLine();

Console.WriteLine("Please enter your age");
string ageInput = Console.ReadLine();
int age = int.Parse(ageInput);

int futureAge = age + 5;

Console.WriteLine($"My name is {name}, and I am {age} years old, in 5 years time I will be {futureAge} years old.");

// Task 2 Checks a users age input is valid or not, then checks if the user is a child, teenager or adult

Console.WriteLine("Please enter your age");
int ageT2 = int.Parse(Console.ReadLine());

if (ageT2 < 0 || ageT2 >= 110)
{
    Console.WriteLine("The age you have entered is invalid, please enter a valid age (between 1 and 109)");

}
else if ( ageT2 < 13)
{
    Console.WriteLine("You are a child");

}
else if (ageT2 <= 19)
{
    Console.WriteLine("You are a teenager");

}
else
{
    Console.WriteLine("You are an adult");
}


// Task 3 Asks the user to enter an integer, program checks if the integer entered is positive, negative or 0

Console.WriteLine("Please enter an integer number");
int num = int.Parse(Console.ReadLine());

if (num > 0)
{
    Console.WriteLine("The integer number entered is a positive number");
}
else if (num < 0)
{
    Console.WriteLine("The integer number entered is a negative number");
}
else if (num == 0)
{
    Console.WriteLine("The user entered 0");

}
else
{
    Console.WriteLine("The user entered an invalid input, please enter an integer number");
}


// Task 4 Asks the user to enter a calender year, checks if the year is valid, adn if it is a leap year or not

Console.WriteLine("Please enter a year to check if it is a leap year or not");
int year = int.Parse(Console.ReadLine());

if (year < 0)
{
    Console.WriteLine("The year entered is invalid");
}
else if ((year % 4 == 0 && year % 100 != 0) || (year % 100 == 0 ))
{
    Console.WriteLine($"{year} is a leap year");
}
else
{
    Console.WriteLine($"{year} is not a leap year");
}


// Task 5 Asks user to enter an integer number, program checks if the number is positive or negative

Console.WriteLine("Please enter an integer number");
int n = int.Parse(Console.ReadLine());

if ( n % 2 == 0)
{
    Console.WriteLine("The number you have entered is even");
}
else if (n % 2 == 1)
{
    Console.WriteLine("The number you have entered is odd");
}
