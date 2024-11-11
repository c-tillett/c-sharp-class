using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment();
        assignment.SetStudentName("Samuel Bennett");
        Console.WriteLine(assignment.GetStudentName());
        assignment.SetTopic("Multiplication");
        Console.WriteLine(assignment.GetTopic());

        Console.WriteLine(assignment.GetSummary());
    }
}