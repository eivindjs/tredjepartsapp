using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thirdapp
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Setpaths.setMs = tbManualsource.Text;
                Setpaths.setAlerts = tbAlerts.Text;
                Setpaths.setSwatch = tbSwatch.Text;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnBrowseMS_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            tbManualsource.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnSwatch_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            tbSwatch.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnAlert_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            tbAlerts.Text = folderBrowserDialog.SelectedPath;
        }

      
    }
}
