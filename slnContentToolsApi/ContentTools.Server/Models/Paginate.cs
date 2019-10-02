using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ContentTools.Net.Models
{
    public class Paginate
    {
      
        public int Limit { get; set; }
      
        public int Offset { get; set; }

        public Paginate(int limit, int offset)
        {
            this.Limit = limit;
            this.Offset = offset;
        }


    }
}
