using System;
using System.Collections.Generic;

namespace School
{
	public class Student
	{
        private const double CREDITS_PER_YEAR = 24.0;

		public string Name { get; set; }
		public int StudentId { get; protected set; }
		public int NumberOfCredits { get; set; }
		public double Gpa { get; set; }

		public Student(string name, int studentId, int numberOfCredits, double gpa)
		{
			this.Name = name;
			this.StudentId = studentId;
			this.NumberOfCredits = numberOfCredits;
			this.Gpa = gpa;
		}

	    public Student(string name, int studentId) : this(name, studentId, 0, 0) {}

        public void AddGrade(int courseCredits, double grade)
        {
            double newTotalGrade = Gpa * NumberOfCredits + grade * courseCredits;

            //update the appropriate properties: NumberOfCredits, Gpa
            NumberOfCredits += courseCredits;
            Gpa = newTotalGrade / NumberOfCredits;
        }

        public static double GetCreditsPerYear()
        {
            return CREDITS_PER_YEAR;
        }

        public string GetGradeLevel()
        {
            //Determine the grade level of the student based on NumberOfCredits
            if (NumberOfCredits > CREDITS_PER_YEAR * 3)
            {
                return "Senior";
            }
            else if (NumberOfCredits > CREDITS_PER_YEAR * 2)
            {
                return "Junior";
            }
            else if (NumberOfCredits > CREDITS_PER_YEAR * 1)
            {
                return "Sophmore";
            }
            else
            {
                return "Freshman";
            }
        }

        public override String ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        public override bool Equals(object o)
        {
            bool compare = false;
            Student studentObj = o as Student;
            //return StudentId == studentObj.StudentId;

            if this.StudentId == studentObj.StudentId && this.Name == studentObj.Name)
            {
                compare = true;
            }
            return compare;

        }
    }

    class Course
    {
        public int CourseId { get; protected set; }
        public string Name { get; set; }
        public bool RequiresPrereq { get; set; }
        public decimal NumCredits { get; protected set; }
        public string Instructor { get; set; }
        public List<Student> ClassRoster { get; set; }

        public Course(int courseId, string name, bool requiresPrereq, decimal numCredits, string instructor)
        {
            this.CourseId = courseId;           //this. is not required(similar to self keyword)
            this.Name = name;
            this.RequiresPrereq = requiresPrereq;
            this.NumCredits = numCredits;
            this.Instructor = instructor;
            this.ClassRoster = null;
        }

        public Course(int courseId, string name) : this(courseId, name, false, 0, "") {}

    }

	class MainClass
    {
        public static void Main(string[] args)
        {
            Student st = new Student ("Alysson", 0);

			Student st2 = new Student("Dan", 1);

			Student st3 = new Student("Mila", 2);

			st.Gpa = 2.0;
			st3.NumberOfCredits = 18;

			Console.WriteLine(st3.StudentId);

			Console.WriteLine(st3.Name + " " + st3.StudentId);

            Course c1 = new Course(101, "CodeCamp", false, 14, "Ben Clark");
            Course c2 = new Course(201, "LiftOff");

            List<Student> roster = new List<Student>() { st2, st3 };
            c1.ClassRoster = roster;

            //foreach(Student stu in c1.ClassRoster)
            //{
            //    Console.WriteLine(stu.Name);
            //}

            //Console.WriteLine("Requires Prerequisite? " + c1.RequiresPrereq);

            //Console.WriteLine(c2.Name + " " + c2.CourseId);

            st.AddGrade(4, 4.0);
            st2.AddGrade(4, 3.7);
            st3.AddGrade(3, 3.5);

            Student st4 = st;

            Console.WriteLine(st.Name + ":" + st2.Gpa);
            Console.WriteLine(st2.GetGradeLevel());


            Console.WriteLine("Student ToString " + st);
            Console.WriteLine("Student ToString " + st.ToString());

            Console.WriteLine("1 " + st.Equals(st2));
            Console.WriteLine("2 " + st.Equals(st4));
            Console.WriteLine("3 " + st.Equals(new Student("Alysson", 0)));
        }
    }
}
