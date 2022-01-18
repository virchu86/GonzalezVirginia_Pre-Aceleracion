using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_1.Comments
{
    internal class Comments
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }

        public int UsuarioId { get; set; }
    }
}
