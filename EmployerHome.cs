using recruitment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recriument
{
    public partial class EmployerHome : Form
    {
        private int employerID;
        public EmployerHome(int employerID)
        {
            InitializeComponent();
            this.employerID = employerID;
        }

        private void addVacancy_button_Click(object sender, EventArgs e)
        {
            VacancyForm vacancyForm = new VacancyForm(employerID);
            vacancyForm.Show();
            this.Hide();
        }
    }
}
