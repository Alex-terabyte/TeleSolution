using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using TeleLibrary1;

namespace WindowsFormsApp3
{
    public partial class PersonEditForm : Form
    {
        public TeleInfo _newTele = new TeleInfo();
        public PersonEditForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                if (_newTele.TeleID > 0)
                {
                    _newTele.UpdateTele();
                }
                else
                {
                    _newTele.InsertTele();
                }
            Close();
            
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            teleInfoBindingSource.DataSource = _newTele;
        }

        private void teleNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void teleNameTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
