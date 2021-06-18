using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._08._25_Dictionary
{
    public partial class AddBook : Form
    {
        public Books Book = null;
        public AddBook()
        {
            InitializeComponent();
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book = new Books
            {
                name = TitletextBox.Text,
                author = AuthortextBox.Text,
                genre = GenretextBox.Text,
                data = DateTime.Parse(DatatextBox.Text)

            };
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
