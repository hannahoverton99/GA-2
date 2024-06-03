using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{
        

            public int Id { get; }
            public static int nextId = 1;
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

            // TODO: Task 3: Add the two necessary constructors.

            public Job()
            {
                Id= nextId;
                nextId ++;
            }

            public Job(string name, Employer employerName, Location employerlocation, PositionType jobType, CoreCompetency jobCoreCompetency):this()
            {
                Name=name;
                EmployerName= employerName;
                EmployerLocation= employerlocation;
                JobType= jobType;
                JobCoreCompetency=jobCoreCompetency;
            }

            // TODO: Task 3: Generate Equals() and GetHashCode() methods.  
             public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

            // TODO: Task 5: Generate custom ToString() method.
                //Until you create this method, you will not be able to print a job to the console.
        public override string ToString()
        {
           string nl = Environment.NewLine;

            return nl + "ID: " + Id + nl+ 
            "Name: " + (string.IsNullOrEmpty(Name) ? "Data not available" : Name) + 
            nl+
            "Employer: " + (EmployerName==null ||string.IsNullOrEmpty(EmployerName.Value) ? "Data not available" : EmployerName.Value) +
             nl+
            "Location: " + (EmployerLocation == null || string.IsNullOrEmpty(EmployerLocation.Value) ? "Data not available" : EmployerLocation.Value) + nl +
            "Position Type: " + (JobType==null ||string.IsNullOrEmpty(JobType.Value) ? "Data not available" : JobType.Value) + 
            nl +
            "Core Competency: " + (JobCoreCompetency==null || string.IsNullOrEmpty(JobCoreCompetency.Value) ? "Data not available" : JobCoreCompetency.Value) + nl;
        }



        
    }
}

