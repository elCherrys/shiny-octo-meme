
using ConsoleApp2.NewFolder;
using ConsoleApp2.BI;

Dto Person = new();

Console.Write("Inresa el nombre:");
Person.Name = Console.ReadLine();

Console.Write("Ingresa tu apellido materno:");
Person.MotherLastName = Console.ReadLine();

Console.Write("Ingresa tu apellido paterno:");
Person.FatherLastName = Console.ReadLine();

Console.Write("Ingresa tu edad:");
Person.Age = Console.ReadLine();

BiPerson.CheckedData(Person);

List <string> CheckList = BiPerson.CheckedData(Person);

if (CheckList.Count == 0)
{
    Console.WriteLine("Listo!");
}
else
{
    Console.WriteLine("Lisrado de errores");
    foreach (var check in CheckList)
    {
        Console.WriteLine($"*{check}");
    }
}
Console.ReadKey();