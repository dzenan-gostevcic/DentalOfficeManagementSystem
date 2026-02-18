using MedicoDent.Application.Filters;
using MedicoDent.Application.Requests;
using MedicoDent.Application.Services;
using MedicoDent.Domain.Entities;
using MedicoDent.WinForms.Main;

namespace MedicoDent.WinForms
{
    public partial class LoginPage : Form
    {
        private readonly PatientService _patientService;
        private readonly UserService _userService;


        private int _page = 1;
        private const int PageSize = 20;

        public LoginPage(PatientService patientService, UserService userService)
        {
            InitializeComponent();
            _patientService = patientService;
            _userService = userService;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var filter = new PacijentSearchFilter
            {
                Name = "Emir",
                Page = _page,
                PageSize = PageSize
            };

            var result = await _patientService.SearchAsync(filter);

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
                var form = new MainPage(user);
                form.Show();
            }
        }
    }
}
