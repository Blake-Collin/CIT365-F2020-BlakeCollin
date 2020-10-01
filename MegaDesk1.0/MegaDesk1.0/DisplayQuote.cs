using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk1._0
{
    public partial class DisplayQuote : Form
    {

        private DeskQuote deskQuote;

        public DisplayQuote(DeskQuote desk)
        {
            deskQuote = desk;
            InitializeComponent();
            displayVariables();
        }

        private void displayVariables()
        {
            nameLabel.Text = nameLabel.Text + " " + deskQuote.GetCustomerName();
            depthLabel.Text = depthLabel.Text + " " + deskQuote.GetDesk().GetDeskDepth();
            widthLabel.Text = widthLabel.Text + " " + deskQuote.GetDesk().GetDeskWidth();
            drawLabel.Text = drawLabel.Text + " " + deskQuote.GetDesk().GetNumOfDrawers();
            materialLabel.Text = materialLabel.Text + " " + deskQuote.GetDesk().GetDeskMaterial().ToString();
            daysLabel.Text = daysLabel.Text + " " + deskQuote.GetProductionDdays();
            priceLabel.Text = priceLabel.Text + " " + string.Format("{0:C}", deskQuote.GetQuoteAmount());
            dateLabel.Text = dateLabel.Text + " " + deskQuote.GetCompletionDate().ToString("MM/dd/yyyy");
        }

        private void back()
        {
            AddQuote main = (AddQuote)Tag;
            main.Show();
            Hide();
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            back();
        }        

    }
}
