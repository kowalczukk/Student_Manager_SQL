using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager2
{
    class MarksStorage
    {
        public static List<cSubject> getSubjects()
        {
            List<cSubject> subjects = new List<cSubject>();
            using (StudentsDataDataContext db = new StudentsDataDataContext())
            {
                var query = from subject in db.Subjects
                            select subject;
                foreach (var q in query)
                {
                    cSubject sub = new cSubject();
                    sub.Id = q.ID;
                    sub.SubjectName = q.SubjectName;
                    subjects.Add(sub);
                }
            }
            return subjects;
        }

        public static void addMark(cMark m)
        {
            using (StudentsDataDataContext db = new StudentsDataDataContext())
            {
                Student student = db.Students.SingleOrDefault(x => x.ID == m.StudentID);
                Mark mark = new Mark
                {
                    ID = m.Id,
                    studentID = m.StudentID,
                    subjectID = m.SubjectID,
                    TeacherID = m.TeacherID,
                    number = m.Number,
                    type = m.Type
                };

                db.Marks.InsertOnSubmit(mark);
                db.SubmitChanges();
            }
        }

        public static void deleteMark(int id)
        {
            using (StudentsDataDataContext dbContext = new StudentsDataDataContext())
            {
                Mark mark = dbContext.Marks.SingleOrDefault(
                    x => x.ID == id);
                dbContext.Marks.DeleteOnSubmit(mark);
                dbContext.SubmitChanges();
            }
        }

        public static int getMaxMarkId()
        {
            int maxId = 0;            
            using (StudentsDataDataContext db = new StudentsDataDataContext())
            {
                var queryMarks = from m in db.Marks                                
                                 select m;
                List<cMark> marks = new List<cMark>();
                foreach (var z in queryMarks)
                {
                    cMark mark = new cMark();
                    mark.Id = z.ID;
                    mark.Number = z.number;
                    mark.StudentID = z.studentID;
                    mark.SubjectID = z.subjectID;
                    mark.TeacherID = z.TeacherID;
                    mark.Type = z.type;
                    marks.Add(mark);
                }
                maxId = marks.Select(x => x.Id).DefaultIfEmpty(0).Max();
            }
            return maxId;
        }
    }
}
