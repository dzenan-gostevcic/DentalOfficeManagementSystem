using MedicoDent.Application.Services;
using MedicoDent.Domain.Entities;
using MedicoDent.WinForms.Forms.Patients;

namespace MedicoDent.WinForms.Main
{
    public partial class MainPage : Form
    {
        private User _user;
        private readonly Func<Patients> _patientsFactory;

        public MainPage(User user, PatientService patientService, Func<Patients> patientsFactory)
        {
            InitializeComponent();
            _user = user;
            _patientsFactory = patientsFactory;
        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {
            if (_user is not null)
            {
                var form = _patientsFactory();
                form.Show();
            } 
        }
    }
}

