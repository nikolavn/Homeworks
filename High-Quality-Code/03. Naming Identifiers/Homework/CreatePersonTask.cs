using System;

class People
{
    public enum Gender { Male, Female };

    class Person
    {
        public Gender Gender { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    
    public void CreatePerson(int age)
    {
        Person myPerson = new Person();
        myPerson.Age = age;
        
        if (age % 2 == 0)
        {
            myPerson.Name = "Gosho";
            myPerson.Gender = Gender.Male;
        }
        else
        {
            myPerson.Name = "Ginka";
            myPerson.Gender = Gender.Female;
        }
    }
}
