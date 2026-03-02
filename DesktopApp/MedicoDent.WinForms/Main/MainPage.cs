using MedicoDent.Application.Services;
using MedicoDent.Domain.Entities;
using MedicoDent.WinForms.Forms.Patients;

namespace MedicoDent.WinForms.Main
{
    public partial class MainPage : Form
    {
        private User _user;

        private readonly PatientService _patientService;

        public MainPage(User user, PatientService patientService)
        {
            InitializeComponent();
            _user = user;
            _patientService = patientService;
        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {
            if (_user is not null)
            {
                var form = new Patients(_patientService);
                form.Show();
            } 
        }
    }
}

