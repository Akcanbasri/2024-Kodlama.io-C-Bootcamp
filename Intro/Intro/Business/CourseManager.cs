using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    Course[] courses = new Course[3]; 

    public CourseManager()
    {
        //constructor
        Course course1 = new Course();
        course1.id = 1;
        course1.CourseName = "C#";
        course1.Describtion = "C# Kursu";
        course1.Price = 100;

        Course course2 = new Course();
        course2.id = 2;
        course2.CourseName = "Java";
        course2.Describtion = "java Kursu";
        course2.Price = 0;

        Course course3 = new Course();
        course3.id = 3;
        course3.CourseName = "Python";
        course3.Describtion = "Python Kursu";
        course3.Price = 200;

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
    }

    public Course[] GetAll()
    {
       return courses;

    }
}
