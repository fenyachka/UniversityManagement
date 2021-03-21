using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Comands.StudentCommands.Models
{
    public class StudentUpdateRequest
    {
        private string _privateNumber;
        private string _firstName;
        private string _lastname;
        private string _address;
        public int Id { get; set; }
        public string PrivateNumber
        {
            get => _privateNumber;
            set => _privateNumber = ReplaceEmtyWithNull(value);
        }
        public string Firstname 
        {
            get => _firstName;
            set => _firstName = ReplaceEmtyWithNull(value);
        }
        public string Lastname 
        {
            get => _lastname;
            set => _lastname = ReplaceEmtyWithNull(value);
        }
        public string Address 
        {
            get => _address;
            set => _address = ReplaceEmtyWithNull(value);
        }

        private string ReplaceEmtyWithNull(string value)
        {
            return string.IsNullOrEmpty(value) ? null : value;
        }
    }

}
