using CRUD_with_a_NET_6_Web_API_and_Entity_Framework_Core.Enums;
using Swashbuckle.AspNetCore.Annotations;

namespace CRUD_with_a_NET_6_Web_API_and_Entity_Framework_Core.Models
{
    public class Weapon
    {
        [SwaggerSchema(ReadOnly = true)]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public WeaponType? Type { get; set; } = null;
        public int Damage { get; set; } = 0;
    }
}
