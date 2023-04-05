using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOPFinalProject_653450279_6
{
    public partial class FormLogin : Form
    {
        private string originalText;
        public FormLogin()
        {
            InitializeComponent();
        }

        // กด Login 
        private void button1_Click(object sender, EventArgs e)
        {
            // ถ้ารหัสถูกต้อง เปิดหน้าใหม่แล้วซ่อนหน้า Login
            bool isLoggedIn = LoginSystem.Login(textBoxAdminname.Text, textBoxpassword.Text);
            if (isLoggedIn)
            {
                FormAllItem formAllItem = new FormAllItem();
                formAllItem.Show();
                this.Hide();
            }
            // ถ้าผิดให้ขึ้นข้อความเตือน
            else
            {
                lblError.Text = "'Username หรือ Password' ไม่ถูกต้อง";
            }
        }

        
       
        // กดเพื่อปิด App
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) 
            {
                textBoxpassword.UseSystemPasswordChar = false;
            }
            else 
            {
                textBoxpassword.UseSystemPasswordChar = true;
            }
        }
    }
}
