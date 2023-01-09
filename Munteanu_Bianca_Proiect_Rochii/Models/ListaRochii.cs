using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Munteanu_Bianca_Proiect_Rochii.Models
{
    public class ListaRochii
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(250), Unique]
        public string Denumire { get; set; }
        public string Marime {get; set;}

        public decimal Pret { get; set; }

        public string Designer { get; set; }
        public DateTime Date { get; set; }
    }
}
