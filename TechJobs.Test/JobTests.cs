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

        //initalize your testing objects here
        [TestInitialize]
        public void SetUpTestData()
        {
            job1 = new Job();

            job2 = new Job();

            job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
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
            Assert.IsTrue(jobEntry.Contains(Environment.NewLine+Environment.NewLine));
       }
        
    }
}

