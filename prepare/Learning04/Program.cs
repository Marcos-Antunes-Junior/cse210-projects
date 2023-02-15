using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("Marcos Antunes", "Fractions", "7.3", "10-12");
        string summary = math.GetSummary();
        string homework = math.GetHomeworkList();
        Console.WriteLine(summary);
        Console.WriteLine(homework);
        WritingAssignment writing = new WritingAssignment("Marcos Antunes", "European History", "The Causes of World War II by Mary Waters");
        string getWriting = writing.GetWritingInformation();
        string getSummary = writing.GetSummary();
        Console.WriteLine(getSummary);
        Console.WriteLine(getWriting);
    }
}