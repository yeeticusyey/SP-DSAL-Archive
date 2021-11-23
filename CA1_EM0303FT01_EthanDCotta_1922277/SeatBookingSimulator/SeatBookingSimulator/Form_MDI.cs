using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeatBookingSimulator
{
    public partial class Form_MDI : Form
    {
        public Form_MDI()
        {
            InitializeComponent();
        }

        private void normalModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_normalMode newMDIChild = new Form_normalMode();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void safeDistancingModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_safeDistancingMode newMDIChild = new Form_safeDistancingMode();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void smartModeSafeDistancingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_smartModeSafeDistancing newMDIChild = new Form_smartModeSafeDistancing();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }
    }
}
