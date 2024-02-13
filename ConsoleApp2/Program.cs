// See https://aka.ms/new-console-template for more information

using ConsoleApp2.NewFolder;
using ConsoleApp2.BI;

Dto Person = new();

Console.Write("Inresa el nombre:");
Person.Name = Console.ReadLine();

Console.Write("Ingresa tu apellido materno");
Person.MotherLastName = Console.ReadLine();

Console.Write("Ingresa tu apellido paterno");
Person.FatherLastName = Console.ReadLine();

BiPerson.CheckedData(Person);

