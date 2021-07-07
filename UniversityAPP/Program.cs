using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityAPP.Models;
using UniversityAPP.Managers;

namespace UniversityAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentmanager = new StudentManager();
            StudentModel[] students = studentmanager.GetStudent(63);
            TeacherManager teacherManager = new TeacherManager();
            TeacherModel[] teachers = teacherManager.GetTeacher(4);
            UniversityManager university = new UniversityManager();
            TeacherModel[] swappedteachers = university.swappedTeachersWithStudents(students, teachers);
            StudentModel[] swappesstudents = university.swappedStudentsWithTeachers(students, swappedteachers);
        }
    }
}
