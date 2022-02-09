using MobileSHop_Soft.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileSHop_Soft
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int startpoint = 15;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            startpoint += 1;
 
            bprogress.Value = startpoint;
            tprogress.Value = startpoint;
            if (tprogress.Value == 100)
            {
               
                bprogress.Value = 0;
                tprogress.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }

        }

        private void start_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
