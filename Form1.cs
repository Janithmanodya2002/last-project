namespace last_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String username = txtUserName.Text;
            String password = txtPassword.Text;
            if (username == "admin" && password == "Skill@123")
            {
                MessageBox.Show("Login successful!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit...?", "Exit");
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
