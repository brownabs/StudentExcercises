using System;
using System.Collections.Generic;
using System.Linq;
using StudentExercisesCLI.Models;
using StudentExercisesCLI.Data;

namespace StudentExercisesCLI
{
    class Program
    {

        static void Main(string[] args)
        {

            Repository repository = new Repository();


            // Create a new variable to contain a list of Instructors and get that list from the database
            List<Instructor> instructors = repository.GetAllInstructors();

            // Does this method do what it claims to do, or does it need some work?
            PrintInstructorReport("All Instructors", instructors);

            Pause();

            // Create a new variable to contain a list of Students and get that list from the database
            List<Student> students = repository.GetAllStudents();

            // Does this method do what it claims to do, or does it need some work?
            PrintStudentReport("All Students", students);

            Pause();

            // Create a new variable to contain a list of Exercises and get that list from the database
            List<Exercise> exercises = repository.GetAllJavaScriptExercises();

            // Does this method do what it claims to do, or does it need some work?
            PrintExerciseReport("JavaScript Exercises", exercises);

            Pause();

            // Instantiate a new employee object.
            //  Note we are making the employee's DepartmentId refer to an existing department.
            //  This is important because if we use an invalid department id, we won't be able to save
            //  the new employee record to the database because of a foreign key constraint violation.
            Exercise ADONET = new Exercise
            {
                Title = "ADONET Student Exercises",
                ExerciseLanguage = "C#",
            };
            repository.AddExercise(ADONET);

            // Does this method do what it claims to do, or does it need some work?

            exercises = repository.GetAllExercises();

           PrintExerciseReport("All Exercises", exercises);

            Pause();


        }

        public static void PrintExerciseReport(string title, List<Exercise> exercises)
        {
            Console.WriteLine($"{title}");

            exercises.ForEach(ex =>
            {
                Console.WriteLine($@"
                     Exercise Name: {ex.Title}
                    "

                );
            });
        }

        public static void PrintStudentReport(string title, List<Student> students)
        {
            Console.WriteLine($"{title}");

            students.ForEach(st =>
            {
                Console.WriteLine($@"
                     Student Name: {st.FirstName} {st.LastName}
                    "

                );
            });
        }

        public static void PrintInstructorReport(string title, List<Instructor> instructors)
        {
            Console.WriteLine($"{title}");

            instructors.ForEach(ins =>
            {
                Console.WriteLine($@"
                     Instructor Name: {ins.FirstName} {ins.LastName}
                    "

                );
            });
        }

        /// <summary>
        ///  Custom function that pauses execution of the console app until the user presses a key
        /// </summary>
        /// 
        public static void Pause()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
