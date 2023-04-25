using System.Text.Json;
using Generics;

Person person1 = new Person("John", "Doe", "21");
Person person2 = new Person("Jane", "Doe", "22");

Swap(ref person1, ref person2);

Console.WriteLine(person1.FirstName);
Console.WriteLine(person2.FirstName);

string jsonPerson = @"{""FirstName"":""Peter"",""LastName"":""Doe"",""Age"":""21""}";

var person3 = JsonSerializer.Deserialize<Person>(jsonPerson);

Console.WriteLine(person3?.FirstName);

Nullable<DateTime> maybeDate = null;

Console.WriteLine(maybeDate.GetValueOrDefault());

void Swap<T>(ref T person1, ref T person2)
{ 
    T temp = person1;
    person1 = person2;
    person2 = temp;
}

