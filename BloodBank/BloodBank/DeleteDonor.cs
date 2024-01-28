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
    public partial class DeleteDonor : Form
    {
        function fn = new function();
        String query;
        public DeleteDonor()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDonorID.Clear(); //
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

        private void btnErase_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                query = "delete from newDonor where did = "+txtDonorID.Text+"";
                fn.setDate(query);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtDonorID.Text != "")
            {
                query = "select * from newDonor where did = " + txtDonorID.Text + " ";
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
                    MessageBox.Show("No Record Exists","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDonorID.Clear();
                }
            }
        }

        private void txtDonorID_TextChanged(object sender, EventArgs e)
        {
            if (txtDonorID.Text =="")
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
    }
}