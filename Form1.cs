using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace last_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRegNo.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpDOB.Value = DateTime.Now;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobilePhone.Clear();
            txtHomePhone.Clear();
            txtParentName.Clear();
            txtNIC.Clear();
            txtParentContact.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegNo.Text) || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please fill all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("YOUR_CONNECTION_STRING"))
                {
                    con.Open();
                    string gender = rbMale.Checked ? "Male" : "Female";
                    SqlCommand cmd = new SqlCommand("INSERT INTO Students (RegNo, FirstName, LastName, DateOfBirth, Gender, Address, Email, MobilePhone, HomePhone, ParentName, NIC, ParentContact) VALUES (@RegNo, @FirstName, @LastName, @DateOfBirth, @Gender, @Address, @Email, @MobilePhone, @HomePhone, @ParentName, @NIC, @ParentContact)", con);
                    cmd.Parameters.AddWithValue("@RegNo", txtRegNo.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dtpDOB.Value);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@MobilePhone", txtMobilePhone.Text);
                    cmd.Parameters.AddWithValue("@HomePhone", txtHomePhone.Text);
                    cmd.Parameters.AddWithValue("@ParentName", txtParentName.Text);
                    cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@ParentContact", txtParentContact.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegNo.Text))
            {
                MessageBox.Show("Please enter a registration number to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("YOUR_CONNECTION_STRING"))
                {
                    con.Open();
                    string gender = rbMale.Checked ? "Male" : "Female";
                    SqlCommand cmd = new SqlCommand("UPDATE Students SET FirstName = @FirstName, LastName = @LastName, DateOfBirth = @DateOfBirth, Gender = @Gender, Address = @Address, Email = @Email, MobilePhone = @MobilePhone, HomePhone = @HomePhone, ParentName = @ParentName, NIC = @NIC, ParentContact = @ParentContact WHERE RegNo = @RegNo", con);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dtpDOB.Value);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@MobilePhone", txtMobilePhone.Text);
                    cmd.Parameters.AddWithValue("@HomePhone", txtHomePhone.Text);
                    cmd.Parameters.AddWithValue("@ParentName", txtParentName.Text);
                    cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@ParentContact", txtParentContact.Text);
                    cmd.Parameters.AddWithValue("@RegNo", txtRegNo.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClear_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("No student found with the given registration number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegNo.Text))
            {
                MessageBox.Show("Please enter a registration number to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this student's record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("YOUR_CONNECTION_STRING"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE RegNo = @RegNo", con);
                        cmd.Parameters.AddWithValue("@RegNo", txtRegNo.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnClear_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("No student found with the given registration number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
