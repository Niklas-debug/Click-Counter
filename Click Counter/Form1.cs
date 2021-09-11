using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_Counter
{
    public partial class ls_main : Form
    {

        /*Variable Namespace*/
        public int counter_int = 0;
        /*Variable Namespace End*/

        public ls_main()
        {
            InitializeComponent();
            lbl_count_digit.Text = "0";
        }

        private void btn_count_Click(object sender, EventArgs e)
        {

            if (lbl_count_digit.Text == "0")
            {
                counter_int = counter_int + 1;
                lbl_count_digit.Text = counter_int.ToString();
            } else
            {
                counter_int = counter_int + 1;
                lbl_count_digit.Text = counter_int.ToString();
            }
            
        }

        private void lbl_link_open_source_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            //this.lbl_link_open_source.LinkVisited = true; // If true, link text fades dark purple to show it has been clicked already

            // Navigate to a URL.
            System.Diagnostics.Process.Start("http://www.microsoft.com");
        }
    }
}
