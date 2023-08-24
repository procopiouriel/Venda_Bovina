using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Onibus
{
    class Empresa
    {
        public string Nome { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
        public string JsonSer(Empresa empresa)
        {
            return JsonConvert.SerializeObject(empresa);
        }

        public static Empresa JsonDes(string Json)
        {
            return JsonConvert.DeserializeObject<Empresa>(Json);

        }

    }
}
