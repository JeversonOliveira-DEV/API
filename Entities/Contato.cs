using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Dio.Entities
{
    public class Contat
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set;}
    }
}