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
   
    public partial class frMessagesSuccess : Form
    {
        public string messages;
        public frMessagesSuccess()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frMessagesSuccess_Load(object sender, EventArgs e)
        {
            this.lblMessages.Text = messages;
        }
    }
}
