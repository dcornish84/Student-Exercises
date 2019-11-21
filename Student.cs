using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SlackHandle { get; set; }

        public int Cohort { get; set; }

        public List<Exercise> Exercises = new List<Exercise>();

        // Constructor
        public Student(string firstName, string lastName, string slackHandle, int cohort)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
        }
    }
}