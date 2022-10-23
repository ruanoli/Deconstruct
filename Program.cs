using Deconstruct.Models;

Person p1 = new Person("Ruan", "Oliveira");

//Desconstruindo
(string name, string lastName) = p1;

Console.WriteLine($"{name} {lastName}");