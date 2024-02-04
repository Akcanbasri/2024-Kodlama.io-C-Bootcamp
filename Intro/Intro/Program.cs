// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");


string messaage = "Krediler";
int term = 0;
double amounth = 12.2;

bool isAuthenticated = false;

Console.WriteLine(messaage);

if (isAuthenticated)
{
    Console.WriteLine("Hoşgeldin Basri");
}
else
{
    Console.Write("Lütfen Önce Giriş Yapın");
}

string Kredi1 = "İhtiyaç Kredisi";
string Kredi2 = "Taşıt Kreisi";
string Kredi3 = "Konut Kreisi";
string Kredi4 = "KOBİ Kredisi";
string Kredi5 = "Tarım Kredisi";

Console.WriteLine(Kredi1);
Console.WriteLine(Kredi2);
Console.WriteLine(Kredi3);
Console.WriteLine(Kredi4);
Console.WriteLine(Kredi5);

string[] krediler = { "İhtiyaç Kredisi", "Taşıt Kreisi", "Konut Kreisi", "KOBİ Kredisi", "Tarım Kredisi" };
//string[] krediler2 = new string[6];
//krediler2[0] = "İhtiyaç Kredisi";

for (int i = 0; i < krediler.Length; i++)
{
    Console.WriteLine(krediler[i]);
}

//Course course1 = new Course();
//course1.id = 1;
//course1.CourseName = "C#";
//course1.Describtion = "C# Kursu";
//course1.Price = 100;

//Course course2 = new Course();
//course2.id = 2;
//course2.CourseName = "Java";
//course2.Describtion = "java Kursu";
//course2.Price = 0;

//Course course3 = new Course();
//course3.id = 3;
//course3.CourseName = "Python";
//course3.Describtion = "Python Kursu";
//course3.Price = 200;

//Course[] courses = { course1, course2, course3 };

//for (int i = 0; i < courses.Length; i++)
//{
//    Console.WriteLine(courses[i].CourseName + " / " + courses[i].Price);
//}

Console.WriteLine("-----------------------------------------------");
CourseManager courseManager = new CourseManager();

Course [] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].CourseName + " / " + courses2[i].Price);
}