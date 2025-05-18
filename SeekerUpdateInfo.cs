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
    public partial class SeekerUpdateInfo : Form
    {
        private int currentID;
        public SeekerUpdateInfo(int currentID)
        {
            InitializeComponent();
            this.currentID = currentID;
        }

        private void done_button_Click(object sender, EventArgs e)
        {
            SeekerHome seekerHome = new SeekerHome(currentID);
            seekerHome.Show();
            this.Hide();
        }
    }
}
