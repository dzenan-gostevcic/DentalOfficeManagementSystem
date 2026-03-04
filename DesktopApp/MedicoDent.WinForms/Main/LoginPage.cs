using MedicoDent.Application.Requests;
using MedicoDent.Application.Services;
using MedicoDent.Domain.Entities;
using MedicoDent.WinForms.Main;

namespace MedicoDent.WinForms
{
    public partial class LoginPage : Form
    {
        private readonly UserService _userService;
        private readonly Func<User, MainPage> _mainPageFactory;

        public LoginPage(UserService userService, Func<User, MainPage> mainPageFactory)
        {
            InitializeComponent();
            _userService = userService;
            _mainPageFactory = mainPageFactory;

            this.AcceptButton = LoginButton;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void LoginButton_ClickAsync(object sender, EventArgs e)
        {
            var request = new UserAuthenticationRequest()
            {
                Username = UsernameTxt.Text,
                Password = PasswordTxt.Text
            };

            var user = await _userService.Authenticate(request);

            if (user.Id != 0)
            {
                LoadPanel(user);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Neispravni korisnički podaci, pokušajte ponovno.");
            }
        }

        private void LoadPanel(User user)
        {
            if (user is not null)
            {
                var form = _mainPageFactory(user);
                form.Show();
            }
        }
    }
}

