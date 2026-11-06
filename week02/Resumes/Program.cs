using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2027;
        job1._endYear = 2029;

        Job job2 = new Job();
        job2._jobTitle = "Frontend Developer";
        job2._company = "Springboard";
        job2._startYear = 2026;
        job2._endYear = 2027;


        Resume resume = new Resume();
        resume._name = "Agharese Blessing";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume._jobs[0]._jobTitle = "Software Engineer";

        resume.Display();
    }
}