using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konyvtar_BarthaAriana_14sl_grafikus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxBooks.Items.Clear();
            foreach (Book item in Program.books)
            {
                listBoxBooks.Items.Add(item);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott elem");
                return;
            }
            //--todo befejezni a törlést
        }
    }
}
