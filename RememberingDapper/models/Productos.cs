using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//dapper
using Dapper;
using Dapper.Contrib.Extensions;

namespace RememberingDapper.models
{
    [Table("productos")]
    public class Productos:Connection
    {
        public int id { get; set; }
        public string nombre { get; set; } = "";
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public int categoriaId { get; set; }


        [Write(false)]
        public Categoria categoria { get; set; } = new Categoria();

        public List<Productos> getAll()
        {
            var res = holaConnection.GetAll<Productos>().ToList();

            var prods  = res.ConvertAll(p =>
            {
                categoria.id = p.categoriaId; 
                p.categoria = categoria.get();
                return p;
            });
            return prods;
        }
        public Productos get()
        {
            var res = holaConnection.Get<Productos>(id);
            return res;
        }

        public long create()
        {
            var res = holaConnection.Insert<Productos>(this);
            return res;
        }
        public bool update()
        {
            var res = holaConnection.Update<Productos>(this);
            return res;
        }
        public bool delete()
        {
            var res = holaConnection.Delete<Productos>(this);
            return res;
        }
    }
}
