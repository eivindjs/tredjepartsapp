using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace thirdapp
{
    public partial class FilemanagementForm : Form
    {
        private string[] msPath;
        private string[] alertPath;
        private string[] swatchPath;

        public FilemanagementForm()
        {
            InitializeComponent();
            changeVisible(false);
            btnMove.Visible = false;
            cbTypes.Items.Add("Manualsource");
            cbTypes.Items.Add("Alert");
            cbTypes.Items.Add("Swatch");
            cbTypes.Items.Add("Custom source");
            cbTypes.SelectedIndex = 0;


        }
        private void getSwatch()
        {
            if (string.IsNullOrEmpty(Setpaths.setSwatch))
            {
                swatchPath = Directory.GetFiles(@"E:\webdevelopment\BachelorOppg\bachelor2015\file\swatch");

            }
            else
            {
                swatchPath = Directory.GetFiles(@Setpaths.setSwatch);

            }
            cblFiles.Items.Clear();
            foreach (string file in swatchPath)
            {
                cblFiles.Items.Add(file);

            }
        }
        private void getAlert()
        {
            if (string.IsNullOrEmpty(Setpaths.setAlerts))
            {
                alertPath = Directory.GetFiles(@"E:\webdevelopment\BachelorOppg\bachelor2015\file\alerts");

            }
            else
            {
                alertPath = Directory.GetFiles(@Setpaths.setAlerts);

            }
            
            cblFiles.Items.Clear();
            foreach (string file in alertPath)
            {
                cblFiles.Items.Add(file);

            }
        }
        private void changeVisible(bool visible)
        {
            tbPath.Visible = visible;
            btnOk.Visible = visible;
        }
        private void getManualSource()
        {

            if (string.IsNullOrEmpty(Setpaths.setMs))
            {
                msPath = Directory.GetFiles(@"E:\webdevelopment\BachelorOppg\bachelor2015\file\manualsource");
            }
            else
            {
                msPath = Directory.GetFiles(@Setpaths.setMs);

            }
            cblFiles.Items.Clear();
            foreach (string file in msPath)
            {
                cblFiles.Items.Add(file);

            }

        }
        private void setCustomPath()
        {
            try
            {
                string[] filePaths = Directory.GetFiles(@tbPath.Text);
                cblFiles.Items.Clear();
                foreach (string file in filePaths)
                {
                    cblFiles.Items.Add(file);

                }
            }
            catch (IOException i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
            folderBrowser.ShowDialog();
            var filepath = folderBrowser.SelectedPath;
            lblSelectedPath.Text = filepath;
            btnMove.Visible = true;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            var filepath = folderBrowser.SelectedPath;
            var teller = 0;
           
            try
            {
                foreach (string file in cblFiles.CheckedItems)
                {


                    teller++;
                    string swatch = Path.GetFileName(file);
                    File.Move(file, Path.Combine(filepath, swatch));

                }

                MessageBox.Show("Flyttet: " + teller + " filer til" + filepath);
                getManualSource();
            }
            catch (IOException i)
            {
                MessageBox.Show(i.Message);
            }
        }


        private void cbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTypes.SelectedIndex)
            {
                case 0: getManualSource();
                    changeVisible(false);
                    break;
                case 1: getAlert();
                    changeVisible(false);
                    break;
                case 2: getSwatch();
                    changeVisible(false);
                    break;
                case 3:
                    changeVisible(true);
                    break;
                default:
                    break;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            setCustomPath();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmet er for å flytte filer til en annen filbane \n Laget av Eivind Skreddernes og Tommy Langhelle \n ©2015 \n Versjonsnr: 1.0.1");
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Link til hjemmesiden: http://www.basefarm.com");
        }

        private void epostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("eivind.skreddernes@gmail.com");
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SettingsForms = new SettingsForm();
            SettingsForms.Show();
        }

    }
}
