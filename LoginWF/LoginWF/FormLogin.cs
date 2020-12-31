using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Runtime.InteropServices;


namespace LoginWF
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public FormLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void txtUsername_MouseHover(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
                txtUsername.Text = "";
            if(txtUsername.Text != "")
            {
                picbUsernameOk.Visible = true;
            }
            else
            {
                picbUsernameOk.Visible = false;
            }

        }

        private void txtUsername_MouseLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                picbUsernameOk.Visible = true;
            }
            else
            {
                picbUsernameOk.Visible = false;
            }
        }

        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
                txtPassword.Text = "";
            txtPassword.UseSystemPasswordChar = true;

            //Check Pw
            if (txtPassword.Text != "")
            {
                picbPasswordOk.Visible = true;
            }
            else
            {
                picbPasswordOk.Visible = false;
            }
        }
        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                picbPasswordOk.Visible = true;
            }
            else
            {
                picbPasswordOk.Visible = false;
            }
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void picbClose_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có muốn thoát", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlg == DialogResult.Yes)
            {
                this.Close();

            }
            else
            {

            }
        }

        private void picbMinimine_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}