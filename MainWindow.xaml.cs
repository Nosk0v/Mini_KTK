using Mini_KTK.Model;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Mini_KTK
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                ApplicationDbContext.Connect("10.14.206.28", "5432", "user9", "&6hM#c3h", "CollegeNews");
                NpgsqlCommand command = ApplicationDbContext.GetCommand("INSERT INTO \"Role\" (\"role\") VALUES (@role)");
                command.Parameters.AddWithValue("@role", NpgsqlDbType.Varchar, "admin");
                NpgsqlDataReader result = command.ExecuteReader();
            }
            catch (Exception er)
            {
                MessageBox.Show("already exist or ERROR " + er.Message);
            }
        }
    }
}
