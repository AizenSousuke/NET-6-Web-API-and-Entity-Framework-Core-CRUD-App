using Swashbuckle.AspNetCore.Annotations;
using System.Text.Json.Serialization;

namespace CRUD_with_a_NET_6_Web_API_and_Entity_Framework_Core.Models
{
    public class SuperHero
    {
        [SwaggerSchema(ReadOnly = true)]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
        public Weapon? Weapon { get; set; } = null;
    }
}
