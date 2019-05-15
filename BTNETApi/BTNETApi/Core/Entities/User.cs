using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTNETApi.Core.Entities
{
    [Table("users")]
    public class User
    {
        [Key]
        [Column("us_id")]
        public int Id { get; set; }
        [Column("us_username")]
        public string Username { get; set; }
        [Column("us_password")]
        public string Password { get; set; }
        [Column("us_firstname")]
        public string FirstName { get; set; }
        [Column("us_lastname")]
        public string LastName { get; set; }
    }
}
