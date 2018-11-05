using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamU18NOV05.DomainModel.Abstract;

namespace TeamU18NOV05.DomainModel.Concrete
{
    class BluRay : IOperate
    {
        public BluRay()
        {

        }

        // Regimal (?)
        string Regimal { get; set; }

        public string Play()
        {
            return "Bluray is playing!";
        }

        public string Stop()
        {
            return "Bluray has stopped!";
        }
    }
}
