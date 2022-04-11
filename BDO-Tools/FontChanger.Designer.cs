namespace BDO_Tools
{
    partial class FontChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontChanger));
            this.BtnSelectFont = new ReaLTaiizor.Controls.MetroButton();
            this.TxtFontPath = new ReaLTaiizor.Controls.MetroTextBox();
            this.BtnSelectGameFolder = new ReaLTaiizor.Controls.MetroButton();
            this.TxtGamePath = new ReaLTaiizor.Controls.MetroTextBox();
            this.BtnPatch = new ReaLTaiizor.Controls.MetroButton();
            this.BtnReturn = new ReaLTaiizor.Controls.MetroTile();
            this.BtnExit = new ReaLTaiizor.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // BtnSelectFont
            // 
            this.BtnSelectFont.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnSelectFont.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnSelectFont.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnSelectFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnSelectFont.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnSelectFont.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnSelectFont.HoverTextColor = System.Drawing.Color.White;
            this.BtnSelectFont.IsDerivedStyle = true;
            this.BtnSelectFont.Location = new System.Drawing.Point(130, 116);
            this.BtnSelectFont.Name = "BtnSelectFont";
            this.BtnSelectFont.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnSelectFont.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnSelectFont.NormalTextColor = System.Drawing.Color.White;
            this.BtnSelectFont.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnSelectFont.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnSelectFont.PressTextColor = System.Drawing.Color.White;
            this.BtnSelectFont.Size = new System.Drawing.Size(122, 27);
            this.BtnSelectFont.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.BtnSelectFont.StyleManager = null;
            this.BtnSelectFont.TabIndex = 0;
            this.BtnSelectFont.Text = "Select Font";
            this.BtnSelectFont.ThemeAuthor = "Taiizor";
            this.BtnSelectFont.ThemeName = "MetroDark";
            this.BtnSelectFont.Click += new System.EventHandler(this.BtnSelectFont_Click);
            // 
            // TxtFontPath
            // 
            this.TxtFontPath.AutoCompleteCustomSource = null;
            this.TxtFontPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtFontPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtFontPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.TxtFontPath.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.TxtFontPath.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtFontPath.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtFontPath.Enabled = false;
            this.TxtFontPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtFontPath.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.TxtFontPath.Image = null;
            this.TxtFontPath.IsDerivedStyle = true;
            this.TxtFontPath.Lines = null;
            this.TxtFontPath.Location = new System.Drawing.Point(258, 116);
            this.TxtFontPath.MaxLength = 32767;
            this.TxtFontPath.Multiline = false;
            this.TxtFontPath.Name = "TxtFontPath";
            this.TxtFontPath.ReadOnly = false;
            this.TxtFontPath.Size = new System.Drawing.Size(293, 27);
            this.TxtFontPath.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.TxtFontPath.StyleManager = null;
            this.TxtFontPath.TabIndex = 2;
            this.TxtFontPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtFontPath.ThemeAuthor = "Taiizor";
            this.TxtFontPath.ThemeName = "MetroDark";
            this.TxtFontPath.UseSystemPasswordChar = false;
            this.TxtFontPath.WatermarkText = "C:/..";
            // 
            // BtnSelectGameFolder
            // 
            this.BtnSelectGameFolder.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnSelectGameFolder.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnSelectGameFolder.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnSelectGameFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnSelectGameFolder.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnSelectGameFolder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnSelectGameFolder.HoverTextColor = System.Drawing.Color.White;
            this.BtnSelectGameFolder.IsDerivedStyle = true;
            this.BtnSelectGameFolder.Location = new System.Drawing.Point(130, 149);
            this.BtnSelectGameFolder.Name = "BtnSelectGameFolder";
            this.BtnSelectGameFolder.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnSelectGameFolder.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnSelectGameFolder.NormalTextColor = System.Drawing.Color.White;
            this.BtnSelectGameFolder.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnSelectGameFolder.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnSelectGameFolder.PressTextColor = System.Drawing.Color.White;
            this.BtnSelectGameFolder.Size = new System.Drawing.Size(122, 27);
            this.BtnSelectGameFolder.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.BtnSelectGameFolder.StyleManager = null;
            this.BtnSelectGameFolder.TabIndex = 3;
            this.BtnSelectGameFolder.Text = "Set game path";
            this.BtnSelectGameFolder.ThemeAuthor = "Taiizor";
            this.BtnSelectGameFolder.ThemeName = "MetroDark";
            this.BtnSelectGameFolder.Click += new System.EventHandler(this.BtnSelectGameFolder_Click);
            // 
            // TxtGamePath
            // 
            this.TxtGamePath.AutoCompleteCustomSource = null;
            this.TxtGamePath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtGamePath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtGamePath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.TxtGamePath.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.TxtGamePath.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtGamePath.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtGamePath.Enabled = false;
            this.TxtGamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtGamePath.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.TxtGamePath.Image = null;
            this.TxtGamePath.IsDerivedStyle = true;
            this.TxtGamePath.Lines = null;
            this.TxtGamePath.Location = new System.Drawing.Point(258, 149);
            this.TxtGamePath.MaxLength = 32767;
            this.TxtGamePath.Multiline = false;
            this.TxtGamePath.Name = "TxtGamePath";
            this.TxtGamePath.ReadOnly = false;
            this.TxtGamePath.Size = new System.Drawing.Size(293, 27);
            this.TxtGamePath.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.TxtGamePath.StyleManager = null;
            this.TxtGamePath.TabIndex = 4;
            this.TxtGamePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtGamePath.ThemeAuthor = "Taiizor";
            this.TxtGamePath.ThemeName = "MetroDark";
            this.TxtGamePath.UseSystemPasswordChar = false;
            this.TxtGamePath.WatermarkText = "C:/..";
            // 
            // BtnPatch
            // 
            this.BtnPatch.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnPatch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnPatch.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnPatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPatch.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnPatch.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnPatch.HoverTextColor = System.Drawing.Color.White;
            this.BtnPatch.IsDerivedStyle = true;
            this.BtnPatch.Location = new System.Drawing.Point(130, 182);
            this.BtnPatch.Name = "BtnPatch";
            this.BtnPatch.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnPatch.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnPatch.NormalTextColor = System.Drawing.Color.White;
            this.BtnPatch.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnPatch.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnPatch.PressTextColor = System.Drawing.Color.White;
            this.BtnPatch.Size = new System.Drawing.Size(421, 27);
            this.BtnPatch.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.BtnPatch.StyleManager = null;
            this.BtnPatch.TabIndex = 5;
            this.BtnPatch.Text = "Patch";
            this.BtnPatch.ThemeAuthor = "Taiizor";
            this.BtnPatch.ThemeName = "MetroDark";
            this.BtnPatch.Click += new System.EventHandler(this.BtnPatch_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnReturn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BtnReturn.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BtnReturn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BtnReturn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnReturn.HoverTextColor = System.Drawing.Color.White;
            this.BtnReturn.IsDerivedStyle = true;
            this.BtnReturn.Location = new System.Drawing.Point(570, 5);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnReturn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnReturn.NormalTextColor = System.Drawing.Color.White;
            this.BtnReturn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BtnReturn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnReturn.PressTextColor = System.Drawing.Color.White;
            this.BtnReturn.Size = new System.Drawing.Size(46, 19);
            this.BtnReturn.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.BtnReturn.StyleManager = null;
            this.BtnReturn.TabIndex = 7;
            this.BtnReturn.Text = "<";
            this.BtnReturn.ThemeAuthor = "Taiizor";
            this.BtnReturn.ThemeName = "MetroDark";
            this.BtnReturn.TileAlign = ReaLTaiizor.Enum.Metro.TileAlign.TopCenter;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
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
            this.BtnExit.Location = new System.Drawing.Point(622, 5);
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
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "X";
            this.BtnExit.ThemeAuthor = "Taiizor";
            this.BtnExit.ThemeName = "MetroDark";
            this.BtnExit.TileAlign = ReaLTaiizor.Enum.Metro.TileAlign.TopCenter;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FontChanger
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(683, 270);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnPatch);
            this.Controls.Add(this.TxtGamePath);
            this.Controls.Add(this.BtnSelectGameFolder);
            this.Controls.Add(this.TxtFontPath);
            this.Controls.Add(this.BtnSelectFont);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FontChanger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.Text = "Black Desert Toolbox - Font Changer";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MetroButton BtnSelectFont;
        private ReaLTaiizor.Controls.MetroTextBox TxtFontPath;
        private ReaLTaiizor.Controls.MetroButton BtnSelectGameFolder;
        private ReaLTaiizor.Controls.MetroTextBox TxtGamePath;
        private ReaLTaiizor.Controls.MetroButton BtnPatch;
        private ReaLTaiizor.Controls.MetroTile BtnReturn;
        private ReaLTaiizor.Controls.MetroTile BtnExit;
    }
}