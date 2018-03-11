using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Element 
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; NotifyPropertyChanged(); }
        }

        private bool isDeleted;

        public bool IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; NotifyPropertyChanged(); }
        }

        private DateTime? createdDate;
        public DateTime? CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; NotifyPropertyChanged(); }
        }

        private DateTime? modifiedDate;
        public DateTime? ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; NotifyPropertyChanged(); }
        }

        private DateTime? deletedDate;
        public DateTime? DeletedDate
        {
            get { return deletedDate; }
            set { deletedDate = value; NotifyPropertyChanged(); }
        }

        private string user;        

        public string User
        {
            get { return user; }
            set { user = value; NotifyPropertyChanged(); }
        }

        public Element()
        {
            IsDeleted = false;
            user = Environment.UserName;
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;            
        }

       // public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName]string propertyName=null)
        {
           // if(PropertyChanged!=null)
           // {
           //     PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
          //  }
        }

        public virtual void Save()
        {

        }

        public virtual void Delete()
        {

        }

        public virtual Element GetElement(int Id)
        {
            return null;
        }
    }
}
