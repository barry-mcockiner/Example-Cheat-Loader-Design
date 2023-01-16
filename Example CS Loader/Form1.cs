using KeyAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_CS_Loader
{
    public partial class Form1 : Form
    {

        public static api KeyAuthApp = new api(
            name: "notanotherexampleloader",
            ownerid: "RGdRw85idk",
            secret: "d871851678abad717ef57ceb795197c83ebb5b77a989c57b458ef576d08975df",
            version: "1.0"
        );

        public Form1()
        {
            KeyAuthApp.init();
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(bunifuTextBox1.Text, bunifuTextBox2.Text);
            if (KeyAuthApp.response.success)
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show(KeyAuthApp.response.message);
            }
        }
    }
}
