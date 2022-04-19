using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Metro;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace BDO_Tools
{


    public partial class Panel : MetroForm
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void BtnDonate_Click(object sender, EventArgs e)
        {
            CrownMessageBox.ShowInformation("Thank you for being grateful I appreciate!\nIf you wish to support me money wise I accept PayPal donations at:\n\nhoeleefuccbdo@gmail.com\n\nI also accept crypto donations:\n\nTRX: TLHzSo5u7g4DoGCxT8ZnyrGFGkhP9KAft9\n\nIt has been copied to your clipboard :) ", "Thanks!");
            Clipboard.SetText("TLHzSo5u7g4DoGCxT8ZnyrGFGkhP9KAft9");
        }

        private void BtnFaceTextures_Click(object sender, EventArgs e)
        {
            TextureChanger textureChanger = new TextureChanger();
            this.Hide();
            textureChanger.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnFontChanger_Click(object sender, EventArgs e)
        {
            FontChanger fontchanger = new FontChanger();
            this.Hide();
            fontchanger.Show();
        }

        private void Chk_GameZBD_CheckedChanged(object sender)
        {
            if(Chk_GamezBD.Checked == true)
            {
                Properties.Settings.Default.GamezBD = true;
            }
            if(Chk_GamezBD.Checked == false)
            {
                Properties.Settings.Default.GamezBD = false;
            }
        }
    }
}
