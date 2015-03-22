using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ulong FN { get; set; }
    public string Tel { get; set; }
    public string Email { get; set; }
    public List<double> Marks { get; set; }
    public int GroupNumber { get; set; }

    private string MarksAsString(List<double> marks)
    {
        string result = null;

        result = string.Join(" ", marks);

        return result;
    }

    public override string ToString()
    {
        return String.Format(
                    "\nFirst Name: {0}" +
                    "\nLast Name: {1}" +
                    "\nFN: {2}" +
                    "\nTel: {3}" +
                    "\nEmail: {4}" +
                    "\nMarks {5}" +
                    "\nGroup Number: {6}",
                    this.FirstName,
                    this.LastName,
                    this.FN,
                    this.Tel,
                    this.Email,
                    MarksAsString(this.Marks),
                    this.GroupNumber
                    );
    }
}