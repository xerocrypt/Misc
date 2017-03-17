using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_REST_Example
{
    public partial class restMaihnForm : Form
    {
        public restMaihnForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webSearchResult.Navigate("https://twitter.com/search?q=%40" + txtSearchTerm.Text);
        }
    }
}


