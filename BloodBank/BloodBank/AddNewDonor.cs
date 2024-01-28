using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class AddNewDonor : Form
    {
        function fn = new function();
        

        public AddNewDonor()
        {
            InitializeComponent();
        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            String query = "select max(did)from newDonor";
            DataSet ds = fn.getData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            labelNewID.Text = (count+1).ToString();
            

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtDOB.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtCity.Text != "" && txtAddress.Text != "" && txtBloodGroup.Text != "")
            {
                String dname = txtName.Text;
                String dob = txtDOB.Text;
                String fname = txtFather.Text;
                String mname = txtMother.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String gender = txtGender.Text;
                String city = txtCity.Text;
                String daddress = txtAddress.Text;
                String bloodgroup = txtBloodGroup.Text;

                String query = "insert into newDonor (dname, dob, fname, mname, mobile, gender, city, daddress, bloodgroup) values('"+dname+"', '"+dob+"', '"+fname+"', '"+mname+"', '"+mobile+"', '"+gender+"', '"+city+"', '"+daddress+"', '"+bloodgroup+"')";
                fn.setDate(query);
            }
            else
            {
                MessageBox.Show("Please fill all Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtDOB.ResetText();
            txtFather.Clear(); 
            txtMother.Clear();
            txtMobile.Clear();
            txtGender.ResetText();
            txtCity.Clear();
            txtAddress.Clear();
            txtBloodGroup.ResetText();
        }

        private void labelNewID_Click(object sender, EventArgs e)
        {

        }
    }
}
