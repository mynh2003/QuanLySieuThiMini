using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frMessagesWarring : Form
    {
        public bool isAgree = false;
        public string messages;
        public frMessagesWarring()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
            this.lblMessages.Text = messages;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            isAgree = true;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frMessagesWarring_Load(object sender, EventArgs e)
        {
            this.lblMessages.Text = messages;
        }
    }
}
