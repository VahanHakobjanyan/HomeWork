using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using University.Interfaces;

namespace University
{
    internal class University
    {
        private string Name { get; }
        private int FoundedAt { get; }
        private int SeatCount { get; set; }
        private decimal Budget { get; set; }

        private decimal SeatCost = 10;

        private List<Student> Students = new List<Student>();

        public University(string name, int foundedAt, int seatCount, decimal budget)
        {
            Name = name;
            FoundedAt = foundedAt;
            SeatCount = seatCount;
            Budget = budget;
        }

        public StudentEnrollOutputModel EnrollStudent(StudentEnrollModel form)
        {
            if (CheckSeatCount())
            {
                if (form.Age < 16)
                {
                    return new StudentEnrollOutputModel(false);
                }
                Students.Add(new Student(form.Name, form.Surname, form.Age, form.Ssn));
                return new StudentEnrollOutputModel(true);
            }
            return new StudentEnrollOutputModel(false);
        }

        public StudentExpellOutputModel ExpellStudent(StudentExpellModel form)
        {
            Students.Remove(Students[FindStudent(form.Ssn)]);
            return new StudentExpellOutputModel(form.Reason);
        }

        public void AddSeats(int count)
        {
            if (CheckBudget(count, SeatCost))
            {
                Budget -= SeatCost * count;
                SeatCount += count;
            }
        }

        public void PrintAllStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine($"{student.Name} {student.Surname} {student.Age} years old");
            }
        }

        public void PrintBudget()
        {
            Console.WriteLine($"Budget - {Budget}");
        }

        private bool CheckSeatCount()
        {
            if (!Students.Any())
            {
                return SeatCount > 0;
            }
            return SeatCount > Students.Count;
        }

        private bool CheckBudget(int multiplier, decimal value)
        {
            return Budget > value * multiplier;
        }

        private int FindStudent(string ssn)
        {
            int studentNumber = 0;
            for (int i = 0; i < Students.Count; i++)
            {
                if (ssn.Equals(Students[i].Ssn))
                {
                    studentNumber = i;
                    break;
                }
            }
            return studentNumber;
        }
    }
}
