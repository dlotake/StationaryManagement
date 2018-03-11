namespace Store.Models
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class Customer : Element/*, INotifyPropertyChanged*/
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

        private Gender gender;
        public Gender Gender
        {
            get { return gender; }
            set { gender = value; NotifyPropertyChanged(); }
        }

        private string otherDescription;
        public string OtherDescription
        {
            get { return otherDescription; }
            set { otherDescription = value; NotifyPropertyChanged(nameof(OtherDescription)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected new void NotifyPropertyChanged([CallerMemberName]string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public override void Save()
        {
            
        }

        public override void Delete()
        {
            
        }

        public override Element GetElement(int Id)
        {
            return base.GetElement(Id);
        }
    }
}
