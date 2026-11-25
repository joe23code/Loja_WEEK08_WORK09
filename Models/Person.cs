using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_WEEK08_WORK09.Models
{
    public abstract class Person

    {
        protected int id;
        public string LastName;
        public string FirstName;
        public string MiddleName;
        public string Address;
        public DateTime Birthdate;
        public string Gender;

        public void setID(int id) {
            this.id = id;

        }
        public string GetFullName()
        {
            return $"{this.LastName}, {this.FirstName}";
        }
    }
}
