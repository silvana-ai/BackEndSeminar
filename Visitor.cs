using System.ComponentModel.DataAnnotations;

namespace SignToSeminarBackEnd
{
    public class Visitor
    {
        public int Id { get; set; }
        [Required]
        public string Förnamn { get; set; }
        [Required]
        public string Efternamn { get; set; }

        
        [Required]
        public string Mail { get; set; }
        public string Adress { get; set; }
        [Phone]
        public string Tel { get; set; }
        public int seminarId { get; set; }


    }
}