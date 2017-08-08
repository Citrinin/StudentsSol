using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using System.Windows;

namespace Model
{
    public class Student : ViewModelBase
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { Set(nameof(ID), ref id, value); }
        }

        public string FullName
        {
            get { return LastName + " " + FirstName; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                Set(nameof(FirstName), ref firstName, value);
                RaisePropertyChanged(nameof(FullName));
            }

        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set
            {
                Set(nameof(LastName), ref lastName, value);
                RaisePropertyChanged(nameof(FullName));
            }
        }


        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                Set(nameof(Age), ref age, value);
                RaisePropertyChanged(nameof(AgeFull));
            }
        }
        private char gender;

        public char Gender
        {
            get { return gender; }
            set { Set(nameof(Gender), ref gender, value); }
        }

        public string AgeFull
        {
            get { return Age + stringAge(Age); }
        }

        private static string stringAge(int lAge)
        {
            if (lAge % 10 == 1)
            {
                return " год";
            }
            else if (lAge % 10 >= 5 || lAge % 10 == 0)
            {
                return " лет";
            }
            else
            {
                return " года";
            }
        }
    }
}
