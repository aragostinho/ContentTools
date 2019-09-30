using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentTools.Server.Components
{
    public class ListResultResponseBody<T> where T : class
    {
        private List<Error> _listOfErrors = new List<Error>();

        public List<T> _results { get; set; }
        public List<Error> _errors { get { return _listOfErrors; } set { _listOfErrors = value; } }
        

    }
}
