
// 1
using System.ComponentModel;

if (6 >= 3)
{
    Console.WriteLine("Hello, World!");
}


// 2 and 3
Console.WriteLine("Write your name.");

string name = Console.ReadLine();

Console.WriteLine("Write your password.");

string password = Console.ReadLine();

if(name == "noname" && password == "nopass")
{
    Console.WriteLine("Welcome!");
}
else
{
    Console.WriteLine("Wrong username or password");
}

// 4
int q = 0;
while( q < 33)
{
    Console.WriteLine("Hello, World");
    q++;
}

// 5
Console.WriteLine("Write your password.");

string pass1 = Console.ReadLine();

while(pass1 != "nopass")
{

    Console.WriteLine("Wrong password");
    pass1 = Console.ReadLine();
}

// 6
int x = 0;
int z = 0;
while(x < 5)
{
    Console.WriteLine("Write a number");
    string number = Console.ReadLine();
    int.TryParse(number, out z);
    if(z > 5)
    {
        Console.WriteLine("Högre än fem");
    }
    x++;
}

// 7





Console.ReadLine();