# Student-Exercises-Part1

Tracking Student Exercises: Custom Types
You are going to build a console application that tracks exercises that are assigned to students at Nashville Software School. These are the constraints and requirements for your application.

Entity Relationship Diagram
First, build an ERD based on these requirements using dbdiagram.io.

Setup
Note: Make sure that each class you define is in its own file. Also make sure each class is in the StudentExercises namespace.

mkdir -p ~/workspace/csharp/StudentExercises && cd $_
touch Student.cs Cohort.cs Instructor.cs Exercise.cs
dotnet new console
Student
You must define a type for representing a student in code. A student can only be in one cohort at a time. A student can be working on many exercises at a time.

Properties
First name
Last name
Slack handle
The student's cohort
The collection of exercises that the student is currently working on
Cohort
You must define a type for representing a cohort in code.

The cohort's name (Evening Cohort 6, Day Cohort 25, etc.)
The collection of students in the cohort.
The collection of instructors in the cohort.
Instructor
You must define a type for representing an instructor in code.

First name
Last name
Slack handle
The instructor's cohort
The instructor's specialty (e.g. jokes, snack cakes, dancing, etc.)
A method to assign an exercise to a student
Exercise
You must define a type for representing an exercise in code. An exercise can be assigned to many students.

Name of exercise
Language of exercise (JavaScript, Python, CSharp, etc.)
Objective
The learning objective of this exercise is to practice creating instances of custom types that you defined with class, establishing the relationships between them, and practicing basic data structures in C#.

Once you have defined all of your custom types, go to your Main() method in Program.cs and implement the following logic.

Create 4, or more, exercises.
Create 3, or more, cohorts.
Create 4, or more, students and assign them to one of the cohorts.
Create 3, or more, instructors and assign them to one of the cohorts.
Have each instructor assign 2 exercises to each of the students.
Challenge
Create a list of students. Add all of the student instances to it.
List<Student> students = new List<Student>();
Create a list of exercises. Add all of the exercise instances to it.
List<Exercise> exercises = new List<Exercise>();
Generate a report that displays which students are working on which exercises.
