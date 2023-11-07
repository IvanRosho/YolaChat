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

namespace YolaChat
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ToShifr = "";
            if (RBVK.Checked == true) ToShifr = "VK:";
            if (RBOK.Checked == true) ToShifr = "OK:";
            if (RBTEL.Checked == true) ToShifr = "TL:";
            if (TextBoxLogin.Text == "" || TextBoxPass.Text == "")
            {
                MessageBox.Show("Вы не указали логин и пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            ToShifr += TextBoxLogin.Text + ":" + TextBoxPass.Text;
            var Shifr = Crypto.ToAes256(ToShifr);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            using (BinaryWriter write = new BinaryWriter(File.Create(saveFileDialog1.FileName)))
            {
                write.Write(Shifr);
            }
        }

        private void RBTEL_CheckedChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(200);
            if (RBTEL.Checked == true)
            {
                TextBoxPass.Text = "Pass";
            }
        }
    }
}
