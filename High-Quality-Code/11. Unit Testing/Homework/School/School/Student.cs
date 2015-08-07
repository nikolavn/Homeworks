using System;

namespace School
{
    public class Student
    {
        private const int IdMinValue = 10000;
        private const int IDMaxValue = 99999;
        private static Random randomGenerator = new Random(); // TODO: separate ID generation in different class/inteface

        private string name;
        private readonly int id;

        public Student(string name)
        {
            this.Name = name;
            this.id = randomGenerator.Next(IdMinValue, IDMaxValue);
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Student name cannnot be null or empty!");
                }

                this.name = value;
            }
        }

        public int ID
        {
            get { return this.id; }
        }

        public override string ToString()
        {
            return this.name + " -=- " + this.ID;
        }
    }
}