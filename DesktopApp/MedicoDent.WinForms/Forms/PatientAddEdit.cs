using MedicoDent.Application.DTOs;
using MedicoDent.Application.Services;

namespace MedicoDent.WinForms.Forms
{
    public partial class PatientAddEdit : Form
    {
        private readonly PatientService _patientService;
        private readonly int? _patientId;
        private string _selectedMarriageStatus;
        private string _selectedOccupationStatus;
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

        public PatientAddEdit(PatientService patientService, int? patientId = null)
        {
            InitializeComponent();
            _patientService = patientService;
            _patientId = patientId;

            SetData();
        }

        private void SetData()
        {
            cmbBrak.DataSource = marriageOptions;
            cmbZan.DataSource = occupationOptions;
        }

        private async void PatientDetailForm_Load(object sender, EventArgs e)
        {
            if (_patientId.HasValue)
            {
                // Edit mode
                var patient = await _patientService.GetByIdAsync(_patientId.Value);
                if (patient != null)
                {
                    txtFirstName.Text = patient.FirstName;
                    txtLastName.Text = patient.LastName;
                    txtPhone.Text = patient.PhoneNumber;
                    chkAllergie.Checked = patient.HasAllergie;
                    chkBlackList.Checked = patient.IsBlackListed;
                    txtEmail1.Text = patient.Email;
                }
            }
        }

        private async void chkMuško_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMuško.Checked)
            {
                chkŽensko.Checked = false;
            }
        }

        private async void chkŽensko_CheckedChanged(object sender, EventArgs e)
        {
            if (chkŽensko.Checked)
            {
                chkMuško.Checked = false;
            }
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_patientId.HasValue)
            {
                // Update
                var dto = new UpdatePacijentDto
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    PhoneNumber = txtPhone.Text,
                    HasAllergie = chkAllergie.Checked,
                    IsBlackListed = chkBlackList.Checked,
                    Email = txtEmail1.Text,





                };
                await _patientService.UpdateAsync(_patientId.Value, dto);
            }
            else
            {

                // ovjde 
                string? gender = "";
                if (chkMuško.Checked)
                { gender = "Muško"; }
                else if (chkŽensko.Checked)
                { gender = "Žensko"; }

                // Create
                var dto = new CreatePacijentDto
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    PhoneNumber = txtPhone.Text,
                    HasAllergie = chkAllergie.Checked,
                    IsBlackListed = chkBlackList.Checked,
                    Email = txtEmail1.Text,
                    BirthDate = dtpBirthDate.Value,
                    Gender = gender,
                    City = txtGrad.Text,
                    StreetName = txtUlica.Text,
                    StreetNumber = txtBroUl.Text,
                    BirthPlace = txtMjestoRođenja.Text,
                    Parent = txtRodStar.Text,
                    IdNumber = txtLicna.Text,
                    IdentityValue = txtJMBG.Text,
                    HealthInsuranceNumber = txtBrojZdr.Text,
                    HealthInsuranceAdditionalNumber = txtBroDoOs.Text,
                    PostalCode = txtZip.Text,
                    Workplace = _selectedOccupationStatus,
                    MarriageStatus = _selectedMarriageStatus




                }
            ;
                await _patientService.CreateAsync(dto);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cmbBrak__SelectedValueChanged(object sender, EventArgs e)
        {
            var dropdown = (ComboBox)sender;
            _selectedMarriageStatus = (string?)dropdown.SelectedValue;
        }

        private void cmbZan_SelectedValueChanged(object sender, EventArgs e)
        {
            var dropdown = (ComboBox)sender;
            _selectedOccupationStatus = (string?)dropdown.SelectedValue;
        }

        private void chkMuško_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkMuško.Checked)
            {
                chkŽensko.Checked = false;
            }
        }

        private void chkŽensko_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkŽensko.Checked)
            {
                chkMuško.Checked = false;
            }
        }
    }
}

