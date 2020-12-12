using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hub.Entities
{
    public class Country
    {
        public Country()
        {
            Provinces = new List<Province>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(10)]
        public string Code { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(10)]
        public string PhoneCode { get; set; }
        public ICollection<Province> Provinces { get; set; }
    }
}
