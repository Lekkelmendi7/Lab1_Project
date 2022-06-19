using System.ComponentModel.DataAnnotations;
namespace Leke_Kelmendi_Kontrata_CRUD
{
    public class Kontrata
    {
        [Key]
        public int ID_Puntori { get; set; }
        public String Emri_Puntorit { get; set; } = string.Empty;
        public String Mbiemri_Puntorit { get; set; } = string.Empty;
        public String Kompania { get; set; } = string.Empty;
        public String Pozita_Punes { get; set; } = string.Empty;
        public String Pronari_Kompanise { get; set; } = string.Empty;
        public String Kohezgjatja_Kontrates { get; set; }= string.Empty;

    }
}
