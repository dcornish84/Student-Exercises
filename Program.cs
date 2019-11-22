using System;
using System.Collections.Generic;
using System.Linq;

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
            var jsArrays = new Exercise("Javascript Arrays", "Javascript");
            var jsObjects = new Exercise("Javascript Objects", "Javascript");

            // Cohorts
            var cohort35 = new Cohort("Cohort 35");
            var cohort36 = new Cohort("Cohort 36");
            var cohort37 = new Cohort("Cohort 37");

            // Students
            var nickWessel = new Student("Nick", "Wessel", "Nick Wessel", 35);
            var philGriswold = new Student("Phil", "Griswold", "Phil Griswold", 35);
            var heidiSpradlin = new Student("Heidi", "Spradlin", "Heidi Spradlin", 35);
            var sageKlein = new Student("Sage", "Klein", "Sage Klein", 35);
            var garyGoober = new Student("Gary", "Goober", "Gary Goober", 36);
            var donnyDingbat = new Student("Donny", "Dingbat", "Donny Dingbat", 37);

            // Instructors
            var madisonPepper = new Instructor("Madi", "Pepper", "Madi Pepper", 35, "Vacations");
            var adamSheaffer = new Instructor("Adam", "Sheaffer", "Adam Sheaffer", 35, "Ice Cream");
            var brendaLong = new Instructor("Brenda", "Long", "Brenda Long", 35, "Smiling");

            // Add Students To Cohort
            cohort35.Students.Add(nickWessel);
            cohort35.Students.Add(philGriswold);
            cohort35.Students.Add(heidiSpradlin);
            cohort35.Students.Add(sageKlein);
            cohort36.Students.Add(garyGoober);
            cohort37.Students.Add(donnyDingbat);

            // Instructors Assigning Exercises
            brendaLong.assignExercise(cohort35.Students, designClassWebsite);
            adamSheaffer.assignExercise(cohort35.Students, planYourHeist);
            adamSheaffer.assignExercise(cohort35.Students, dictionaryOfWords);
            madisonPepper.assignExercise(cohort35.Students, urbanPlanner);
            madisonPepper.assignExercise(cohort36.Students, jsArrays);
            brendaLong.assignExercise(cohort37.Students, jsObjects);

            /* Create a list of students. Add all of the student instances to it. */
            List<Student> StudentList = new List<Student>() {
                nickWessel,
                philGriswold,
                heidiSpradlin,
                sageKlein,
                garyGoober,
                donnyDingbat
            };


            /* Create a list of exercises. Add all of the exercise instances to it. */
            List<Exercise> ExerciseList = new List<Exercise>() {
                planYourHeist,
                designClassWebsite,
                urbanPlanner,
                dictionaryOfWords,
                jsArrays,
                jsObjects
            };


            /* Generate a report that displays which students are working on which exercises. */

            foreach (Student student in StudentList)
            {
                List<string> currentExercises = new List<string>();
                foreach (Exercise exercise in ExerciseList)
                {
                    currentExercises.Add(exercise.Name);
                };
                Console.WriteLine($"{student.FirstName} {student.LastName} is working on {String.Join(", ", currentExercises)}");
            }
            /* PART 2 */

            /* Create 4 new List instances: one to contain students, one to contain exercises, \
            one to contain instructors, and one to contain cohorts. */

            List<Student> students = new List<Student>() {
                nickWessel,
                philGriswold,
                heidiSpradlin,
                sageKlein,
                garyGoober,
                donnyDingbat
            };

            List<Exercise> exercises = new List<Exercise>() {
                planYourHeist,
                designClassWebsite,
                urbanPlanner,
                dictionaryOfWords,
                jsArrays,
                jsObjects

            };

            List<Instructor> instructors = new List<Instructor>() {
                adamSheaffer,
                madisonPepper,
                brendaLong

            };

            List<Cohort> cohorts = new List<Cohort>() {
                cohort35,
                cohort36,
                cohort37
            };

            // List exercises for the JavaScript language by using the Where() LINQ method.
            var jsExercises = (from exercise in exercises
                               where exercise.Language == "Javascript"
                               select exercise).ToList();

            Console.WriteLine("");
            Console.WriteLine("Javascript Exercises:");
            Console.WriteLine("-------");
            jsExercises.ForEach(exercise =>
            {
                Console.WriteLine(exercise.Name);
            });

            // List students in a particular cohort by using the Where() LINQ method.
            List<Student> cohort35Students = (from student in students
                                              where student.Cohort == 35
                                              select student).ToList();

            Console.WriteLine("");
            Console.WriteLine("Cohort 35 Students:");
            Console.WriteLine("-------");
            cohort35Students.ForEach(student =>
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            });

            // List instructors in a particular cohort by using the Where() LINQ method.
            List<Instructor> cohort35Instructors = (from instructor in instructors
                                                    where instructor.Cohort == 35
                                                    select instructor).ToList();

            Console.WriteLine("");
            Console.WriteLine("Cohort 35 Instructors:");
            Console.WriteLine("-------");
            cohort35Instructors.ForEach(instructor =>
            {
                Console.WriteLine($"{instructor.FirstName} {instructor.LastName}");
            });

            // Sort the students by their last name.
            List<Student> orderedLastNameStudents = students.OrderBy(student => student.LastName).ToList();

            Console.WriteLine("");
            Console.WriteLine("Students by last name:");
            Console.WriteLine("-------");
            orderedLastNameStudents.ForEach(student => Console.WriteLine($"{student.FirstName} {student.LastName}"));

            // Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
            List<Student> noStudentExercises = (from student in students
                                                where student.Exercises.Count == 0
                                                select student).ToList();

            Console.WriteLine("");
            Console.WriteLine("This student is not working on anything:");
            Console.WriteLine("-------");
            noStudentExercises.ForEach(student => Console.WriteLine($"{student.FirstName} {student.LastName}"));

            //Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
            List<Student> mostStudentExercises = (from student in students
                                                  orderby student.Exercises.Count descending
                                                  select student).ToList();

            Student mostExercises = mostStudentExercises.First();
            Console.WriteLine($"Student working on most exercises: {mostExercises.FirstName} {mostExercises.LastName}");
            Console.WriteLine("-------");

            // How many students in each cohort?
            Console.WriteLine("");
            Console.WriteLine("Students in each Cohort:");
            Console.WriteLine("-------");
            cohorts.ForEach(cohort => Console.WriteLine($"{cohort.Name} - {cohort.Students.Count}"));

        }
    }
}