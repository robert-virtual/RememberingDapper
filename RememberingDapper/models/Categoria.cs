using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RememberingDapper.models
{
    [Table("categorias")]
    public class Categoria:Connection
    {
        public int id { get; set; }
        public string nombre { get; set; } = "";
        public bool activo{ get; set; } 
        public Categoria get()
        {
            var res = holaConnection.Get<Categoria>(id);
            return res;
        }
        public override string ToString()
        {
            return nombre;
        }
    }
}
