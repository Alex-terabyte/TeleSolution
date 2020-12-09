using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeleLibrary1;

namespace WindowsFormsApp3
{
    public partial class TeleForm : Form
    {
        TeleList _teleList = new TeleList();
        public TeleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Obnow();
        }

        void Obnow()
        {
            _teleList = TeleList.GetDefaultTeleList();
            teleListBindingSource.DataSource = null;
            teleListBindingSource.DataSource = _teleList;

        }

        private void teleListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TeleForm_Load(object sender, EventArgs e)
        {
            Obnow();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            /*так как моя форма PersonEditForm называлась изначально Form1*/
            PersonEditForm newForm = new PersonEditForm();
            newForm.ShowDialog();
            Obnow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int teleID = (int)teleListDataGridView.SelectedRows[0].Cells[0].Value;

            foreach (TeleInfo tele in _teleList)
            {
                if(tele.TeleID == teleID)
                {
                    tele.DeleteTele();
                }
            }
            Obnow();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int teleID = (int)teleListDataGridView.SelectedRows[0].Cells[0].Value;
            /*так как моя форма PersonEditForm называлась изначально Form1*/
            PersonEditForm newForm = new PersonEditForm();

            foreach (TeleInfo tele in _teleList)
            {
                tele.GetTele(teleID);
                newForm._newTele = tele;
            }
            newForm.ShowDialog();
            Obnow();
        }
    }

}
