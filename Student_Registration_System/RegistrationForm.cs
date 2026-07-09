using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Student_Registration_System
{
    public partial class RegistrationForm : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["StudentDB"].ConnectionString;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            LoadRegNumbers();
            ClearForm();
        }

        private void LoadRegNumbers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT regNo FROM Registration";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbRegNo.Items.Clear();
                    while (reader.Read())
                    {
                        cmbRegNo.Items.Add(reader["regNo"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading registration numbers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbRegNo.Text))
            {
                MessageBox.Show("Please enter a Registration Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRegNo.Focus();
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Registration (regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) " +
                               "VALUES (@regNo, @firstName, @lastName, @dateOfBirth, @gender, @address, @email, @mobilePhone, @homePhone, @parentName, @nic, @contactNo)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@regNo", Convert.ToInt32(cmbRegNo.Text));
                cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@dateOfBirth", dtpDateOfBirth.Value);
                cmd.Parameters.AddWithValue("@gender", rdbMale.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@mobilePhone", Convert.ToInt32(txtMobilePhone.Text));
                cmd.Parameters.AddWithValue("@homePhone", string.IsNullOrEmpty(txtHomePhone.Text) ? (object)DBNull.Value : Convert.ToInt32(txtHomePhone.Text));
                cmd.Parameters.AddWithValue("@parentName", txtParentName.Text);
                cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
                cmd.Parameters.AddWithValue("@contactNo", Convert.ToInt32(txtContactNo.Text));

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadRegNumbers();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Primary Key Violation
                    {
                        MessageBox.Show("This Registration number already exists. Please use a different number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbRegNo.SelectedItem == null)
            {
                MessageBox.Show("Please select a student to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to update this record?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Registration SET firstName=@first, lastName=@last, dateOfBirth=@dob, gender=@gender, " +
                               "address=@address, email=@email, mobilePhone=@mobile, homePhone=@home, parentName=@parent, nic=@nic, contactNo=@contact " +
                               "WHERE regNo=@regNo";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@regNo", Convert.ToInt32(cmbRegNo.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@first", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@last", txtLastName.Text);
                cmd.Parameters.AddWithValue("@dob", dtpDateOfBirth.Value);
                cmd.Parameters.AddWithValue("@gender", rdbMale.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@mobile", Convert.ToInt32(txtMobilePhone.Text));
                cmd.Parameters.AddWithValue("@home", string.IsNullOrEmpty(txtHomePhone.Text) ? (object)DBNull.Value : Convert.ToInt32(txtHomePhone.Text));
                cmd.Parameters.AddWithValue("@parent", txtParentName.Text);
                cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
                cmd.Parameters.AddWithValue("@contact", Convert.ToInt32(txtContactNo.Text));

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        LoadRegNumbers();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbRegNo.SelectedItem == null)
            {
                MessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to DELETE this record? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Registration WHERE regNo = @regNo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@regNo", Convert.ToInt32(cmbRegNo.SelectedItem.ToString()));

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        ClearForm();
                        MessageBox.Show("Student Record Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRegNumbers();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRegNo.SelectedItem != null)
            {
                string selectedRegNo = cmbRegNo.SelectedItem.ToString();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Registration WHERE regNo = @regNo";
                    SqlCommand cmd = new SqlCommand(query, conn);


                    cmd.Parameters.Add("@regNo", SqlDbType.Int).Value = Convert.ToInt32(selectedRegNo);

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtFirstName.Text = reader["firstName"].ToString();
                            txtLastName.Text = reader["lastName"].ToString();
                            dtpDateOfBirth.Value = Convert.ToDateTime(reader["dateOfBirth"]);

                            string gender = reader["gender"].ToString();
                            if (gender == "Male")
                                rdbMale.Checked = true;
                            else
                                rdbFemale.Checked = true;

                            txtAddress.Text = reader["address"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtMobilePhone.Text = reader["mobilePhone"].ToString();
                            txtHomePhone.Text = reader["homePhone"].ToString();
                            txtParentName.Text = reader["parentName"].ToString();
                            txtNIC.Text = reader["nic"].ToString();
                            txtContactNo.Text = reader["contactNo"].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            cmbRegNo.SelectedItem = null;
            cmbRegNo.Text = "";
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobilePhone.Clear();
            txtHomePhone.Clear();
            txtParentName.Clear();
            txtNIC.Clear();
            txtContactNo.Clear();
            cmbRegNo.Focus();
        }

        private void llblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void llblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}