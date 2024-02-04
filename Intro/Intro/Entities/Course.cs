using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities;

public class Course
{
    public int id { get; set; }
    public string CourseName { get; set; }
    public string Describtion { get; set; }
    public double Price { get; set; }
}
