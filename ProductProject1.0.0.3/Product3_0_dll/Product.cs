using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product3_0_dll
{
    public class Product
    {
        private int ProductId;
        private string ProductName;
        private DateTime purchaseDate;
        private DateTime ExpDate;
        private double price;
        private int quantity;
        private int discount;
        private DateTime MFG;


        public virtual int Id
        {
            get { return ProductId; }
            set {
                if (value > 0)
                {
                    ProductId = value;
                }
                else
                {
                    throw new Exception("Enter valid id");
                }
                
            }
        }

        public string name
        {
            get { return ProductName; }
            set { 
                if(value.Length > 0)
                {
                    ProductName = value;
                }
                else
                {
                    throw new Exception("enter name having length > 3");
                }
               
            }
        }
        public DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set
            {
                if (value < DateTime.Now)
                {
                    purchaseDate = value;
                   
                }
                else
                {
                    throw new Exception("mfd date must be less than purchase date.");
                }
            }
        }
        public DateTime Mfg
        {
            get { return MFG; }
            set
            {
                if (value < PurchaseDate)
                {
                    MFG= value;
                }
                else
                {
                    throw new Exception("mfd date must be less than purchase date.");
                }
            }
        }
        private DateTime ExpiryD //------------------ logic remaning for expiry
        {
            get { return MFG.AddYears(2); }
            
        }

      

        public int Quantity
        {
            get { return quantity; }
            set 
            {
                if (value > 0)
                {
                    quantity = value;
                }
                else
                {
                    throw new Exception("Price must be greater than 0");
                }
                
            }
        }
        //-------------------------------------------------------------------------
        private Price tax;   //tax--> basic, gst
        public Price Tax
        {
            get { return tax; }
            set {
                    tax = value;
                
                price = tax.basicPrice;
            }
        }
        //-----------------------------------------------------------------------
        public int Discount
        {
            get { return discount; }
            set {
                if (value > 0 && value < 20)
                {
                    discount = value;
                    //this.getDiscountPrice();
                }
                else
                {
                    throw new Exception("discount must be greater than 0 and less than 20");
                }

            }
        }

        private double getDiscountPrice()
        {
           return (price + tax.getTaxPrice()) *discount/100;
        }
        private double getTotalPrice()
        {
            double value = price+tax.getTaxPrice()  ;
            return value * quantity - getDiscountPrice()*quantity;
        }
        public virtual String Display()
        {
            
            return "ProductId = " + ProductId + "\nProductName =" + ProductName + "\nPurchaseDate = " + PurchaseDate + "\nprice =" + price + "\nquantity = " + quantity + "\ntax = " + tax.getTaxPrice()+ "\ndiscount =" + discount+"\ntotal tax="+tax.getTaxPrice()*quantity+"\ntotal discount="+getDiscountPrice()*quantity+"\ntotal price= "+getTotalPrice()+"\n";
        }
    }
}
