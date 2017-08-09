using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Windows;

namespace DAL_XML
{
    public static class LinqToXmlObjectModel
    {

        public static XDocument GetXmlStudents()
        {

            try
            {
                XDocument studentsDoc = XDocument.Load(@"Students.xml");
                //XDocument studentsDoc = XDocument.Load(@"..\..\..\DAL_XML\Students.xml");
                return studentsDoc;
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public static void InsertNewStudent(StudentXml sx)
        {
            XDocument studentDoc = GetXmlStudents();
            studentDoc.Descendants("Students").First().Add(new XElement("Student", new XAttribute("Id", sx.ID),
               new XElement("FirstName", sx.FirstName),
               new XElement("Last", sx.LastName),
               new XElement("Age", sx.Age),
               new XElement("Gender", sx.Gender == 'm' ? 0 : 1)));
            studentDoc.Save(@"Students.xml");
        }
        public static void UpdateStudent(StudentXml sx)
        {
            XDocument studentDoc = GetXmlStudents();
            XElement studentToUpdate =  studentDoc.Root.Elements().First(stf => stf.Attribute("Id").Value == sx.ID.ToString());
            studentToUpdate.SetElementValue("FirstName",sx.FirstName);
            studentToUpdate.SetElementValue("Last", sx.LastName);
            studentToUpdate.SetElementValue("Age", sx.Age);
            studentToUpdate.SetElementValue("Gender", sx.Gender == 'm' ? 0 : 1);
            studentDoc.Save(@"Students.xml");
        }
        public static IEnumerable<StudentXml> GetAll()
        {
            XDocument studentDoc = GetXmlStudents();
            return studentDoc.Root.Elements().Select((stud) =>
                new StudentXml()
                {
                    ID = int.Parse(stud.Attribute("Id").Value),
                    FirstName = stud.Element("FirstName").Value,
                    LastName = stud.Element("Last").Value,
                    Age = int.Parse(stud.Element("Age").Value),
                    Gender = int.Parse(stud.Element("Gender").Value) == 0 ? 'm' : 'f'
                }
            );
        }
        public static int GetNewID()
        {
            XDocument studentDoc = GetXmlStudents();
            return studentDoc.Root.Elements().Count() == 0 ? 0: int.Parse(studentDoc.Root.Elements().Last().Attribute("Id").Value) + 1;
        }
        public static void DeleteStudent(StudentXml studentDelete)
        {
            XDocument studentDoc = GetXmlStudents();
            studentDoc.Root.Elements().First(st => st.Attribute("Id").Value == studentDelete.ID.ToString()).Remove();
            studentDoc.Save(@"Students.xml");
        }
    }
}
