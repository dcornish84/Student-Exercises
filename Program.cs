using System;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercises
            var planYourHeist = new Exercise("Plan Your Heist", "C Sharp");
            var designClassWebsite = new Exercise("Design Class Website", "UI/UX");
            var urbanPlanner = new Exercise("Urban Planner", "C Sharp");
            var dictionaryOfWords = new Exercise("Dictionary of Words", "C Sharp");

            // Cohorts
            var cohort35 = new Cohort("Cohort 35");
            var cohort36 = new Cohort("Cohort 36");
            var cohort37 = new Cohort("Cohort 37");

            // Students
            var nickWessel = new Student("Nick", "Wessel", "Nick Wessel", 35);
            var philGriswold = new Student("Phil", "Griswold", "Phil Griswold", 35);
            var heidiSpradlin = new Student("Heidi", "Spradlin", "Heidi Spradlin", 35);
            var sageKlein = new Student("Sage", "Klein", "Sage Klein", 35);

            // Instructors
            var madisonPepper = new Instructor("Madi", "Pepper", "Madi Pepper", 35, "Vacations");
            var adamSheaffer = new Instructor("Adam", "Sheaffer", "Adam Sheaffer", 35, "Ice Cream");
            var brendaLong = new Instructor("Brenda", "Long", "Brenda Long", 35, "Smiling");

            // Add Students To Cohort
            cohort35.Students.Add(nickWessel);
            cohort35.Students.Add(philGriswold);
            cohort35.Students.Add(heidiSpradlin);
            cohort35.Students.Add(sageKlein);

            // Instructors Assining Exercises
            brendaLong.assignExercise(cohort35.Students, designClassWebsite);
            adamSheaffer.assignExercise(cohort35.Students, planYourHeist);
            adamSheaffer.assignExercise(cohort35.Students, dictionaryOfWords);
            madisonPepper.assignExercise(cohort35.Students, urbanPlanner);

            // Create List Of All Exercises
            cohort35.AllExercises.AddRange(new Exercise[]
            {
                designClassWebsite,
                planYourHeist,
                dictionaryOfWords,
                urbanPlanner
            });

            // Generate Report Of Students Are Working On Each Exercise
            foreach (Exercise exercise in cohort35.AllExercises)
            {
                Console.WriteLine("");
                Console.WriteLine(exercise.Name);
                Console.WriteLine("---------------");
                foreach (Student student in cohort35.Students)
                {
                    if (student.Exercises.Contains(exercise))
                    {
                        Console.WriteLine($"{student.FirstName} {student.LastName}");
                    }
                }
            }
        }
    }
}