using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{
    public class customer
    {
        // properties 
        public int customerId { get; private set; }
        public string emailAddress { get; set; }
        public string Firstname { get; set; }

        private string _Lastname; // backing code
        public string Lastname
        {
            get
            {
                return _Lastname;
            }
            set 
            {
                _Lastname = value;
            }
        }
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Lastname)) isValid = false;
            if (string.IsNullOrWhiteSpace(emailAddress)) isValid = false;

            return isValid;
        }
    }
    
}
