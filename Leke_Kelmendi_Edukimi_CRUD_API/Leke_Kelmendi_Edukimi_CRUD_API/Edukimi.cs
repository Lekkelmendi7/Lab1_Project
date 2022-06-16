using System.ComponentModel.DataAnnotations;
namespace Leke_Kelmendi_Edukimi_CRUD_API
{
    public class Edukimi
    {
        [Key]
        public int ID_Puntori { get; set; }
        public String Emri_Puntorit { get; set; } = string.Empty;
        public String Mbiemri_Puntorit { get; set; } = string.Empty;
        public String Kolegji { get; set; } = string.Empty;
        public String VitiFillimit_Studimit { get; set; } = string.Empty;
        public String VitiMbarimit_Studimit { get; set; } = string.Empty;
        public String Niveli_Studimit { get; set; } = string.Empty;
        public int ECTS { get; set; }
        public double GPA { get; set; }

    }
}
