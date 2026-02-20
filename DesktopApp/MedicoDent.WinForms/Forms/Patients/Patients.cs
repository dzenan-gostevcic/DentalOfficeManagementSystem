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
    }
}
}
