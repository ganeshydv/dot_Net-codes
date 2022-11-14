using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDAL.EntityLayer
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [StringLength(50)]
        public string Name { get; set; }
        
        [Column(TypeName = "date")]
        public DateTime MfgDate { get; set; }
        
        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }
       
        public int Stock { get; set; }
        
        [Column(TypeName = "money")]
        public double Price { get; set; }
        
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        
        public bool Status { get; set; }

        public Category Category { get; set; }


        //-------------------------------------------------------------------------
        //private Price tax;   //tax--> basic, gst
        //public Price Tax
        //{
        //    get { return tax; }
        //    set {
        //            tax = value;

        //        price = tax.basicPrice;
        //    }
        //}
        ////-----------------------------------------------------------------------


        //private double getDiscountPrice()
        //{
        //   return (price + tax.getTaxPrice()) *discount/100;
        //}
        //private double getTotalPrice()
        //{
        //    double value = price+tax.getTaxPrice()  ;
        //    return value * quantity - getDiscountPrice()*quantity;
        //}
        //public virtual String Display()
        //{

        //    return "ProductId = " + ProductId + "\nProductName =" + ProductName + "\nPurchaseDate = " + PurchaseDate + "\nprice =" + price + "\nquantity = " + quantity + "\ntax = " + tax.getTaxPrice()+ "\ndiscount =" + discount+"\ntotal tax="+tax.getTaxPrice()*quantity+"\ntotal discount="+getDiscountPrice()*quantity+"\ntotal price= "+getTotalPrice()+"\n";
        //}
    }
}
