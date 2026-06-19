using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Security.Cryptography;

namespace UserManagement.Client;


public partial class MainWindow : Window
{
    private static readonly HttpClient client = new HttpClient();
    public MainWindow()
    {
        InitializeComponent();
    }

    
    private async void LoadUsersBTN_Click(object sender, RoutedEventArgs e)
    {
        
        string jsonText = await client.GetStringAsync("http://localhost:5190/api/users");
        MessageBox.Show(jsonText,"Сырой ответ сервера");
        var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
        List<User> users = JsonSerializer.Deserialize<List<User>>(jsonText, options)!;
        UsersGrid.ItemsSource = users;

    }
   
    public class User
    {
        public int Id {get; set;}
        public string? Name {get; set;}
        public string? Login {get; set;}
        public string? Password {get; set;}


    }
}