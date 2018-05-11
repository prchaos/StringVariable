using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringVariable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLetters_Click(object sender, EventArgs e)
        {
            string notes;
            notes = lblLetters.Text;
            string firstLetters = notes.Substring(2, 5);
            string nextLetters = notes.Substring(0, 2);
            txtLetters.Text = firstLetters + nextLetters;

        }
    }
}
