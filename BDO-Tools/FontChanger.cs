using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDO_Tools
{
    public partial class FontChanger : MetroForm
    {
        public FontChanger()
        {
            InitializeComponent();
            TxtFontPath.Text = "C:/..";
            TxtGamePath.Text = "C:/..";

        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void BtnSelectFont_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Select the font you want to use",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "ttf",
                Filter = "TTF files (*.ttf)|*.ttf",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtFontPath.Text = openFileDialog1.FileName;
            }
        }

        private void BtnSelectGameFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    if (fbd.SelectedPath.Contains("BlackDesert"))
                    {
                        TxtGamePath.Text = fbd.SelectedPath;


                    }
                    else
                    {
                        this.Alert("[ERROR] Path is incorrect!", Form_Alert.enmType.Error);
                        MessageBox.Show("The selected folder doesn't seem to be the proper one, could you double check please?\nMust contains keyword 'BlackDesert' inside path.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
            }
        }

        private void BtnPatch_Click(object sender, EventArgs e)
        {
            if(TxtGamePath.Text.Contains("BlackDesert")&&TxtFontPath.Text.Contains("pearl.ttf") == false)
            {
                this.Alert("[ERROR] Path cannot be empty!", Form_Alert.enmType.Error);

            }
            string sourceFile = TxtFontPath.Text;
            string destinationFile = TxtGamePath.Text + "\\prestringtable\\font\\pearl.ttf";
            string dir = TxtGamePath.Text + "\\prestringtable\\font\\";
            if (TxtGamePath.Text.Contains("BlackDesert") == true)
            {
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                try
                {
                    File.Copy(sourceFile, destinationFile, true);
                    this.Alert("[OK] Font succesfully patched!", Form_Alert.enmType.Success);

                }
                catch (IOException iox)
                {
                    //this.Alert("[ERROR] "+iox.Message, Form_Alert.enmType.Error);

                    //MessageBox.Show(iox.Message);
                }

            }
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            try
            {
                File.Copy(sourceFile, destinationFile, true);
                
            }
            catch (IOException iox)
            {
                //this.Alert("[ERROR] "+iox.Message, Form_Alert.enmType.Error);

              // MessageBox.Show(iox.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Panel Panel = new Panel();
            this.Hide();
            Panel.Show();
        }
    }
}