using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Munteanu_Bianca_Proiect_Rochii.Models
{
    public class ListProduct
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(ListaRochii))]
        public int ListaRochiiID { get; set; }
        public int ProductID { get; set; }
    }
}
