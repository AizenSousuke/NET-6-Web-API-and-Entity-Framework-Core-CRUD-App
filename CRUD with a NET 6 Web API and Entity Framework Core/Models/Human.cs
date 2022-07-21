using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_with_a_NET_6_Web_API_and_Entity_Framework_Core.Models
{
    public class Human
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Human> Parents { get; set; }
        public virtual ICollection<Human> Childrens { get; set; }
    }
}
