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

namespace Final_Project
{
    
    public partial class FinalForm : Form
    {
        MissionaryList myMissionaryList;
        public FinalForm()
        {
            InitializeComponent();
            myMissionaryList = new MissionaryList();
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ColumnHeadersVisible = true;
            dgvData.AllowUserToAddRows = true;
            dgvData.AllowUserToDeleteRows = true;
            myMissionaryList.reMissionary(myMissionaryList.CurrentFile);
            refreshList();
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            List<Donor> results = new List<Donor>();
            if (txtdFirst.Text.Length > 0)
            {
                foreach (Donor item in myMissionaryList.Missionary.ItemList)
                {
                    if (item.First.ToLower().Contains(txtdFirst.Text.ToLower()))
                    {
                        results.Add(item);
                    }
                }
            }
            else if (txtdLast.Text.Length > 0)
            {
                foreach (Donor item in myMissionaryList.Missionary.ItemList)
                {
                    if (item.Last.ToLower().Contains(txtdLast.Text.ToLower()))
                    {
                        results.Add(item);
                    }
                }
            }
            if (results.Count > 0)
            {
                dgvData.DataSource = typeof(Donor);
                dgvData.DataSource = results;
            }
        }

        private Donor createDonor()
        {
            Donor item = new Donor(txtdFirst.Text, txtdLast.Text, Convert.ToDouble(txtAmount.Text), txtdAddress.Text, txtdState.Text, Convert.ToInt32(txtdZip.Text), dateTimePicker1.Text) 
            ;
            return item;
        }

        private void clearItem()
        {
            txtdFirst.Clear();
            txtdLast.Clear();
            txtAmount.Clear();
            txtdAddress.Clear();
            txtdState.Clear();
            txtdZip.Clear();
        }

        private void clearForm()
        {
            txtdFirst.Clear();
            txtTotal.Clear();
            txtdLast.Clear();
            txtdAddress.Clear();
            txtAmount.Clear();
            txtdState.Clear();
            txtdZip.Clear();
            txtmFirst.Clear();
            txtmLast.Clear();
            txtmAddress.Clear();
            txtmState.Clear();
            txtmZip.Clear();
            txtmTelephone.Clear();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void refreshList()
        {
            dgvData.DataSource = typeof(Donor);
            dgvData.DataSource = myMissionaryList.Missionary.ItemList;
            double total = 0;
            foreach (Donor item in myMissionaryList.Missionary.ItemList)
            {
                total += item.Amount;
            }
            txtTotal.Text = total.ToString("C");
            string tt = myMissionaryList.CurrentFile;
            if (tt.Contains(@"\"))
                Text = tt.Substring(tt.LastIndexOf(@"\") + 1);
            else
                Text = tt;

        
            txtmAddress.Text = myMissionaryList.Missionary.MAddress;
            txtmFirst.Text = myMissionaryList.Missionary.MFirstName;
            txtmLast.Text = myMissionaryList.Missionary.MLastName;
            txtmZip.Text = myMissionaryList.Missionary.MZip.ToString();
            txtmTelephone.Text = myMissionaryList.Missionary.MTelephone.ToString();
            txtmState.Text = myMissionaryList.Missionary.MState;
            txtGoal.Text = myMissionaryList.Missionary.MGoal.ToString();



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool itemFound = false;
                string searchKey = txtdFirst.Text + txtdLast.Text;
                for (int location = 0; location < myMissionaryList.Missionary.ItemList.Count; ++location)
                {
                    Donor tmpItem = myMissionaryList.Missionary.ItemList.ElementAt(location);
                    if ((tmpItem.First + tmpItem.Last).Equals(searchKey))
                    {
                        myMissionaryList.Missionary.ItemList.RemoveAt(location);
                        myMissionaryList.Missionary.ItemList.Insert(location, createDonor());
                        itemFound = true;
                        break;
                    }
                }

                if (!itemFound)
                {
                    myMissionaryList.Missionary.ItemList.Add(createDonor());
                }
            }
            catch (Exception ex)
            {
                txtAmount.Text = "";
            }

            myMissionaryList.UpdateMissionary(txtmFirst.Text, txtmLast.Text, txtmAddress.Text, txtmState.Text, Convert.ToInt32(txtmZip.Text), Convert.ToInt32(txtmTelephone.Text), Convert.ToDouble(txtGoal.Text));
            myMissionaryList.persist();
            clearItem();
            refreshList();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvData.SelectedRows)
            {
                myMissionaryList.Missionary.ItemList.RemoveAt(item.Index);
            }
            myMissionaryList.persist();
            refreshList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearItem();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult res = saveFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                string name = saveFileDialog1.FileName;
                if (!File.Exists(name + ".xml"))
                {
                    myMissionaryList.CurrentFile = saveFileDialog1.FileName + ".xml";
                    myMissionaryList.clear();
                    myMissionaryList.Missionary = new MissionaryInfo();
                    clearForm();
                    refreshList();
                }
            }
        }
    }



}
