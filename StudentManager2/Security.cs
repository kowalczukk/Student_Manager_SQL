using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager2
{
    class Security
    {
        static public string Who = "";
        static public int StudentId;
        static public int TeacherId;

        static List<Password> passes = new List<Password>();

        public static void addPasswords()
        {
            passes.Add(new Password("student", 1, "s1", "123"));
            passes.Add(new Password("student", 2, "s2", "123"));
            passes.Add(new Password("student", 3, "s3", "123"));
            passes.Add(new Password("teacher", 1, "t1", "123"));
            passes.Add(new Password("teacher", 2, "t2", "123"));
            passes.Add(new Password("teacher", 3, "t3", "123"));
        }

        public static void Login(string username, string password)
        {
            addPasswords();
            foreach (Password p in passes)
            {
                if (username == p.Login && password == p.Pass)
                {
                    //return true;
                    Who = p.Type;
                    if (Who == "teacher")
                    {
                        TeacherId = p.Id;                        
                        break;
                    }
                    else
                    {
                        StudentId = p.Id;                        
                        break;
                    }
                }
                else
                    Who = "error";                                
            }
            //return false;

        }      
    }
}
