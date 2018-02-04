using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyGears.Model
{
    [Serializable]
    public class Questionary
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int Id { get; set; }
    }
}