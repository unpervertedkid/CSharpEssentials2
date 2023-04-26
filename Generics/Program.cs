using Library;

CollectionSamples.QueueExample();
CollectionSamples.StackExample();
CollectionSamples.Indexing();
CollectionSamples.Iterating();

string[] names = new string[2];
names[0] = "John";
names[1] = "Mary";

Console.WriteLine("Hello {0} {1}", names);

var planets = new System.Collections.ArrayList(4);
planets.AddRange(new string[] { "Mercury", "Venus", "Earth", "Mars" , "Jupiter", "Saturn", "Uranus", "Neptune" });

foreach (var planet in planets)
{
    Console.WriteLine(planet);
}
