using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_XML;
using AutoMapper;

namespace Model
{
    public class StudentRepository : IStudentRepository
    {
        public StudentRepository()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<StudentXml, Student>();
                cfg.CreateMap<Student, StudentXml>();
            });
        }
        public void AddStudent(Student st)
        {
            LinqToXmlObjectModel.InsertNewStudent(Mapper.Map<StudentXml>(st));
        }

        public void DeleteStudents(params Student[] st)
        {
            st.Select(sx => Mapper.Map<StudentXml>(sx)).ToList().ForEach(stx=>LinqToXmlObjectModel.DeleteStudent(stx));
        }

        public IEnumerable<Student> GetAll()
        {
            return LinqToXmlObjectModel.GetAll().Select(sx => Mapper.Map<Student>(sx));
        }

        public int GetNewID()
        {
            return LinqToXmlObjectModel.GetNewID();
        }

        public void UpdateStudent(Student st)
        {
           LinqToXmlObjectModel.UpdateStudent(Mapper.Map<StudentXml>(st));

        }

    }
}
