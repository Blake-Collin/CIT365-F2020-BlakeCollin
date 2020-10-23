using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk1._0
{
    public partial class MainMenu : Form
    {

        //Public Variable of some kind list/arraylist/dictionary whatever. (Probably List)
        private static List<DeskQuote> quotes = new List<DeskQuote>();

        public MainMenu()
        {
            InitializeComponent();
            //Load JSon


            //quotes = JSon.decode(quotesSaved.json);
            //*****
        }


        public static List<DeskQuote> GetQuotes()
        {
            return quotes;
        }
        

        private void addQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote quote = new AddQuote();
            quote.Tag = this;
            quote.Show(this);
            Hide();
        }

        private void viewQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes quotes = new ViewAllQuotes();
            quotes.Tag = this;
            quotes.Show(this);
            Hide();
        }

        private void searchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes squotes = new SearchQuotes();
            squotes.Tag = this;
            squotes.Show(this);
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Save JSON


            //********
            Close();
        }
    }
}
