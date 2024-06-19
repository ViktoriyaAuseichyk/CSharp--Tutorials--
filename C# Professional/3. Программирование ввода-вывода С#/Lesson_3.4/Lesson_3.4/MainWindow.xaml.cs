using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.IO.IsolatedStorage;
using System.Diagnostics.Eventing.Reader;

namespace Lesson_3._4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
        }

        IsolatedStorageFile userStorage;
        IsolatedStorageFileStream userStream;
        StreamWriter userWriter;
        StreamReader userReader;

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveInfoToIsolatedStorage();
        }

        private void OnLoad(object sender, RoutedEventArgs e)
        {
            LoadLoginAndPasswordOfUser();
        }

        private void SaveInfoToIsolatedStorage()
        {
            try
            {
                if (Login.Text.Length != 0 && Password.Text.Length != 0)
                {
                    userWriter = new StreamWriter(userStream);
                    userWriter.WriteLine(Login.Text);
                    userWriter.WriteLine(Password.Text);
                    userStream.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error. One of the two fields is empty. {ex.Message}");
            }
                
        }

        private void LoadLoginAndPasswordOfUser()
        {
            userStorage = IsolatedStorageFile.GetUserStoreForAssembly();
            userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Create, userStorage);
            string[] files = userStorage.GetFileNames("UserSettings.set");

            if (files.Length != 0)
            {
                userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Open, userStorage);
                userReader = new StreamReader(userStream);
                Login.Text = userReader.ReadLine();
                Password.Text = userReader.ReadLine();
                userStream.Close();
            }
            else
            {
                ;
            }
        }

        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}