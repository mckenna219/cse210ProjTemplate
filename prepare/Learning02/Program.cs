using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 4.2 & 4.3 Create a new job and set variables
        Job job1 = new Job();
        job1._company = "DuckDuck and Goose";
        job1._jobTitle = "Sr Accounts Liaison";
        job1._startYear = 2011;
        job1._endYear = 02019;

        // Step 4.5 Create a second job, set it's variables.
        Job job2 = new Job();
        job2._company = "Stallings Construction";
        job2._jobTitle = "Jr Accounts Liaison";
        job2._startYear = 2011;
        job2._endYear = 02019;

        // Step 4.4 Display company name and job title
        // Step 5.3 Comment out the following line
        // Console.WriteLine($"{job1._company}");

        // Step 5.3 Call the Display method
        job1.Display();
        job2.Display();
        
        // Step 4.5 Display second job's company
        // Step 5.3 Comment out the following line
        // Console.WriteLine($"{job2._company}");

        // Step 7.1 Create a Resume instance
        Resume myResume = new Resume();

        // STEP: 
        myResume._name = "McKenna Mason";

        // Step 7.2 Add the two jobs created earlier
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Step 7.3 Display the first job title
        myResume.Display();
    }
}