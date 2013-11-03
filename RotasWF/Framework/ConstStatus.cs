using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    class ConstStatus
    {
        public const int Pago = 1;
        public const int Devendo = 2;

        public static string GetDescricao(int id) 
        {
            return id == 1 ? "Pago" : "Devendo";
        }
    }
}
