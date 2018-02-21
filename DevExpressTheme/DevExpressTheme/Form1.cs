using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevExpressTheme
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            //DevExpress.Skins.SkinManager.EnableFormSkins();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxEdit1.SelectedIndex = 0;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Form2 open = new Form2();
            open.Show();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedIndex == 0)
            {
                UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            }
            else if (comboBoxEdit1.SelectedIndex == 1)
            {
                UserLookAndFeel.Default.SetSkinStyle("DevExpress Dark Style");
            }
            else if (comboBoxEdit1.SelectedIndex == 2)
            {
                UserLookAndFeel.Default.SetSkinStyle("VS2010");
            }
            else if (comboBoxEdit1.SelectedIndex == 3)
            {
                UserLookAndFeel.Default.SetSkinStyle("Seven Classic");
            }
            else if (comboBoxEdit1.SelectedIndex == 4)
            {
                UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            }
            else if (comboBoxEdit1.SelectedIndex == 5)
            {
                UserLookAndFeel.Default.SetSkinStyle("Office 2010 Black");
            }
            else if (comboBoxEdit1.SelectedIndex == 6)
            {
                UserLookAndFeel.Default.SetSkinStyle("Office 2010 Silver");
            }
            else if (comboBoxEdit1.SelectedIndex == 7)
            {
                UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            }
            else if (comboBoxEdit1.SelectedIndex == 8)
            {
                UserLookAndFeel.Default.SetSkinStyle("Office 2013 Dark Gray");
            }
            else if (comboBoxEdit1.SelectedIndex == 9)
            {
                UserLookAndFeel.Default.SetSkinStyle("Office 2013 Light Gray");
            }
            else if (comboBoxEdit1.SelectedIndex == 10)
            {
                UserLookAndFeel.Default.SetSkinStyle("Visual Studio 2013 Blue");
            }
            else if (comboBoxEdit1.SelectedIndex == 11)
            {
                UserLookAndFeel.Default.SetSkinStyle("Visual Studio 2013 Light");
            }
            else if (comboBoxEdit1.SelectedIndex == 12)
            {
                UserLookAndFeel.Default.SetSkinStyle("Visual Studio 2013 Dark");
            }
            else if (comboBoxEdit1.SelectedIndex == 13)
            {
                UserLookAndFeel.Default.SetSkinStyle("Coffee");
            }
            else if (comboBoxEdit1.SelectedIndex == 14)
            {
                UserLookAndFeel.Default.SetSkinStyle("Liquid Sky");
            }
            else if (comboBoxEdit1.SelectedIndex == 15)
            {
                UserLookAndFeel.Default.SetSkinStyle("London Liquid Sky");
            }
            else if (comboBoxEdit1.SelectedIndex == 16)
            {
                UserLookAndFeel.Default.SetSkinStyle("Glass Oceans");
            }
            else if (comboBoxEdit1.SelectedIndex == 17)
            {
                UserLookAndFeel.Default.SetSkinStyle("Stardust");
            }
            else if (comboBoxEdit1.SelectedIndex == 18)
            {
                UserLookAndFeel.Default.SetSkinStyle("Xmas 2008 Blue");
            }
            else if (comboBoxEdit1.SelectedIndex == 19)
            {
                UserLookAndFeel.Default.SetSkinStyle("Valentine");
            }
            else if (comboBoxEdit1.SelectedIndex == 20)
            {
                UserLookAndFeel.Default.SetSkinStyle("McSkin");
            }
            else if (comboBoxEdit1.SelectedIndex == 21)
            {
                UserLookAndFeel.Default.SetSkinStyle("Summer 2008");
            }
            else if (comboBoxEdit1.SelectedIndex == 22)
            {
                UserLookAndFeel.Default.SetSkinStyle("Pumpkin");
            }
            else if (comboBoxEdit1.SelectedIndex == 23)
            {
                UserLookAndFeel.Default.SetSkinStyle("Dark Side");
            }
            else if (comboBoxEdit1.SelectedIndex == 24)
            {
                UserLookAndFeel.Default.SetSkinStyle("Springtime");
            }
            else if (comboBoxEdit1.SelectedIndex == 25)
            {
                UserLookAndFeel.Default.SetSkinStyle("Foggy");
            }
            else if (comboBoxEdit1.SelectedIndex == 26)
            {
                UserLookAndFeel.Default.SetSkinStyle("High Contrast");
            }
            else if (comboBoxEdit1.SelectedIndex == 27)
            {
                UserLookAndFeel.Default.SetSkinStyle("Seven");
            }
            else if (comboBoxEdit1.SelectedIndex == 28)
            {
                UserLookAndFeel.Default.SetSkinStyle("Sharp");
            }
            else if (comboBoxEdit1.SelectedIndex == 29)
            {
                UserLookAndFeel.Default.SetSkinStyle("Sharp Plus");
            }
            else if (comboBoxEdit1.SelectedIndex == 30)
            {
                UserLookAndFeel.Default.SetSkinStyle("The Asphalt World");
            }
            else if (comboBoxEdit1.SelectedIndex == 31)
            {
                UserLookAndFeel.Default.SetSkinStyle("Whiteprint");
            }
            else if (comboBoxEdit1.SelectedIndex == 32)
            {
                UserLookAndFeel.Default.SetSkinStyle("Caramel");
            }
            else if (comboBoxEdit1.SelectedIndex == 33)
            {
                UserLookAndFeel.Default.SetSkinStyle("Money Twins");
            }
            else if (comboBoxEdit1.SelectedIndex == 34)
            {
                UserLookAndFeel.Default.SetSkinStyle("Lilian");
            }
            else if (comboBoxEdit1.SelectedIndex == 35)
            {
                UserLookAndFeel.Default.SetSkinStyle("iMaginary");
            }
            else if (comboBoxEdit1.SelectedIndex == 36)
            {
                UserLookAndFeel.Default.SetSkinStyle("Black");
            }
            else if (comboBoxEdit1.SelectedIndex == 37)
            {
                UserLookAndFeel.Default.SetSkinStyle("Office 2007 Blue");
            }
            else if (comboBoxEdit1.SelectedIndex == 38)
            {
                UserLookAndFeel.Default.SetSkinStyle("Office 2007 Black");
            }
            else if (comboBoxEdit1.SelectedIndex == 39)
            {
                UserLookAndFeel.Default.SetSkinStyle("Office 2007 Silver");
            }
            else if (comboBoxEdit1.SelectedIndex == 40)
            {
                UserLookAndFeel.Default.SetSkinStyle("Office 2007 Green");
            }
            else if (comboBoxEdit1.SelectedIndex == 41)
            {
                UserLookAndFeel.Default.SetSkinStyle("Office 2007 Pink");
            }
            else if (comboBoxEdit1.SelectedIndex == 42)
            {
                UserLookAndFeel.Default.SetSkinStyle("Blue");
            }
            else if (comboBoxEdit1.SelectedIndex == 43)
            {
                UserLookAndFeel.Default.SetSkinStyle("Darkroom");
            }
            else if (comboBoxEdit1.SelectedIndex == 44)
            {
                UserLookAndFeel.Default.SetSkinStyle("Blueprint");
            }
            else if (comboBoxEdit1.SelectedIndex == 45)
            {
                UserLookAndFeel.Default.SetSkinStyle("Metropolis Dark");
            }
            else if (comboBoxEdit1.SelectedIndex == 46)
            {
                UserLookAndFeel.Default.SetSkinStyle("Metropolis");
            }
        }
    }
}
