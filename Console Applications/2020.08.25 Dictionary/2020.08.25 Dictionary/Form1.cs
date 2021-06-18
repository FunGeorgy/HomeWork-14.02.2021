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
    
    public partial class Form1 : Form
    {
        
        List<Books> books = new List<Books>();
        
        public Form1()
        {   
            InitializeComponent();
            
        }

        private void RefreshListView()
        { 
            listView1.Items.Clear();
            foreach (var item in books)
            {
                ListViewItem lvl = new ListViewItem();
                lvl.Text = item.name;
                lvl.SubItems.Add(item.author);
                lvl.SubItems.Add(item.genre); 
                lvl.SubItems.Add(item.data.ToString("dd.MM.yyyy"));
                listView1.Items.Add(lvl);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            AddBook book = new AddBook();
            if (book.ShowDialog() == DialogResult.OK)
            {
                books.Add(book.Book);
                RefreshListView();
            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
