using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DummyServicio
{
    public class Servicio : IServicio
    {
        public String Saludo(String nombre)
        {
            return nombre + " te saludamos desde WCF";
        }
    }
}
