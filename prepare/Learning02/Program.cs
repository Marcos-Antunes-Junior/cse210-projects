using System;

class Program
{
    static void Main(string[] args)
    {      
        Resume resume1 = new Resume();
        resume1._name = "Marcos Antunes";
        resume1.Display();
        
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        job2.Display();
    }
}


