using Generics;

Person person1 = new Person("John", "Doe", "21");
Person person2 = new Person("Jane", "Doe", "22");

Swap(ref person1, ref person2);

Console.WriteLine(person1.FirstName);
Console.WriteLine(person2.FirstName);

void Swap<T>(ref T person1, ref T person2)
{ 
    T temp = person1;
    person1 = person2;
    person2 = temp;
}

