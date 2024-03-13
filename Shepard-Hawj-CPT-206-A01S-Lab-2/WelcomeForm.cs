using Shepard_Hawj_CPT_206_A01S_Lab_2.StateInfoDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Shepard_Hawj_CPT_206_A01S_Lab_2
{
    public partial class WelcomeForm : Form
    {

        string stateSelected = "";
        public WelcomeForm()
        {
            InitializeComponent();
            //DataTable dt = new DataTable();
            StateInfoDataContext db = new StateInfoDataContext();
            var results = from item in db.StateInformations
                          select item.State_Name;
            foreach(string item in results)
            {
                stateComboBox.Items.Add(item);
            }
        }

        private void Search()
        {
            
            StateInfoDataContext db = new StateInfoDataContext();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //StateInfoDataContext db = new StateInfoDataContext();
            //var results = from item in db.StateInformations
            //              where item.State_Name.Contains("South Carolina")
            //              //where item.Description.Contains(des)
            //              //where item.Units_On_Hand > moreUnit
            //              select item.State_Name;// + " " + item.Description + "............" + item.Price;
            //foreach (string item in results)
            //{
            //    listBox1.Items.Add(item);
            //}
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (stateComboBox.SelectedIndex != -1)
            {
                stateSelected = stateComboBox.SelectedItem.ToString();
                MainForm StateInfoForm = new MainForm();
                StateInfoForm.StateName = stateSelected;
                StateInfoForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a state.");
            }
        }

        private void btnFilter1_Click(object sender, EventArgs e)
        {

        }
    }
}
