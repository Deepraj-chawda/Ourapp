// See https://aka.ms/new-console-template for more information
using Ourapp;

Console.WriteLine("Hello, World!");
string name;
string password;
Console.WriteLine("enter user name : ");
name = Console.ReadLine();
Console.WriteLine("enter password");
password = Console.ReadLine();

Console.WriteLine(UserAuthentication.UserLogin(name, password));

