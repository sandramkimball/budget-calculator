using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyFolio
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // make app name multiline
            // set the height to the panel
            panel1.Height = this.Height;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AppNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PropertiesBtn_Click(object sender, EventArgs e)
        {

        }

        private void TypesBtn_Click(object sender, EventArgs e)
        {
            PropertyTypesForm propTypeF = new PropertyTypesForm();
            propTypesF.Show();
        }
    }
}
