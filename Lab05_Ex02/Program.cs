Person p = new Person();
p.name = "Rambo";
p.id = "1987";
p.income = 250000;
System.Console.WriteLine($"Type of p is {p.GetType()}");

class Person
{
    string name;
    string id;
    int income;
}