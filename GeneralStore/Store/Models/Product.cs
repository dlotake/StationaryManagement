using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Product:Element
    {

        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string barcode;

        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        private RateDetails rateDetails;

        public RateDetails RateDetails
        {
            get { return rateDetails; }
            set { rateDetails = value; }
        }


        public override void Save()
        {            
        }

        public override void Delete()
        {            
        }

    }

    public class RateDetails : Element
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
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

        public override void Save()
        {
            
        }

        public override void Delete()
        {
            
        }
    }

}
