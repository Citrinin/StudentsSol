using System.Windows;
using Model;

namespace StudentsMain
{
    /// <summary>
    /// Interaction logic for AddnUpdateStudentWindow.xaml
    /// </summary>
    public partial class AddnUpdateStudentWindow : Window
    {
        public AddnUpdateStudentWindow()
        {
            
            InitializeComponent();
            DataContext = this;
        }

        public AddnUpdateStudentWindow(int ID):this()
        {
            LabelID.Content = $"ID {ID}";
        }
        public AddnUpdateStudentWindow(Student st):this()
        {
            LabelID.Content = $"ID {st.ID}";
            FirstName = st.FirstName;
            LastName = st.LastName;
            Age = st.Age;
            Gender = st.Gender == 'f' ? true : false;
            GenderM = st.Gender == 'm' ? true : false;
        }
        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }


        public string FirstName
        {
            get { return (string)GetValue(FirstNameProperty); }
            set { SetValue(FirstNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FirstName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FirstNameProperty =
            DependencyProperty.Register("FirstName", typeof(string), typeof(AddnUpdateStudentWindow), new PropertyMetadata(null));



        public string LastName
        {
            get { return (string)GetValue(LastNameProperty); }
            set { SetValue(LastNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LastName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LastNameProperty =
            DependencyProperty.Register("LastName", typeof(string), typeof(AddnUpdateStudentWindow), new PropertyMetadata(""));



        public int Age
        {
            get { return (int)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Age.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AgeProperty =
            DependencyProperty.Register("Age", typeof(int), typeof(AddnUpdateStudentWindow), new PropertyMetadata(16));



        public bool Gender
        {
            get { return (bool)GetValue(GenderProperty); }
            set { SetValue(GenderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Gender.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GenderProperty =
            DependencyProperty.Register("Gender", typeof(bool), typeof(AddnUpdateStudentWindow), new PropertyMetadata(false));



        public bool GenderM
        {
            get { return (bool)GetValue(GenderMProperty); }
            set { SetValue(GenderMProperty, value); }
        }

        // Using a DependencyProperty as the backing store for GenderM.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GenderMProperty =
            DependencyProperty.Register("GenderM", typeof(bool), typeof(AddnUpdateStudentWindow), new PropertyMetadata(true));




    }
}

