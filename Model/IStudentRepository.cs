using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        void AddStudent(Student st);
        void DeleteStudents(params Student[] st);
        void UpdateStudent(Student st);
        int GetNewID();
    }
}
