using System.Data.Common;
using System.Reflection.Metadata.Ecma335;
using TechJobsOOAutoGraded6;
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
    Job job1;
    Job job2;
    Job job3;
    Job job4;
    Job job5;

        //initalize your testing objects here
        [TestInitialize]
        public void SetUpTestData()
        {
            job1 = new Job();

            job2 = new Job();

            job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            job5 = new Job("Product tester", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            string message1 = "job ID is properly set";
            string message2= "job IDs differ by 1";

            Assert.AreNotEqual(job1.Id, job2.Id, message1);

            Assert.IsTrue(job2.Id-job1.Id==1, message2 );


        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
           string Name="Product tester";
           string EmployerName= "ACME";
           string JobLocation= "Desert";
           string JobType = "Quality control";
           string JobCoreCompetency= "Persistence";

           string message= "third constructor sets all fields";
           Assert.AreEqual(Name, job3.Name, message);
           Assert.AreEqual(EmployerName, job3.EmployerName.Value, message);
           Assert.AreEqual(JobLocation, job3.EmployerLocation.Value, message);
           Assert.AreEqual(JobType, job3.JobType.Value, message);
           Assert.AreEqual(JobCoreCompetency, job3.JobCoreCompetency.Value, message);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            
            string message="Equals() method compares jobs on id only";
            Assert.IsFalse(Equals(job1.Id, job2.Id), message);
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
       {
            Job job= new Job();
            string jobEntry = job.ToString();
            Assert.IsTrue(jobEntry.StartsWith(Environment.NewLine));
            Assert.IsTrue(jobEntry.EndsWith(Environment.NewLine));
       }
        
        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
           
           string Name="Product tester";
           string EmployerName= "ACME";
           string JobLocation= "Desert";
           string JobType = "Quality control";
           string JobCoreCompetency= "Persistence";

           string expectedFormat=Environment.NewLine+"ID: "+ job3.Id + Environment.NewLine +
            "Name: " + Name + Environment.NewLine+ "Employer: " + EmployerName+ Environment.NewLine + "Location: "+ JobLocation + Environment.NewLine+ "Position Type: " + JobType + Environment.NewLine+ "Core Competency: " + JobCoreCompetency + Environment.NewLine;

           string actualFormat= job3.ToString();

           string message="string should contain a label for each field, followed by the data stored in that field";

           Assert.AreEqual(expectedFormat, actualFormat, message);

        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
           string Name="Product tester";
        //    string EmployerName= "Data not available";
           string JobLocation= "Desert";
           string JobType = "Quality control";
           string JobCoreCompetency= "Persistence";

           string expectedFormat=Environment.NewLine+"ID: "+ job5.Id + Environment.NewLine +
            "Name: "  + Name + Environment.NewLine+ "Employer: " + "Data not available" + Environment.NewLine + "Location: "+ JobLocation + Environment.NewLine+ "Position Type: " + JobType + Environment.NewLine+ "Core Competency: " + JobCoreCompetency + Environment.NewLine;

           string actualFormat= job5.ToString();

           string message="if a field is empty, the method should add, 'Data not available' after the label";

           Assert.AreEqual(expectedFormat, actualFormat, message);

        }
        
    }
}

