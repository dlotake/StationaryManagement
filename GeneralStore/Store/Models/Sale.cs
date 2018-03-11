using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Sale:Element
    {
        private Customer customer;

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        private List<SaleDetail> saleDetails;

        public List<SaleDetail> SaleDetails
        {
            get { return saleDetails; }
            set { saleDetails = value; }
        }

        private double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private double discount;

        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        private double sgst;

        public double SGST
        {
            get { return sgst; }
            set { sgst = value; }
        }

        private double igst;

        public double IGST
        {
            get { return igst; }
            set { igst = value; }
        }

        private double cgst;

        public double CSGT
        {
            get { return cgst; }
            set { cgst = value; }
        }

        private double paid;

        public double Paid
        {
            get { return paid; }
            set { paid = value; }
        }

        private double remaining;

        public double Remaining
        {
            get { return remaining; }
            set { remaining = value; }
        }
    }

    public class SaleDetail:Element
    {
        private Product product;

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private double sgst;

        public double SGST
        {
            get { return sgst; }
            set { sgst = value; }
        }

        private double cgst;

        public double CGST
        {
            get { return cgst; }
            set { cgst = value; }
        }

        private double igst;

        public double IGST
        {
            get { return igst; }
            set { igst = value; }
        }

        private double discount;

        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        private double quantity;

        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
