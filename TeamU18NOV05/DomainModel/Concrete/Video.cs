﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamU18NOV05.DomainModel.Abstract;

namespace TeamU18NOV05.DomainModel.Concrete
{
    class Video : IOperate
    {
        public Video()
        {

        }

        string ID { get; set; }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
