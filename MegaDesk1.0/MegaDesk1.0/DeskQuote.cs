using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

        //static variables
        private static int[,] rushPrices = new int[3,3];

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
                price += (area - 1000);

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

        public static void GetRushOrder(List<int> prices)
        {            
            string path = @"rushOrderPrices.txt";
            List<int> integers = new List<int>();
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            try
            {
                foreach (string line in lines)
                {
                    integers.Add(int.Parse(line));
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
            finally
            {
                if (prices.Count == 9)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        for (int y = 0; y < 3; y++)
                        {
                            rushPrices[x, y] = prices[0];
                            prices.RemoveAt(0);
                        }
                    }
                }
                else
                    throw (new Exception("List too small/big, its broken or something got sent wrong please try again!"));
            }        
        }

    }
}

