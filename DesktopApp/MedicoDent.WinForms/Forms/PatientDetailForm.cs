using MedicoDent.Application.DTOs;
using MedicoDent.Application.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicoDent.WinForms.Forms
{
    public partial class PatientDetailForm : Form
    {
        private readonly PatientService _patientService;
        private readonly int? _patientId;

        public PatientDetailForm(PatientService patientService, int? patientId = null)
        {
            InitializeComponent();
            _patientService = patientService;
            _patientId = patientId;
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
                    txtPhone.Text = patient.Phone;
                    chkAllergie.Checked = patient.HasAllergie ?? false;
                    chkBlackList.Checked = patient.IsBlackListed ?? false;
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_patientId.HasValue)
            {
                // Update
                var dto = new UpdatePacijentDto
                {
                    Id = _patientId.Value,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Phone = txtPhone.Text,
                    HasAllergie = chkAllergie.Checked,
                    IsBlackListed = chkBlackList.Checked
                };
                await _patientService.UpdateAsync(dto);
            }
            else
            {
                // Create
                var dto = new CreatePacijentDto
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Phone = txtPhone.Text,
                    HasAllergie = chkAllergie.Checked,
                    IsBlackListed = chkBlackList.Checked
                };
                await _patientService.CreateAsync(dto);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
}
