using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace test
{
    /// <summary>
    /// MainScreen.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainScreen : Window
    {
        static HttpClient client = new HttpClient();
        bool on = true;
        public MainScreen()
        {
            InitializeComponent();
        }
        private void binddatagrid()
        {

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            //con.Open();
            //SqlCommand cmd = new SqlCommand();

            //cmd.CommandText = "select * from [HongikTable$] where 과목명 like N'%" + Search_Box.Text + "%'";
            //cmd.Connection = con;
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable("HongikTalbe$");
            //da.Fill(dt);
            //Data_Table.ItemsSource = dt.DefaultView;
        }

        private void Search_btn_Click(object sender, RoutedEventArgs e)
        { 
            change();
        }

        private void Search_Box_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            binddatagrid();
        }

        private void OnOff_btn_Click(object sender, RoutedEventArgs e)
        {
            if(on)
            {
                OnOff_btn.Content = "ON";
                on = false;
            }
            else
            {
                OnOff_btn.Content = "OFF";
                on = true;
            }
        }
        private void change()
        {
            string url = @"https://allcleapp.azurewebsites.net/api/UsersApi";
            url=url +"/"+ Search_Box.Text;
            var json = new WebClient().DownloadString(url);
            System.Windows.MessageBox.Show(json);
            
        }

        
    }
}
