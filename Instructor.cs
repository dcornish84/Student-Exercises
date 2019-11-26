using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Instructor : NSSPerson
    {
        public string Specialty { get; set; }

        // Constructor
        public Instructor(string firstName, string lastName, string slackHandle, int cohort, string specialty)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
            Specialty = specialty;
        }

        // Methods
        public void assignExercise(List<Student> studentList, Exercise exercise)
        {
            foreach (Student student in studentList)
            {
                student.Exercises.Add(exercise);
            }
        }
    }
}