using MedicoDent.Application.DTOs;
using MedicoDent.Application.Services;
using System.Web;

namespace MedicoDent.WinForms.Forms.Patients
{
    public partial class PatientDetailForms : Form
    {
        private readonly PatientService _patientService;
        private readonly int _patientId;
        private string _selectedMarriageStatus;
        private string _selectedOccupationStatus;
        private string _selectedAlarmStatus;
        List<string> marriageOptions = new List<string>
        {
                "Oženjen (udata)",
                "Neoženjen (neudata)",
                "Ostalo"
         };
        List<string> occupationOptions = new List<string>
        {
                "Zaštitar",
                "Doktor",
                "Stomatolog",
                "Lopov(Političar)"
         };
        List<string> alarmStatus = new List<string>
        {
                "Dijabetes",
                "Ostalo"

        };

        public PatientDetailForms(PatientService PatientService, int patientId)
        {
            InitializeComponent();

            _patientService = PatientService;
            _patientId = patientId;

            SetData();
        }

        private void SetData()
        {

            marriageStatusComboBox.DataSource = marriageOptions;
            occupationComboBox.DataSource = occupationOptions;
            alarmComboBox.DataSource = alarmStatus;
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var patient = await _patientService.GetByIdAsync(_patientId);

            if (patient == null)
            {
                MessageBox.Show("Patient not found.");
                Close();
                return;
            }

            txtStreetName.Text = patient?.StreetName;
            txtStreetNumber.Text = patient?.StreetNumber;
            txtZipCode.Text = patient?.PostalCode;
            txtCity.Text = patient?.City;
            txtPhoneNumber.Text = patient?.PhoneNumber;
            txtEmail.Text = patient?.Email;

            txtFirstName.Text = patient?.FirstName;
            txtLastName.Text = patient?.LastName;
            txtBirthPlace.Text = patient?.BirthPlace;
            txtParent.Text = patient?.Parent;
            txtIdCardNumber.Text = patient?.IdNumber;
            txtSocialSecurityNumber.Text = patient?.SocialSecurityNumber;
            txtHealthInsuranceNumber.Text = patient?.HealthInsuranceNumber;
            txtAdditionalHealthInsuranceNumber.Text = patient?.AdditionalHealthInsuranceNumber;
            txtAdditionalNote.Text = patient?.AdditionalNote;
            occupationComboBox.DataSource = occupationOptions;
            occupationComboBox.SelectedItem = patient?.Occupation;
            marriageStatusComboBox.DataSource = marriageOptions;
            marriageStatusComboBox.SelectedItem = patient?.MarriageStatus;
            alarmComboBox.DataSource = alarmStatus;
            alarmComboBox.SelectedItem = patient?.AlarmStatus;

            //CheckBox kontrola .isChecked = patient?.Gender;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnSaveClick(object sender, EventArgs e)
        {
            var updateDto = new UpdatePacijentDto
            {
                StreetName = txtStreetName.Text,
                StreetNumber = txtStreetNumber.Text,
                PostalCode = txtZipCode.Text,
                City = txtCity.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Email = txtEmail.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                BirthPlace = txtBirthPlace.Text,
                Parent = txtParent.Text,
                IdNumber = txtIdCardNumber.Text,
                SocialSecurityNumber = txtSocialSecurityNumber.Text,
                HealthInsuranceNumber = txtHealthInsuranceNumber.Text,
                AdditionalHealthInsuranceNumber = txtAdditionalHealthInsuranceNumber.Text,
                AdditionalNote = txtAdditionalNote.Text,
                MarriageStatus = _selectedMarriageStatus,
                Occupation = _selectedOccupationStatus,
                AlarmStatus = _selectedAlarmStatus



            };

            var result = await _patientService.UpdateAsync(_patientId, updateDto);

            if (result)
                MessageBox.Show("Kontakt uspijesno spasen!");
            else
                MessageBox.Show("Nemoguce spasiti promjene.");
        }

        private void marriageStatusComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var dropdown = (ComboBox)sender;
            _selectedMarriageStatus = (string?)dropdown.SelectedValue;
        }

        private void occupationComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var dropdown = (ComboBox)sender;
            _selectedOccupationStatus = (string?)dropdown.SelectedValue;
        }
        private void alarmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dropdown = (ComboBox)sender;
            _selectedAlarmStatus = (string?)dropdown.SelectedValue;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
