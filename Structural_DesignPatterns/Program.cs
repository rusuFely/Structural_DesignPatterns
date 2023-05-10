using Structural_DesignPatterns;
using System;

namespace LearningSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a CsvDataAdapter using CsvFileReader
            CsvFileReader fileReader = new CsvFileReader("courses.csv");
            CsvDataAdapter dataAdapter = new CsvDataAdapter(fileReader);

            // Create a CourseDataProxy using CsvDataAdapter
            CourseDataProxy courseData = new CourseDataProxy(dataAdapter);

            // Create a hierarchy of courses
            CourseComposite allCourses = new CourseComposite("All Courses");

            // Add individual courses to the top-level composite
            allCourses.Add(new CourseLeaf("Introduction to Computer Science"));
            allCourses.Add(new CourseLeaf("Data Structures and Algorithms"));

            // Create a composite for math courses and add them to the top-level composite
            CourseComposite mathCourses = new CourseComposite("Math Courses");
            mathCourses.Add(new CourseLeaf("Calculator"));
            mathCourses.Add(new CourseLeaf("Linear Algebra"));
            allCourses.Add(mathCourses);

            // Create a composite for language courses and add them to the top-level composite
            CourseComposite languageCourses = new CourseComposite("Language Courses");
            languageCourses.Add(new CourseLeaf("Spanish"));
            languageCourses.Add(new CourseLeaf("French"));
            allCourses.Add(languageCourses);

            // Display the hierarchy of courses
            allCourses.Display();

            Console.ReadLine();
        }
    }
}
