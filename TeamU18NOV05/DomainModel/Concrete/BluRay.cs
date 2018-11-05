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
            return "Blu-ray is playing!";
        }

        public string Stop()
        {
            return "Blu-ray has stopped!";
        }

        public string Blue()
        {
            return "Blu-ray is now Blue-ray";
        }
    }
}
