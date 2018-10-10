using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSforArgos.Business;
using POSforArgos.View;

namespace POSforArgos
{
    

    public partial class loginForm : Form
    {
        LoginAuth obj = new LoginAuth();
        public static string SetValueForText1 = "";

        public loginForm()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            rdoCashier.Checked = true;
        }

        private void rdoCashier_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCashier.Checked == true)
            {
                lblLoginPrev.Text = "You have selected to login as Cashier";
            }
            else
            {
                lblLoginPrev.Text = "You have selected to login as Admin";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (rdoAdmin.Checked == true)
            {
                int auth = obj.Admin_Auth(username, password);
                try
                {
                    if (auth == 1)
                    {
                        AdminPanel panel = new AdminPanel();
                        SetValueForText1 = txtUsername.Text;
                        panel.Show();
                        Hide();
                    }
                    else
                    {
                        switch (MessageBox.Show("Authentication Failed? try again",
                        "Login Failed",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question))
                        {
                            case DialogResult.Yes:
                                this.Hide();
                                loginForm form = new loginForm();
                                form.Show();
                                break;

                            case DialogResult.No:
                                Application.Exit();
                                break;
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                int auth = obj.Cashier_Auth(username, password);
                try
                {
                    if (auth == 1)
                    {
                        CashierPanel panel = new CashierPanel();
                        SetValueForText1 = txtUsername.Text;
                        panel.Show();
                        this.Hide();
                    }
                    else
                    {
                        switch (MessageBox.Show("Authentication Failed? try again",
                        "Login Failed",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question))
                        {
                            case DialogResult.Yes:
                                this.Hide();
                                loginForm form = new loginForm();
                                form.Show();
                                break;

                            case DialogResult.No:
                                Application.Exit();
                                break;
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                if (rdoAdmin.Checked == true)
                {
                    int auth = obj.Admin_Auth(username, password);
                    try
                    {
                        if (auth == 1)
                        {
                            AdminPanel panel = new AdminPanel();
                            SetValueForText1 = txtUsername.Text;
                            panel.Show();
                            this.Hide();
                        }
                        else
                        {
                            switch (MessageBox.Show("Authentication Failed? try again",
                            "Login Failed",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question))
                            {
                                case DialogResult.Yes:
                                    this.Hide();
                                    loginForm form = new loginForm();
                                    form.Show();
                                    break;

                                case DialogResult.No:
                                    Application.Exit();
                                    break;
                            }
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else
                {
                    int auth = obj.Cashier_Auth(username, password);
                    try
                    {
                        if (auth == 1)
                        {
                            CashierPanel panel = new CashierPanel();
                            SetValueForText1 = txtUsername.Text;
                            panel.Show();
                            this.Hide();
                        }
                        else
                        {
                            switch (MessageBox.Show("Authentication Failed? try again",
                            "Login Failed",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question))
                            {
                                case DialogResult.Yes:
                                    this.Hide();
                                    loginForm form = new loginForm();
                                    form.Show();
                                    break;

                                case DialogResult.No:
                                    Application.Exit();
                                    break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (rdoAdmin.Checked == true)
            {
                int auth = obj.Admin_Auth(username, password);
                try
                {
                    if (auth == 1)
                    {
                        AdminPanel panel = new AdminPanel();
                        SetValueForText1 = txtUsername.Text;
                        panel.Show();
                        this.Hide();
                    }
                    else
                    {
                        switch (MessageBox.Show("Authentication Failed? try again",
                        "Login Failed",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question))
                        {
                            case DialogResult.Yes:
                                this.Hide();
                                loginForm form = new loginForm();
                                form.Show();
                                break;

                            case DialogResult.No:
                                Application.Exit();
                                break;
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                int auth = obj.Cashier_Auth(username, password);
                try
                {
                    if (auth == 1)
                    {
                        CashierPanel panel = new CashierPanel();
                        SetValueForText1 = txtUsername.Text;
                        panel.Show();
                        this.Hide();
                    }
                    else
                    {
                        switch (MessageBox.Show("Authentication Failed? try again",
                        "Login Failed",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question))
                        {
                            case DialogResult.Yes:
                                this.Hide();
                                loginForm form = new loginForm();
                                form.Show();
                                break;

                            case DialogResult.No:
                                Application.Exit();
                                break;
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
