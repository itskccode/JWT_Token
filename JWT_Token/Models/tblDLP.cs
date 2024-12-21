using System.ComponentModel.DataAnnotations;

namespace JWT_Token.Models
{
    public class tblDLP
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

    }
}
