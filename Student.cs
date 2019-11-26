using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Student : NSSPerson
    {
        public IEnumerable<Exercise> ExerciseList { get; internal set; }

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