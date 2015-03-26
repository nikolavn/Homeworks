using System;
using System.Collections.Generic;
using System.Linq;

class Tests
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        List<Worker> workers = new List<Worker>();

        Student student1 = new Student("Ivan", "Ivanov", 2); students.Add(student1);
        Student student2 = new Student("Petar", "Petrov", 3.45); students.Add(student2);
        Student student3 = new Student("Dimitar", "Dimitrov", 4.5); students.Add(student3);
        Student student4 = new Student("Yordan", "Yordanov", 5.6); students.Add(student4);
        Student student5 = new Student("Georgi", "Georgiev", 4.9); students.Add(student5);
        Student student6 = new Student("Trifon", "Trifonov", 6.2); students.Add(student6);
        Student student7 = new Student("Asen", "Asenov", 3.2); students.Add(student7);
        Student student8 = new Student("Todor", "Todorov", 4.7); students.Add(student8);
        Student student9 = new Student("Nikolay", "Nikolaev", 5.9); students.Add(student9);
        Student student10 = new Student("Simeon", "Simeonov", 2.4); students.Add(student10);

        Worker worker1 = new Worker("Ivan", "Simeonov", 234.5, 32); workers.Add(worker1);
        Worker worker2 = new Worker("Petar", "Nikolaev", 1252, 100); workers.Add(worker2);
        Worker worker3 = new Worker("Dimitar", "Todorov", 762, 37.5); workers.Add(worker3);
        Worker worker4 = new Worker("Yordan", "Asenov", 476, 23); workers.Add(worker4);
        Worker worker5 = new Worker("Georgi", "Trifonov", 612.52, 54); workers.Add(worker5);
        Worker worker6 = new Worker("Trifon", "Georgiev", 1283.62, 110); workers.Add(worker6);
        Worker worker7 = new Worker("Asen", "Yordanov", 562.12, 44.2); workers.Add(worker7);
        Worker worker8 = new Worker("Todor", "Dimitrov", 889.23, 65.4); workers.Add(worker8);
        Worker worker9 = new Worker("Nikolay", "Petrov", 283.67, 18); workers.Add(worker9);
        Worker worker10 = new Worker("Simeon", "Ivanov", 826.26, 42.7); workers.Add(worker10);

        var studentsByGrade =
            from stud in students
            orderby stud.Grade ascending
            select stud;

        var workersByWage =
            from wor in workers
            orderby wor.MoneyPerHour() descending
            select wor;

        var studentsAndWorkers = studentsByGrade.Concat<Human>(workersByWage);

        var studentsAndWorkersSorted = studentsAndWorkers.OrderBy(fn => fn.FirstName).ThenBy(ln => ln.LastName);

        foreach (var human in studentsAndWorkersSorted)
        {
            Console.WriteLine(human);
        }
    }
}
