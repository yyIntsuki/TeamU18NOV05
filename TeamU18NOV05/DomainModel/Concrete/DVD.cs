using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamU18NOV05.DomainModel.Abstract;

namespace TeamU18NOV05.DomainModel.Concrete
{
    class DVD : IOperate
    {
        public DVD()
        {

        }

        string SerialNumber { get; set; }

        public string Play()
        {
            return "DVD is playing!";
        }

        public string Stop()
        {
            return "DVD has stopped!";
        }

        public string Suprise()
        {
            return "DVD wants to be BluRay...";
        }
    }
}
