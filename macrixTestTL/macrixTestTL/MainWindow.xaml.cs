using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Xml.Serialization;

namespace macrixTestTL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<User> xList { get; set; }
        //public ObservableCollection<User> xListTemp { get; set; }
        UsersList ul = new UsersList();
        UsersList deserializedList;
        FileStream myfile;
        string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Users.xml");

        public MainWindow()
        {
            InitializeComponent();
            ul.users = new List<User>();
            dataGrid.CellEditEnding += updateAge;
            if (!File.Exists(path))
            {
                myfile = File.Create(path);
                myfile.Close();
                addUsersToXML(ul);
                serializeUserList(ul);
            }
            showDataInDataGrid();        
        }
        
        void addUsersToXML(UsersList ul)
        {
            ul.users.Add(new User("tomasz", "ladowski", "a", "9", "", "43-300", "Poznan", "666", new DateTime(1994,4,5)));
            ul.users.Add(new User("mateusz", "kasprzyk", "a", "9", "", "43-300", "Poznan", "666", new DateTime(1992,3,5)));
            ul.users.Add(new User("andrzej", "ladowski","a", "9", "", "43-300", "Poznan", "666", new DateTime(1994,3,5)));
        }
        void serializeUserList(UsersList ul)
        {
            XmlSerializer ser = new XmlSerializer(typeof(UsersList));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                ser.Serialize(fs, ul);
            }
        }

        void showDataInDataGrid()
        {
            deserializedList = new UsersList();
            deserializedList.users = new List<User>();
            XmlSerializer ser = new XmlSerializer(typeof(UsersList));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                deserializedList = (UsersList)ser.Deserialize(fs);
                xList = new ObservableCollection<User>();
                foreach (var user in deserializedList.users)
                {
                    xList.Add(user);
                }
            }
           // xListTemp = new ObservableCollection<User>();
            //xListTemp = xList;
            dataGrid.ItemsSource = xList;
           // dataGrid.ItemsSource = deserializedList.users;
            //dataGrid.
        }

        private void bSave_Click(object sender, RoutedEventArgs e)
        {
            UsersList saveList = new UsersList();
            saveList.users = new List<User>();
            foreach(var user in xList)
            {
                saveList.users.Add(user);
            }
            XmlSerializer ser = new XmlSerializer(typeof(UsersList));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                ser.Serialize(fs, saveList);
            }
            MessageBox.Show("Plik został zapisany na pulpicie");
        }

        private void bCancel_Click(object sender, RoutedEventArgs e)
        {
            showDataInDataGrid();
            MessageBox.Show("Wartości przywrócone z pliku");
        }

        void updateAge(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit)
            {
                if (e.Column.Header.Equals("Birth date"))
                {
                    int index = xList.IndexOf(e.Row.Item as User);
                    if (index <= xList.Count && index >= 0)
                    {
                        xList[index].age = (DateTime.Now.Year - (e.Row.Item as User).birthDate.Year).ToString();
                        dataGrid.ItemsSource = null;
                        dataGrid.ItemsSource = xList;
                    }
                }
            }

        }
    }
}
