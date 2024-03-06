using Microsoft.Maui.Controls;
namespace Meetify
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            // Get the values from the entry controls
            string idT = IdEntry.Text;
            string password = PasswordEntry.Text;

            // Call your login function with the entry values as input
            if (int.TryParse(idT, out int id))
            {
                // Call your login function with the parsed integer ID and password
                DB_Intercept(id, password);
            }
        }

        public void DB_Intercept(int id, string password)
        {
            Database main = new Database();
            main.set(id, password);

            Navigation.PushAsync(new Thanks());

        }
    }

}
