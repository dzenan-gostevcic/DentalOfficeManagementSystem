using MedicoDent.Application.Filters;
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

namespace MedicoDent.WinForms.Forms.Patients
{
  
    public partial class Patients : Form
    {
        private readonly PatientService _patientService;
        private int _currentPage = 1;
        private const int PageSize = 20;
        public Patients(PatientService patienteservice)
        {
            InitializeComponent();

            _patientService = patienteservice;
            dgvPatients.AutoGenerateColumns = false;
            SetupCollumns();
        }
        
        private void SetupCollumns()
        {
            dgvPatients.Columns.Clear();

            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id"
            });

            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FirstName",
                HeaderText = "First Name",
                DataPropertyName = "PatientBasicInfo.FirstName"
            });

            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LastName",
                HeaderText = "Last Name",
                DataPropertyName = "PatientBasicInfo.LastName"
            });

            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Phone",
                HeaderText = "Phone",
                DataPropertyName = "PatientContact.PhoneNumber"
            });

            dgvPatients.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "HasAllergie",
                HeaderText = "Has Allergie",
                DataPropertyName = "HasAllergie"
            });

            dgvPatients.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "IsOnBlackList",
                HeaderText = "Blacklisted",
                DataPropertyName = "IsOnBlackList"
            });
        }

        private async Task LoadPatientsAsync()
        {
            var filter = new PacijentSearchFilter
            {
                SearchTerm = txtSearch.Text,
                Page = _currentPage,
                PageSize = PageSize
            };

            var result = await _patientService.SearchAsync(filter);

            dgvPatients.DataSource = result.Items;
            txtPageNumber.Text = _currentPage.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void Patients_Load(object sender, EventArgs e)
        {
            await LoadPatientsAsync();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            _currentPage = 1;
            await LoadPatientsAsync();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatients.CurrentRow == null)
                return;

            var id = (int)dgvPatients.CurrentRow.Cells["Id"].Value;

            var confirm = MessageBox.Show(
                "Izbriši ovog pacijenta?",
                "Potvrdi",
                MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                await _patientService.DeleteAsync(id);
                await LoadPatientsAsync();
            }
        }

        private async void  bttnPrevious_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                await LoadPatientsAsync();
            }
        }

        private async void bttnNext_Click(object sender, EventArgs e)
        {
            _currentPage++;
            await LoadPatientsAsync();
        }
    }
}

