using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Authors
    {
        public string FullName { get; set; }
        public int Age { get; set; }

        //public Authors(string _fullname, int )
        //{
        //    FullName = _fullname;

        //}

        public override string ToString()
        {
            return $"AuthorsName: {this.FullName} - Age: {this.Age}";
        }
    }
}
