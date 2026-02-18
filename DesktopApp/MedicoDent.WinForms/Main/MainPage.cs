using MedicoDent.Domain.Entities;
using MedicoDent.WinForms.Forms.Patients;

namespace MedicoDent.WinForms.Main
{
    public partial class MainPage : Form
    {
        private User _user;
        public MainPage(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {
            if (_user is not null)
            {
                var form = new Patients();
                form.Show();
            }
        }
    }
}
