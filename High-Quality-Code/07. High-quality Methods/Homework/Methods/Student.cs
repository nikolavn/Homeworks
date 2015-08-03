using System;

namespace Methods
{
    /// <summary>
    /// Class that represents a student
    /// </summary>
    class Student
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string otherInfo;

        /// <summary>
        /// Initializes a new instance of the Student class, with first name, last name, birthdate and additional information.
        /// </summary>
        /// <param name="firstName">First name of student</param>
        /// <param name="lastName">Last name of student</param>
        /// <param name="birthDate">Birthdate of student</param>
        /// <param name="otherInfo">String that represents additional information</param>
        public Student(string firstName, string lastName, DateTime birthDate, string otherInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.OtherInfo = otherInfo;
        }

        public string FirstName
        {
            get 
            { 
                return this.firstName; 
            }
            private set 
            { 
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name can not be null or empty.");
                }
                this.firstName = value;
            } 
        }
        
        public string LastName 
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name can not be null or empty.");
                }
                this.lastName = value;
            }  
        }
        
        public DateTime BirthDate { get; private set; }
        
        public string OtherInfo 
        {
            get
            {
                return this.otherInfo;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Info can not be null or empty.");
                }
                this.otherInfo = value;
            }  
        }

        /// <summary>
        /// Method that compares birthdates of two instances of the Students class
        /// </summary>
        /// <param name="otherStudent">Instance of the Student class</param>
        /// <returns>
        /// True if the current instance is with birthdate earlier than the second instance's, false otherwise.
        /// </returns>
        public bool IsOlderThan(Student otherStudent)
        {
            return this.BirthDate < otherStudent.BirthDate;
        }
    }
}
