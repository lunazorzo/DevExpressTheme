namespace DevExpressTheme
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "LookAndFeel ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(265, 64);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "Open Frame";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(15, 38);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "DevExpress Style",
            "DevExpress Dark Style",
            "VS2010",
            "Seven Classic",
            "Office 2010 Blue",
            "Office 2010 Black",
            "Office 2010 Silver",
            "Office 2013",
            "Office 2013 Dark Gray",
            "Office 2013 Light Gray",
            "Visual Studio 2013 Blue",
            "Visual Studio 2013 Light",
            "Visual Studio 2013 Dark",
            "Coffee",
            "Liquid Sky",
            "London Liquid Sky",
            "Glass Oceans",
            "Stardust",
            "Xmas 2008 Blue",
            "Valentine",
            "McSkin",
            "Summer 2008",
            "Pumpkin",
            "Dark Side",
            "Springtime",
            "Foggy",
            "High Contrast",
            "Seven",
            "Sharp",
            "Sharp Plus",
            "The Asphalt World",
            "Whiteprint",
            "Caramel",
            "Money Twins",
            "Lilian",
            "iMaginary",
            "Black",
            "Office 2007 Blue",
            "Office 2007 Black",
            "Office 2007 Silver",
            "Office 2007 Green",
            "Office 2007 Pink",
            "Blue",
            "Darkroom",
            "Blueprint",
            "Metropolis Dark",
            "Metropolis"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(325, 20);
            this.comboBoxEdit1.TabIndex = 19;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 98);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Metropolis";
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LookAndFeel ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;



    }
}

