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
            throw new NotImplementedException();
        }

        public string Stop()
        {
            throw new NotImplementedException();
        }
    }
}
