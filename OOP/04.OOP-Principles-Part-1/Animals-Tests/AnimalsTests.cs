using System;
using System.Collections.Generic;
using System.Linq;

class AnimalsTests
{
    static void Main()
    {
        Tomcat tom = new Tomcat("tom", 12);
        Kitten kitty = new Kitten("kitty", 3);
        Cat matsa = new Cat("matsa", 8, Sex.Female);
        Frog jabcho = new Frog("jabcho", 5, Sex.Male);
        Dog sharo = new Dog("sharo", 14, Sex.Male);

        List<Animal> animals = new List<Animal>();

        animals.Add(tom);
        animals.Add(kitty);
        animals.Add(matsa);
        animals.Add(jabcho);
        animals.Add(sharo);

        foreach (var animal in animals)
        {
            animal.MakeSound();
        }

        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }

        var averageAge = animals.Average(anim => anim.Age);

        Console.WriteLine("\nAverage age of all animals is: {0} years",averageAge);
    }

    static void CalculateAverageAge(List<Animal> list)
    {
        
    }
}

