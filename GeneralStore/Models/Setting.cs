namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Setting : INotifyPropertyChanged
    {
        private string dateTimeFormat;

        public string DateTimeFormat
        {
            get { return dateTimeFormat; }
            set { dateTimeFormat = value; OnPropertyChanged("DateTimeFormat"); }
        }

        private int decimalPlaces;

        public int DecimalPlaces
        {
            get { return decimalPlaces; }
            set { decimalPlaces = value; OnPropertyChanged("DecimalPlaces"); }
        }

        private int decimalPlacesQuantity;

        public int DecimalPlacesQuantity
        {
            get { return decimalPlacesQuantity; }
            set { decimalPlacesQuantity = value; OnPropertyChanged("DecimalPlacesQuantity"); }
        }

        private bool roundOff;

        public bool RoundOff
        {
            get { return roundOff; }
            set { roundOff = value; OnPropertyChanged("RoundOff"); }
        }

        private int title;

        public int Title
        {
            get { return title; }
            set { title = value; OnPropertyChanged("Title"); }
        }
      
        private static readonly Setting _setting = new Setting();

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this,new PropertyChangedEventArgs(propertyName));
            }
        }

        private Setting()
        {

        }
        public static Setting setting
        {
            get
            {
                return _setting;
            }
        }
    }
}
