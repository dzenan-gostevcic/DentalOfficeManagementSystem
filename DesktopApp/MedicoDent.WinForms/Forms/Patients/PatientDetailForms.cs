using MedicoDent.Application.DTOs;
using MedicoDent.Application.DTOs.Allergie;
using MedicoDent.Application.Services;

namespace MedicoDent.WinForms.Forms.Patients
{
    public partial class PatientDetailForms : Form
    {
        private readonly PatientService _patientService;
        private readonly AllergieService _allergieService;
        private readonly int _patientId;
        private string? _selectedMarriageStatus;
        private string? _selectedOccupationStatus;
        private string? _selectedGroupStatus;
        private List<int> _selectedAllergyIds = new();
        private Dictionary<int, string?> _allergyNotes = new();

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


        List<string> groupOptions = new List<string>
        {
                "Privatno",
                "Javno",
                "Ostalo"
        };

        public PatientDetailForms(PatientService patientService, AllergieService allergieService, int patientId)
        {
            InitializeComponent();

            _patientService = patientService;
            _patientId = patientId;
            _allergieService = allergieService;
            SetData();
        }

        private async Task GetAllegies()
        {
            var allergies = await _allergieService.GetAllergies();

            alarmComboBox.DataSource = allergies;
            alarmComboBox.DisplayMember = "Name";
            alarmComboBox.ValueMember = "Id";
        }

        private void SetData()
        {
            marriageStatusComboBox.DataSource = marriageOptions;
            occupationComboBox.DataSource = occupationOptions;
            GroupComboBox.DataSource = groupOptions;
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            await GetAndPatchPatientAllergies();
            await GetAllegies();

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
            GroupComboBox.DataSource = groupOptions;
            GroupComboBox.SelectedItem = patient?.Group;
            BlackListCheckBox.Checked = (patient?.IsBlackListed ?? false);


            if (patient?.Gender == "Muško")
            {
                chkMusko.Checked = true;
                chkZensko.Checked = false;
            }
            else if (patient?.Gender == "Žensko")
            {
                chkZensko.Checked = true;
                chkMusko.Checked = false;
            }
        }

        private async Task GetAndPatchPatientAllergies()
        {
            var allergies = await _allergieService.GetAllergiesByPatientId(_patientId);

            _selectedAllergyIds.Clear();
            _allergyNotes.Clear();
            allergiesListBox.Items.Clear();

            foreach (var allergy in allergies)
            {
                _selectedAllergyIds.Add(allergy.AllergieId);
                _allergyNotes[allergy.AllergieId] = allergy.AdditionalNote;

                allergiesListBox.Items.Add(allergy.AllergieName);
            }
        }

        private async void btnSaveClick(object sender, EventArgs e)
        {
            string? gender = string.Empty;

            if (chkMusko.Checked)
            {
                gender = "Muško";
            }
            else if (chkZensko.Checked)
            {
                gender = "Žensko";
            }

            if (IsBothChecked())
            {
                MessageBox.Show("Ne mozete odabrati oboje u isto vrijeme");
                return;
            }

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
                Group = _selectedGroupStatus,
                Gender = gender,
                IsBlackListed = BlackListCheckBox.Checked,
            };

            var result = await _patientService.UpdateAsync(_patientId, updateDto);

            if (result)
            {
                if (allergiesListBox.SelectedIndex != -1)
                {
                    int allergyId = _selectedAllergyIds[allergiesListBox.SelectedIndex];

                    await _allergieService.UpdatePatientAllergyNote( _patientId,allergyId,selectedAllergieNote.Text);
                }

                MessageBox.Show("Podaci uspješno spašeni!");
            }
            else
                MessageBox.Show("Nemoguce spasiti promjene.");
        }

        private bool IsBothChecked()
        {
            if (chkMusko.Checked && chkZensko.Checked)
                return true;
            else return false;
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

        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dropdown = (ComboBox)sender;
            _selectedGroupStatus = (string?)dropdown.SelectedValue;
        }

        private void allergiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allergiesListBox.SelectedIndex == -1)
                return;

            int allergyId = _selectedAllergyIds[allergiesListBox.SelectedIndex];

            if (_allergyNotes.TryGetValue(allergyId, out var note))
            {
                selectedAllergieNote.Text = note;
            }
            else
            {
                selectedAllergieNote.Text = "";
            }
        }

        private async void btnAddAllergy_Click(object sender, EventArgs e)
        {
            var allergy = alarmComboBox.SelectedItem as AllergieDto;

            if (allergy == null)
                return;

            if (_selectedAllergyIds.Contains(allergy.Id))
            {
                MessageBox.Show("Alergija već postoji.");
                return;
            }

            _selectedAllergyIds.Add(allergy.Id);
            allergiesListBox.Items.Add(allergy.Name ?? "");

            await _allergieService.AddPatientAllergy(_patientId, allergy.Id,txtAdditionalNote.Text);

            txtAdditionalNote.Clear();
            alarmComboBox.SelectedIndex = -1;
        }

        private async void btnRemoveAllergy_Click(object sender, EventArgs e)
        {
            if (allergiesListBox.SelectedIndex == -1)
                return;

            int index = allergiesListBox.SelectedIndex;
            int allergyId = _selectedAllergyIds[index];

            _selectedAllergyIds.RemoveAt(index);
            allergiesListBox.Items.RemoveAt(index);

            await _allergieService.RemovePatientAllergy(_patientId,allergyId);

            txtAdditionalNote.Clear();
            selectedAllergieNote.Clear();
        }
    }
}
