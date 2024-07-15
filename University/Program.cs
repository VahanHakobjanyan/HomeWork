using University.Interfaces;

namespace University
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University university = new University("Uni", 1986, 10, 10000);

            StudentEnrollModel form1 = new StudentEnrollModel("Vahan", "Hakobjanyan", 19, "vhak1998");
            StudentEnrollModel form2 = new StudentEnrollModel("Erik", "Mkrtchyan", 17, "Emkrtch2007");
            StudentEnrollModel form3 = new StudentEnrollModel("John", "Doe", 15, "hfsjwikfhsdr");

            university.PrintBudget();
            university.EnrollStudent(form1);
            university.EnrollStudent(form2);
            university.EnrollStudent(form3);

            university.AddSeats(6);

            university.PrintAllStudents();
            university.PrintBudget();
        }
    }
}
