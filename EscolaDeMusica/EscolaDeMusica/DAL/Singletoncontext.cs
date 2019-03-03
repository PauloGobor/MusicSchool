using EscolaDeMusica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeMusica.DAL
{
    class SingletonContext
    {

        private static Context ctx;

        private SingletonContext()
        {

        }

        public static Context GetInstance()
        {
            if (ctx == null)
            {
                ctx = new Context();
            }
            return ctx;
        }

    }
}
