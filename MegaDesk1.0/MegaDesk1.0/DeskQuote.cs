using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk1._0
{

    public class DeskQuote
    {
        //Variables
        private Desk desk;
        private string customerName;
        private decimal quoteAmount;
        private int productionDays;
        private DateTime completionDate;


        //Constructors
        public DeskQuote(string inName, int inWidth, int inDepth, int inDrawerCount, DeskMaterial inMaterial, int inProductionDays)
        {
            desk = new Desk(inWidth, inDepth, inDrawerCount, inMaterial); //Most of the eror handling is already built into Desk class
            setCustomerName(inName);
            setProductionDays(inProductionDays);
            calculateQuote();
            calculateDate();
        }

        public DeskQuote(string inName, Desk inDesk, int inProductionDays)
        {
            desk = inDesk; //All Error handling inside should be valid/safe
            setCustomerName(inName);
            setProductionDays(inProductionDays);
            calculateQuote();
            calculateDate();
        }

        
        //Quote calculations
        private void calculateDate()
        {
            completionDate = DateTime.Today.AddDays(productionDays);
        }

        private void calculateQuote()
        {
            //Start with base cost
            decimal price = 200;

            //Calculate area cost
            int area = desk.GetDeskDepth() * desk.GetDeskWidth();
            if (area > 1000)            
                price += area;            

            //Add our drawer cost
            price += (desk.GetNumOfDrawers() * 50);

            //add material cost
            price += materialCost();

            //check rush and add
            price += rushCalculation(area);

            //Set our class quote
            quoteAmount = price;
        }

        private decimal rushCalculation(int area)
        {
            if(productionDays == 3)
            {
                if(area < 1000)
                {
                    return 60;
                }
                else if(area <= 2000 && area >= 1000)
                {
                    return 70;
                }
                else
                {
                    return 80;
                }
            }
            else if(productionDays == 5)
            {
                if (area < 1000)
                {
                    return 40;
                }
                else if (area <= 2000 && area >= 1000)
                {
                    return 50;
                }
                else
                {
                    return 60;
                }
            }
            else if(productionDays == 7)
            {
                if (area < 1000)
                {
                    return 30;
                }
                else if (area <= 2000 && area >= 1000)
                {
                    return 35;
                }
                else
                {
                    return 40;
                }
            }
            else
            {
                return 0;
            }            
        }

        private decimal materialCost()
        {
            switch (desk.GetDeskMaterial())
            {
                case DeskMaterial.Pine:
                    return 50;
                case DeskMaterial.Laminate:
                    return 100;
                case DeskMaterial.Veneer:
                    return 125;
                case DeskMaterial.Oak:
                    return 200;
                case DeskMaterial.Rosewood:
                    return 300;
                default:
                    return 0;
            }            
        }


        //Getters and Setters
        //May need to add error handling depending on name types unless we are fine with numbers
        private void setCustomerName(string _name)
        {
            if (_name != "")
                customerName = _name;
            else
                throw (new Exception("Name cannot be blank"));
        }

        public string GetCustomerName()
        {
            return customerName;
        }

        private void setProductionDays(int _days)
        {
            if (_days <= 14 && _days >= 3)
            {
                productionDays = _days;
            }
            else
                throw (new Exception("Days must be between 3-14 days!"));
        }

        public int GetProductionDdays()
        {
            return productionDays;
        }

        public decimal GetQuoteAmount()
        {
            return quoteAmount;
        }

        public Desk GetDesk()
        {
            return desk;
        }

        public DateTime GetCompletionDate()
        {
            return completionDate;
        }


    }
}
