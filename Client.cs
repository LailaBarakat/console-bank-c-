using System;

namespace console_bank_c_
{
    public class Client
    {
        private int _Id;
        public int Id
        {

        get { return _Id;  }
        set { _Id = value; }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private DateTime _Date;
        public DateTime Date
        {
            get { return _Date; }
            set
            { _Date = value; }
        }

        public Client(int Id, string Name, DateTime Date)
        {
            this.Id = Id;
            this.Name = Name;
            this.Date = Date;
        }
        
    }
}