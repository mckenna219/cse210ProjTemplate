// Step 6.1 Create a new file for Resume class
// When using list - include "using System.Collections.Generic;"
using System.Collections.Generic;

// Step 6.2 Create the Resume class
public class Resume
{
    // Step 6.3 Create the member variable for the persons name
    public string _name;
    
    // Step 6.4 Create the member variable for the list of Jobs.
    // Initialize this to a new list
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: ");

        foreach (Job job in _jobs)
        {
            job.Display();
        }   
    }
}