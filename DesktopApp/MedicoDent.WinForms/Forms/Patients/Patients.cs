    using MedicoDent.Application.Filters;
    using MedicoDent.Application.Services;

    namespace MedicoDent.WinForms.Forms.Patients
    {
        public partial class Patients : Form
        {
            private readonly PatientService _patientService;
            private int _currentPage = 1;
            private int _totalPages = 1;
            private const int PageSize = 5;
        



            public Patients(PatientService patienteservice)
            {
                InitializeComponent();
                this.ActiveControl = null;
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
                    DataPropertyName = "FirstName"
                });

                dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "LastName",
                    HeaderText = "Last Name",
                    DataPropertyName = "LastName"
                });

                dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Phone",
                    HeaderText = "Phone",
                    DataPropertyName = "Phone"
                });

                dgvPatients.Columns.Add(new DataGridViewCheckBoxColumn
                {
                    Name = "HasAllergie",
                    HeaderText = "Has Allergie",
                    DataPropertyName = "HasAllergie",
                    ReadOnly= true
                });

                dgvPatients.Columns.Add(new DataGridViewCheckBoxColumn
                {
                    Name = "IsOnBlackList",
                    HeaderText = "Blacklisted",
                    DataPropertyName = "IsBlackListed",
                    ReadOnly = true
                });
            }
        private async Task LoadPage(int pageNumber)
        {
            _currentPage = pageNumber;

            var filter = new PacijentSearchFilter
            {
                Page = _currentPage,
                PageSize = PageSize,
                SearchTerm = txtSearch.Text
            };

            var result = await _patientService.SearchAsync(filter);

            dgvPatients.DataSource = result.Items;

            
            _totalPages = (int)Math.Ceiling((double)result.TotalCount / PageSize);
            if (_totalPages == 0) _totalPages = 1;

            
            cmbPages.Items.Clear();
            for (int i = 1; i <= _totalPages; i++)
            {
                cmbPages.Items.Add(i);
            }

            
            cmbPages.SelectedItem = _currentPage;

            txtPageNumber.Text = $"{_currentPage} / {_totalPages}";

            bttnPrevious.Enabled = _currentPage > 1;
            bttnNext.Enabled = _currentPage < _totalPages;
        }
        private async void cmbPages_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbPages.SelectedItem != null)
            {
                int selectedPage = (int)cmbPages.SelectedItem;
                await LoadPage(selectedPage);
            }
        }
        private async Task LoadPatientsAsync()
            {
                var filter = new PacijentSearchFilter
                {
                    SearchTerm = txtSearch.Text,
                    Page = _currentPage,
                    PageSize = PageSize,
                    
                   
                };

                var result = await _patientService.SearchAsync(filter);

                dgvPatients.DataSource = result.Items;

                _totalPages = (int)Math.Ceiling((double)result.TotalCount / PageSize);

                if (_totalPages == 0)
                    _totalPages = 1;


                txtPageNumber.Text = $"{_currentPage} / {_totalPages}";


                bttnPrevious.Enabled = _currentPage > 1;
                bttnNext.Enabled = _currentPage < _totalPages;
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

            private async void bttnPrevious_Click(object sender, EventArgs e)
            {
                if (_currentPage > 1)
                {
                    _currentPage--;
                    await LoadPatientsAsync();
                }
            }

            private async void bttnNext_Click(object sender, EventArgs e)
            {
                if (_currentPage < _totalPages)
                {
                    _currentPage++;
                    await LoadPatientsAsync();
                }
            }

            private void txtPageNumber_TextChanged(object sender, EventArgs e)
            {

            }

            private void btnAdd(object sender, EventArgs e)
            {
                var form = new PatientAddEdit(_patientService); // We'll create this form next
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _currentPage = 1; // refresh to first page
                    _ = LoadPatientsAsync();
                }
            }

            private async void btnEdit(object sender, EventArgs e)
            {
                if (dgvPatients.CurrentRow == null) return;

                var id = (int)dgvPatients.CurrentRow.Cells["Id"].Value;
                var form = new PatientAddEdit(_patientService, id); // Edit mode
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _ = LoadPatientsAsync();
                }
            }

            private async void btnClear(object sender, EventArgs e)
            {
                txtSearch.Text = string.Empty;
                _currentPage = 1;

                await LoadPatientsAsync();
            }

            private async void btnRefresh(object sender, EventArgs e)
            {
                await LoadPatientsAsync();
            }

            private void PageNumber_SelectedIndexChanged(object sender, EventArgs e)
            {
           

                int totalPages = (int)Math.Ceiling((double)_totalPages/ PageSize);
            }
        }
    }

