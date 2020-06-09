using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public class Repository
    {
        private static List<StudentModel> _students = new List<StudentModel>();

        public static List<StudentModel> Students
        {
            get
            {
                return _students;
            }
        }

        public static void AddStudent(StudentModel studentModel)
        {
            _students.Add(studentModel);
        }
    }
}
