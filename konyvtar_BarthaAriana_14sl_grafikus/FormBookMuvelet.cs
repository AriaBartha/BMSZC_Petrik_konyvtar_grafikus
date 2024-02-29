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
    public partial class FormBookMuvelet : Form
    {
        string muvelet;
        public FormBookMuvelet(string muvelet)
        {
            InitializeComponent();
            this.muvelet = muvelet;
        }

        private void FormBookMuvelet_Load(object sender, EventArgs e)
        {
            switch (muvelet)
            {
                case "add":
                    this.Text = "Új könyv hozzáadása";
                    buttonMuvelet.Text = "Hozzáad";
                    buttonMuvelet.BackColor = Color.LightSeaGreen;
                    buttonMuvelet.Click += new EventHandler(insertBook);
                    break;
                case "edit":
                    this.Text = "Adatmódosítás";
                    buttonMuvelet.Text = "Módosít";
                    buttonMuvelet.BackColor = Color.Aqua;
                    buttonMuvelet.Click += new EventHandler(updateBook);
                    fillTextBoxes();
                    break;
            }
        }

        private void fillTextBoxes()
        {
            Book book = (Book)Program.formNyito.listBoxBooks.SelectedItem;
            textBoxId.Text = book.Id.ToString();
            textBoxTitle.Text = book.Title.ToString();
            textBoxAuthor.Text = book.Author.ToString();
            nuPublishYear.Value = (int)book.Publish_year;
            nuPages.Value = (int)book.Page_count;
        }


        private void updateBook(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Id = int.Parse(textBoxId.Text);
            book.Title = textBoxTitle.Text;
            book.Author = textBoxAuthor.Text;
            book.Publish_year = (int)nuPublishYear.Value;
            book.Page_count = (int)nuPages.Value;
            Program.adatok.updateBook(book);
            this.Close();
        }

        private void insertBook(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = textBoxTitle.Text;
            book.Author = textBoxAuthor.Text;
            book.Publish_year = (int)nuPublishYear.Value;
            book.Page_count = (int)nuPages.Value;
            Program.adatok.insertBook(book);
            this.Close();
        }
    }
}
