using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace StudentsMain.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        IStudentRepository SRepo;

        private ObservableCollection<Student> studentList;

        public ObservableCollection<Student> StudentList
        {
            get { return studentList; }
            set { Set(nameof(StudentList), ref studentList, value); }
        }
        List<Action> actions = new List<Action>();
        public MainViewModel(IStudentRepository SRepo)
        {
            this.SRepo = SRepo;
            this.StudentList = new ObservableCollection<Student>(SRepo.GetAll());
            AddStudentCmd = new RelayCommand(() =>
            {
                int newID = this.SRepo.GetNewID();
                AddnUpdateStudentWindow AddDlg = new AddnUpdateStudentWindow(newID);
                if (AddDlg.ShowDialog() == true)
                {
                    Student st = new Student()
                    {
                        ID = newID,
                        FirstName = AddDlg.FirstName,
                        LastName = AddDlg.LastName,
                        Age = AddDlg.Age,
                        Gender = AddDlg.Gender ? 'f' : 'm'
                    };
                    this.SRepo.AddStudent(st);
                    this.StudentList.Add(st);
                }
            });
            UpdateStudentCmd = new RelayCommand(() =>
                {
                    AddnUpdateStudentWindow AddDlg = new AddnUpdateStudentWindow(ActiveStudent);
                    if (AddDlg.ShowDialog() == true)
                    {
                        ActiveStudent.FirstName = AddDlg.FirstName;
                        ActiveStudent.LastName = AddDlg.LastName;
                        ActiveStudent.Age = AddDlg.Age;
                        ActiveStudent.Gender = AddDlg.Gender ? 'f' : 'm';
                        this.SRepo.UpdateStudent(ActiveStudent);
                    }
                },
                () => ActiveStudent != null && StudentsToDelete.Count == 1);
            SelectionChangedCommand = new RelayCommand<IList>(items =>
            {
                StudentsToDelete = new List<Student>(items.Cast<Student>());
            });

            Action DeleteStudent = () =>
              {
                  if (MessageBox.Show("Are you shure?", "Deleting stuents", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                  {
                      SRepo.DeleteStudents(StudentsToDelete.ToArray());
                      foreach (Student st in StudentsToDelete.ToArray())
                      {
                          StudentList.Remove(st);
                      }
                  }
              };
            actions.Add(DeleteStudent);
            DeleteStudentsCmd = new RelayCommand(DeleteStudent, () => ActiveStudent != null);
        }

        public RelayCommand AddStudentCmd { get; set; }
        public RelayCommand UpdateStudentCmd { get; set; }
        public RelayCommand<IList> SelectionChangedCommand { get; set; }
        public RelayCommand DeleteStudentsCmd { get; set; }


        private Student activeStudent;

        public Student ActiveStudent
        {
            get { return activeStudent; }
            set { Set(nameof(ActiveStudent), ref activeStudent, value); }
        }

        private List<Student> studentsToDelete;

        public List<Student> StudentsToDelete
        {
            get { return studentsToDelete; }
            set { Set(nameof(StudentsToDelete), ref studentsToDelete, value); }
        }


    }
}