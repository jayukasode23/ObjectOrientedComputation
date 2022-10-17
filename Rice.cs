using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventaryManagementProgram
{
    public class Rice
    {
        public List<TypeofRice> typeofRice;
        public List<TypeofPulses> typeofPulses;
        public List<TypeofWheat> typeofWheat;

    }
    public class TypeofRice
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypeofPulses
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypeofWheat
    {
        public string name;
        public int weight;
        public int price;
    }
}
    