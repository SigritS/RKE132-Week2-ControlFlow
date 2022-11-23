// See https://aka.ms/new-console-template for more information

//rakendus küsib vanust
//kui vanus kui 13 siis konsoolis kuvatakse u r too young
//muul juhul "Welcome"


Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine());

if (userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram");
}

else
{
    Console.WriteLine("You are too young to use Instagram!");
}


