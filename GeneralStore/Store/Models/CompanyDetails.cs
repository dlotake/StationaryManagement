using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public  class CompanyDetails:Element    
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; NotifyPropertyChanged(); }
        }

        private string addressline1;
        public string AddressLine1
        {
            get { return addressline1; }
            set { addressline1 = value; NotifyPropertyChanged(); }
        }

        private string addressline2;
        public string AddressLine2
        {
            get { return addressline2; }
            set { addressline2 = value; NotifyPropertyChanged(); }
        }

        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; NotifyPropertyChanged(); }
        }

        private string state;
        public string State
        {
            get { return state; }
            set { state = value; NotifyPropertyChanged(); }
        }

        private string city;
        public string City
        {
            get { return city; }
            set { city = value; NotifyPropertyChanged(); }
        }

        private string pin;

        public string PIN
        {
            get { return pin; }
            set { pin = value; NotifyPropertyChanged(); }
        }

        private string mobile;
        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; NotifyPropertyChanged(); }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; NotifyPropertyChanged(); }
        }

        private string otherDescription;
        public string OtherDescription
        {
            get { return otherDescription; }
            set { otherDescription = value; NotifyPropertyChanged(nameof(OtherDescription)); }
        }

        private string gstno;

        public string GSTNo
        {
            get { return gstno; }
            set { gstno = value; }
        }

        private string billFooter;

        public string BillFooter
        {
            get { return billFooter; }
            set { billFooter = value; }
        }



    }
}
