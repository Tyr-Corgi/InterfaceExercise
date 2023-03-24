using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface ICompany
    {
        public string CorpName { get; set; }
        public bool Bankrupt { get; set; }
    }
}
