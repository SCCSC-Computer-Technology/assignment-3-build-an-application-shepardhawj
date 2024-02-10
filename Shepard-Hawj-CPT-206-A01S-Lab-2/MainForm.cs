using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shepard_Hawj_CPT_206_A01S_Lab_2
{
    public partial class MainForm : Form
    {
        string statenam = "";
        public string StateName
        {
            set { statenam = value; }
        }
        public MainForm()
        {
            InitializeComponent();
            textBox1.Text = statenam;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = statenam;
            stateLabel.Text = statenam;
            StateInfoDataContext db = new StateInfoDataContext();


            var results1 = from item in db.StateInformations
                          where item.State_Name.Contains(statenam)
                          select item.State_Flag_Des;
            foreach (string item in results1)
            {
                descriptionTextBox.Text = item;
            }

            var results2 = from item in db.StateInformations
                          where item.State_Name.Contains(statenam)
                          select item.State_Capital;
            foreach (string item in results2)
            {
                stateCapTextBox.Text = item;
            }

            var results3 = from item in db.StateInformations
                           where item.State_Name.Contains(statenam)
                           select item.State_Larg_Cities;
            foreach (string item in results3)
            {
                largeCitiesTextBox.Text = item;
            }

            var results4 = from item in db.StateInformations
                           where item.State_Name.Contains(statenam)
                           select item.State_Flower;
            foreach (string item in results4)
            {
                stateFlowerTextBox.Text = item;
            }

            var results5 = from item in db.StateInformations
                           where item.State_Name.Contains(statenam)
                           select item.State_Bird;
            foreach (string item in results5)
            {
                stateBirdTextBox.Text = item;
            }

            var results6 = from item in db.StateInformations
                           where item.State_Name.Contains(statenam)
                           select item.State_Colors;
            foreach (string item in results6)
            {
                stateColorsTextBox.Text = item;
            }

            var results7 = from item in db.StateInformations
                           where item.State_Name.Contains(statenam)
                           select item.State_Pop;
            foreach (int item in results7)
            {
                statePopTextBox.Text = item.ToString();
            }

            var results8 = from item in db.StateInformations
                           where item.State_Name.Contains(statenam)
                           select item.State_Med_Income;
            foreach (int item in results8)
            {
                stateMedTextBox.Text = item.ToString();
            }

            var results9 = from item in db.StateInformations
                           where item.State_Name.Contains(statenam)
                           select item.State_Perc_CompJob;
            foreach (float item in results9)
            {
                statePerTextBox.Text = item.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            descriptionTextBox.ReadOnly = false;
            stateCapTextBox.ReadOnly = false;
            largeCitiesTextBox.ReadOnly = false; 
            stateFlowerTextBox.ReadOnly = false;
            stateBirdTextBox.ReadOnly = false;
            stateColorsTextBox.ReadOnly = false;
            statePopTextBox.ReadOnly = false;
            stateMedTextBox.ReadOnly = false;
            statePerTextBox.ReadOnly = false;
            btnEdit.Visible = false;
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //StateInfoDataContext db = new StateInfoDataContext();
            //StateInfoDBDataSet dbDataSet = new StateInfoDBDataSet();

            descriptionTextBox.ReadOnly = true;
            stateCapTextBox.ReadOnly = true;
            largeCitiesTextBox.ReadOnly = true;
            stateFlowerTextBox.ReadOnly = true;
            stateBirdTextBox.ReadOnly = true;
            stateColorsTextBox.ReadOnly = true;
            statePopTextBox.ReadOnly = true;
            stateMedTextBox.ReadOnly = true;
            statePerTextBox.ReadOnly = true;
            btnEdit.Visible = true;
            btnSave.Visible = false;

            try
            {
                using (StateInfoDataContext db = new StateInfoDataContext())
                {
                    StateInformation UpdateInfo = db.StateInformations.SingleOrDefault(items => items.State_Name == statenam);
                    UpdateInfo.State_Flag_Des = descriptionTextBox.Text;
                    UpdateInfo.State_Capital = stateCapTextBox.Text;
                    UpdateInfo.State_Larg_Cities = largeCitiesTextBox.Text;
                    UpdateInfo.State_Flower = stateFlowerTextBox.Text;
                    UpdateInfo.State_Bird = stateBirdTextBox.Text;
                    UpdateInfo.State_Colors = stateColorsTextBox.Text;
                    UpdateInfo.State_Pop = int.Parse(statePopTextBox.Text);
                    UpdateInfo.State_Med_Income = int.Parse(stateMedTextBox.Text);
                    UpdateInfo.State_Perc_CompJob = float.Parse(statePerTextBox.Text);

                    db.SubmitChanges();
                }
            }
            catch 
            {
                MessageBox.Show("Please enter corrct data type.");
                //MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }



            //var result = (from item in db.StateInformations
            //              where item.State_Name == statenam
            //              select item).SingleOrDefault();



          


        }
    }
}
