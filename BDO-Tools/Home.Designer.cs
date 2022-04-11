namespace BDO_Tools
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.BtnExit = new ReaLTaiizor.Controls.MetroTile();
            this.metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
            this.BtnAgree = new ReaLTaiizor.Controls.NightButton();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnExit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BtnExit.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BtnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BtnExit.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnExit.HoverTextColor = System.Drawing.Color.White;
            this.BtnExit.IsDerivedStyle = true;
            this.BtnExit.Location = new System.Drawing.Point(587, 5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnExit.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnExit.NormalTextColor = System.Drawing.Color.White;
            this.BtnExit.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BtnExit.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnExit.PressTextColor = System.Drawing.Color.White;
            this.BtnExit.Size = new System.Drawing.Size(46, 19);
            this.BtnExit.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.BtnExit.StyleManager = null;
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "X";
            this.BtnExit.ThemeAuthor = "Taiizor";
            this.BtnExit.ThemeName = "MetroDark";
            this.BtnExit.TileAlign = ReaLTaiizor.Enum.Metro.TileAlign.TopCenter;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroLabel1.IsDerivedStyle = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 94);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(610, 185);
            this.metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = resources.GetString("metroLabel1.Text");
            this.metroLabel1.ThemeAuthor = "Taiizor";
            this.metroLabel1.ThemeName = "MetroDark";
            // 
            // BtnAgree
            // 
            this.BtnAgree.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgree.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAgree.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgree.ForeColor = System.Drawing.Color.Gray;
            this.BtnAgree.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnAgree.HoverForeColor = System.Drawing.Color.White;
            this.BtnAgree.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.High;
            this.BtnAgree.Location = new System.Drawing.Point(-7, 298);
            this.BtnAgree.MinimumSize = new System.Drawing.Size(144, 48);
            this.BtnAgree.Name = "BtnAgree";
            this.BtnAgree.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnAgree.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.BtnAgree.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnAgree.PressedForeColor = System.Drawing.Color.White;
            this.BtnAgree.Radius = 20;
            this.BtnAgree.Size = new System.Drawing.Size(144, 48);
            this.BtnAgree.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.BtnAgree.TabIndex = 2;
            this.BtnAgree.Text = "Okay!";
            this.BtnAgree.Click += new System.EventHandler(this.BtnAgree_Click);
            // 
            // Home
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(638, 350);
            this.Controls.Add(this.BtnAgree);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnExit);
            this.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(11, 66, 11, 11);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.Text = "Black Desert Toolbox";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MetroTile BtnExit;
        private ReaLTaiizor.Controls.MetroLabel metroLabel1;
        private ReaLTaiizor.Controls.NightButton BtnAgree;
    }
}

