using MedicoDent.Application.Services;
using MedicoDent.Domain.Entities;
using MedicoDent.WinForms.Forms.Patients;
using Microsoft.Extensions.DependencyInjection;


namespace MedicoDent.WinForms.Main
{
    public partial class MainPage : Form
    {
        private User _user;
       private readonly IServiceProvider _serviceProvider;

        public MainPage(User user, IServiceProvider serviceProvider)
        {
            
            InitializeComponent();
            _user = user;
            _serviceProvider = serviceProvider;
        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {
            if (_user is not null)
            {
                
                var form = _serviceProvider.GetRequiredService<Patients>();
                form.Show();
            }
        }
    }
    }

