using System;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {
        Job job_1 = new Job();
        job_1._jobTitle = "Server";
        job_1._companyName = "Saratoga Pizzaria and Grill";
        job_1._startYear = 2019;
        job_1._endYear = 2022;

        Job job_2 = new Job();
        job_2._companyName = "BYU-Idaho";
        job_2._endYear = 2024;
        job_2._jobTitle = "Support Center Specialist";
        job_2._startYear = 2022;

       Resume my_resume = new Resume();
       my_resume._name = "Cory Tillett";

       my_resume._jobs.Add(job_1);
       my_resume._jobs.Add(job_2);

       my_resume.Display();
    }
}