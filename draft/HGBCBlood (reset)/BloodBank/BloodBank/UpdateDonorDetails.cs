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
    public partial class UpdateDonorDetails : Form
    {
        
        private object txtDonorID;

        function fn = new function();
        public UpdateDonorDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tctDonorID.Text.ToString());
            String query = "select * from newDonor where did = "+id+"";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtDOB.Text = ds.Tables[0].Rows[0][2].ToString();
                txtFather.Text = ds.Tables[0].Rows[0][3].ToString();
                txtMother.Text = ds.Tables[0].Rows[0][4].ToString();
                txtMobile.Text = ds.Tables[0].Rows[0][5].ToString();
                txtGender.Text = ds.Tables[0].Rows[0][6].ToString();
                txtCity.Text = ds.Tables[0].Rows[0][7].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0][8].ToString();
                txtBloodGroup.Text = ds.Tables[0].Rows[0][9].ToString();
            }
            else 
            {
                MessageBox.Show("Invalid DonorID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void tctDonorID_TextChanged(object sender, EventArgs e)
        {
            if (tctDonorID.Text == "")
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
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tctDonorID.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String query = "update newDonor set dname='"+txtName.Text+"',dob='"+txtDOB.Text+"',fname='"+txtFather.Text+"',mname='"+txtMother.Text+"',mobile="+txtMobile.Text+", gender'"+txtGender.Text+"', city='"+txtCity.Text+"',daddress='"+txtAddress.Text+"',bloodgroup='"+txtBloodGroup.Text+"' where did="+tctDonorID.Text+" ";
            fn.setDate(query);
            UpdateDonorDetails_Load(this, null);

        }

        private void UpdateDonorDetails_Lo(UpdateDonorDetails updateDonorDetails, object value)
        {
           
        }

        private void UpdateDonorDetails_Load(object sender, EventArgs e)
        {
            tctDonorID.Clear();
        }
    }
}