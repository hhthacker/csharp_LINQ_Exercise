using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LINQ_Practice.Models;
using System.Linq;

namespace LINQ_Practice
{
    [TestClass]
    public class LINQ_Practice_All
    {

        public List<Cohort> PracticeData { get; set; }
        public CohortBuilder CohortBuilder { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            CohortBuilder = new CohortBuilder();
            PracticeData = CohortBuilder.GenerateCohorts();
        }

        [TestCleanup]
        public void TearDown()
        {
            CohortBuilder = null;
            PracticeData = null;
        }

        [TestMethod]
        public void DoAllCohortsHaveTwoOrMoreJuniorInstructors()
        {
            //var doAll = PracticeData/*FILL IN LINQ EXPRESSION*/;
            var doAll = PracticeData.All(cohort => cohort.JuniorInstructors.Count() >= 2);
            Assert.IsTrue(doAll); //<-- change false to doAll
        }

        [TestMethod]
        public void DoAllCohortsFiveStudents()
        {
            //var doAll = PracticeData/*FILL IN LINQ EXPRESSION*/;
            var doAll = PracticeData.All(cohort => cohort.Students.Count() == 5);
            Assert.IsTrue(doAll); //<-- change false to doAll
        }

        [TestMethod]
        public void DoAllCohortsHavePrimaryInstructorsBornIn1980s()
        {
            //var doAll = PracticeData/*FILL IN LINQ EXPRESSION*/;
            var doAll = PracticeData.All(cohort => cohort.PrimaryInstructor.Birthday.Year < 1979 && cohort.PrimaryInstructor.Birthday.Year > 1990);
            Assert.IsFalse(doAll); //<-- change true to doAll
        }

        [TestMethod]
        public void DoAllCohortsHaveActivePrimaryInstructors()
        {
            //var doAll = PracticeData/*FILL IN LINQ EXPRESSION*/;
            var doAll = PracticeData.All(cohort => cohort.PrimaryInstructor.Active == true);
            Assert.IsTrue(doAll); //<-- change true to doAll
        }

        [TestMethod]
        public void DoAllStudentsInCohort1HaveFirstNamesThatContainTheLetterE()
        {
            //var doAll = PracticeData/*FILL IN LINQ EXPRESSION*/; //Hint: Cohort1 would be PracticeData[0]
            var doAll = PracticeData[0].Students.All(student => student.FirstName.Contains("e")); //Hint: Cohort1 would be PracticeData[0]
            Assert.IsTrue(doAll); //<-- change false to doAll
        }

        [TestMethod]
        public void DoAllActiveCohortsHavePrimaryInstructorsWithFirstNamesThatContainTheLetterA()
        {
            //var doAll = PracticeData/*FILL IN LINQ EXPRESSION*/;
            var doAll = PracticeData.All(cohort => cohort.Active == true && cohort.PrimaryInstructor.FirstName.Contains("A"));
            Assert.IsFalse(doAll); //<-- change false to doAll
        }
    }
}
