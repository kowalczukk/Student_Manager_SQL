using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace StudentManager2
{
    class StudentStorage
    {

        public static List<cStudent> getAllStudents()
        {
            List<cStudent> StudentsList = new List<cStudent>();
            using (StudentsDataDataContext db = new StudentsDataDataContext())
            {                
                var query = from Student in db.Students
                            orderby Student.LastName ascending, Student.FirstName ascending
                            select Student;
                foreach (var q in query)
                {
                    cStudent s = new cStudent();
                    s.Id = q.ID;
                    s.FirstName = q.FirstName;
                    s.LastName = q.LastName;
                    StudentsList.Add(s);
                }
            }
            return StudentsList;
        }

        public static cStudent getStudent(int id)
        {
            cStudent student = new cStudent();            
            using (StudentsDataDataContext db = new StudentsDataDataContext())
            {
                var query = from Student in db.Students
                            where Student.ID == id
                            select Student;
                foreach (var q in query)
                {
                    student.Id = q.ID;
                    student.FirstName = q.FirstName;
                    student.LastName = q.LastName;

                    var queryMarks = from m in db.Marks
                                     where m.studentID == q.ID
                                     select m;
                    foreach(var z in queryMarks)
                    {
                        cMark mark = new cMark();
                        mark.Id = z.ID;
                        mark.Number = z.number;
                        mark.StudentID = z.studentID;
                        mark.SubjectID = z.subjectID;
                        mark.TeacherID = z.TeacherID;
                        mark.Type = z.type;
                        student.Marks.Add(mark);
                    }                    
                }
            }
            return student;
        }

        public static void addStudent(cStudent student)
        {            
            using (StudentsDataDataContext db = new StudentsDataDataContext())
            {                              
                Student newStudent = new Student
                {
                    ID = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName
                };

                db.Students.InsertOnSubmit(newStudent);
                db.SubmitChanges();
            }

        }    
        
        public static void deleteStudent(int id)
        {
            using (StudentsDataDataContext dbContext = new StudentsDataDataContext())
            {
                foreach(Mark m in dbContext.Marks)
                {
                    if(m.studentID==id)
                    {
                        dbContext.Marks.DeleteOnSubmit(m);
                        dbContext.SubmitChanges();
                    }
                }
                Student stud = dbContext.Students.SingleOrDefault(
                    x => x.ID == id);
                dbContext.Students.DeleteOnSubmit(stud);
                dbContext.SubmitChanges();
            }
        }
        
        public static void updateStudent(int id, string firstName, string lastName)
        {
            using (StudentsDataDataContext db = new StudentsDataDataContext())
            {
                Student student = db.Students.SingleOrDefault(x => x.ID == id);
                student.FirstName = firstName;
                student.LastName = lastName;

                db.SubmitChanges();
            }
        }           
    }
    
}
