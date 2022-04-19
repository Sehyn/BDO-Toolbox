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
    public partial class TextureChanger : MetroForm
    {
        public TextureChanger()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void TextureChanger_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.GamezBD == true)
            {
                string[] files = Directory.GetFiles(@Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GamezBD\\FaceTexture", "*", SearchOption.TopDirectoryOnly);
                DataTable table = new DataTable();
                table.Columns.Add("File Name");
                for (int i = 0; i < files.Length; i++)
                {
                    FileInfo file = new FileInfo(files[i]);
                    table.Rows.Add(file.Name);

                }
                DGV_CurTextures.DataSource = table;


                string[] files2 = Directory.GetFiles(@"Face Texture", "*");
                DataTable table2 = new DataTable();
                table2.Columns.Add("File Name");
                for (int i = 0; i < files2.Length; i++)
                {
                    FileInfo file = new FileInfo(files2[i]);
                    table2.Rows.Add(file.Name);

                }
                DGV_AvailTextures.DataSource = table2;
            }
            if (Properties.Settings.Default.GamezBD == false)
            {
                string[] files = Directory.GetFiles(@Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Black Desert\\FaceTexture", "*", SearchOption.TopDirectoryOnly);
                DataTable table = new DataTable();
                table.Columns.Add("File Name");
                for (int i = 0; i < files.Length; i++)
                {
                    FileInfo file = new FileInfo(files[i]);
                    table.Rows.Add(file.Name);

                }
                DGV_CurTextures.DataSource = table;


                string[] files2 = Directory.GetFiles(@"Face Texture", "*");
                DataTable table2 = new DataTable();
                table2.Columns.Add("File Name");
                for (int i = 0; i < files2.Length; i++)
                {
                    FileInfo file = new FileInfo(files2[i]);
                    table2.Rows.Add(file.Name);

                }
                DGV_AvailTextures.DataSource = table2;
            }

            
        }

        private void DGV_CurTextures_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.GamezBD == false)
                {
                    string[] sizes = { "B", "KB", "MB", "GB", "TB" };
                    double len = new FileInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Black Desert\\FaceTexture\\" + DGV_CurTextures.SelectedCells[0].Value.ToString()).Length;
                    int order = 0;
                    while (len >= 1024 && order < sizes.Length - 1)
                    {
                        order++;
                        len = len / 1024;
                    }

                    string result = String.Format("{0:0.##} {1}", len, sizes[order]);


                    //We get the picturebox to show which file we selected in the cell (datagridview1)
                    pictureBox1.Image = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Black Desert\\FaceTexture\\" + DGV_CurTextures.SelectedCells[0].Value.ToString());
                    LblFileNameCur.Text = DGV_CurTextures.SelectedCells[0].Value.ToString();
                    //We have the full path here
                    LblPathCur.Text = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Black Desert\\FaceTexture\\" + DGV_CurTextures.SelectedCells[0].Value.ToString());
                    LblSizeCur.Text = result;

                    //Theme used doesn't update until we do that so we have to hide and show.
                    LblFileNameCur.Visible = false;
                    LblPathCur.Visible = false;
                    LblSizeCur.Visible = false;

                    LblFileNameCur.Visible = true;
                    LblPathCur.Visible = true;
                    LblSizeCur.Visible = true;
                }
                if(Properties.Settings.Default.GamezBD == true)
                {
                    string[] sizes = { "B", "KB", "MB", "GB", "TB" };
                    double len = new FileInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GamezBD\\FaceTexture\\" + DGV_CurTextures.SelectedCells[0].Value.ToString()).Length;
                    int order = 0;
                    while (len >= 1024 && order < sizes.Length - 1)
                    {
                        order++;
                        len = len / 1024;
                    }

                    string result = String.Format("{0:0.##} {1}", len, sizes[order]);


                    //We get the picturebox to show which file we selected in the cell (datagridview1)
                    pictureBox1.Image = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GamezBD\\FaceTexture\\" + DGV_CurTextures.SelectedCells[0].Value.ToString());
                    LblFileNameCur.Text = DGV_CurTextures.SelectedCells[0].Value.ToString();
                    //We have the full path here
                    LblPathCur.Text = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GamezBD\\FaceTexture\\" + DGV_CurTextures.SelectedCells[0].Value.ToString());
                    LblSizeCur.Text = result;

                    //Theme used doesn't update until we do that so we have to hide and show.
                    LblFileNameCur.Visible = false;
                    LblPathCur.Visible = false;
                    LblSizeCur.Visible = false;

                    LblFileNameCur.Visible = true;
                    LblPathCur.Visible = true;
                    LblSizeCur.Visible = true;
                }


                    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void DGV_AvailTextures_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                //button1.Enabled = true;


                string[] sizes = { "B", "KB", "MB", "GB", "TB" };
                double len = new FileInfo("Face Texture\\" + DGV_AvailTextures.SelectedCells[0].Value.ToString()).Length;
                int order = 0;
                while (len >= 1024 && order < sizes.Length - 1)
                {
                    order++;
                    len = len / 1024;
                }


                string result = String.Format("{0:0.##} {1}", len, sizes[order]);

                //We get the picturebox to show which file we selected in the cell (datagridview2)
                pictureBox2.Image = Image.FromFile("Face Texture\\" + DGV_AvailTextures.SelectedCells[0].Value.ToString());
                LblFileNameAvail.Text = DGV_AvailTextures.SelectedCells[0].Value.ToString();
                //We have the full path here
                LblPathAvail.Text = @"Face Texture\\" + DGV_AvailTextures.SelectedCells[0].Value.ToString();
                LblSizeAvail.Text = result;

                //Theme used doesn't update until we do that so we have to hide and show.
                LblFileNameAvail.Visible = false;
                LblPathAvail.Visible = false;
                LblSizeAvail.Visible = false;

                LblFileNameAvail.Visible = true;
                LblPathAvail.Visible = true;
                LblSizeAvail.Visible = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            try
            {
               

                //Get store into a string both paths before disposing them
                string Destination = LblPathCur.Text;
                string Source = LblPathAvail.Text;

                pictureBox1.Image.Dispose();
                pictureBox2.Image.Dispose();



                File.Copy(Source, Destination, true);
                if (Properties.Settings.Default.GamezBD == true)
                {
                    pictureBox1.Image = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GamezBD\\FaceTexture\\" + DGV_CurTextures.SelectedCells[0].Value.ToString());

                }
                if (Properties.Settings.Default.GamezBD == false)
                {
                    pictureBox1.Image = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Black Desert\\FaceTexture\\" + DGV_CurTextures.SelectedCells[0].Value.ToString());

                }
                this.Alert("[OK] Succesfully replaced!", Form_Alert.enmType.Success);
                



                //MessageBox.Show("Source file: " + Source + "\n->\nDestination file:" + Destination, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex2)
            {
                this.Alert("Please open an issue and specify the error!", Form_Alert.enmType.Error);

                MessageBox.Show(ex2.Message);
                

            }
        }
    }
    }
