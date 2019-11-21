  using System;

  namespace StudentExercises
  {
      public class Exercise
      {
          // Properties
          public string Name { get; set; }
          public string Language { get; set; }

          // Constructor
          public Exercise(string name, string language)
          {
              Name = name;
              Language = language;
          }
      }
  }