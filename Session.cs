using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelvetEyrbrown.Models;

namespace VelvetEyrbrown
{
    public class Session
    {
        private Session()
        {
            context = new ZadanieContext();
        }

        private static Session? instance;
        public static Session Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Session();
                }
                return instance;
            }
        }

        private ZadanieContext context;
        public ZadanieContext Context => context;
    }
}
