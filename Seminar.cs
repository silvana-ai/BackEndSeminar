using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SignToSeminarBackEnd
{
    public enum Status
    {
        Kommande,
        Inställd,
        Ferdigt
    }
    public class Seminar
    {
        public int Id { get; set; }
        public string Namn { get; set; }
        public string Beskrivning { get; set; }
        public DateTime Datum { get; set; }
        public int Maxplats { get; set; }
        public Status status { get; set; }
        public List<Visitor> visitors { get; set; }

    }
}

