using System.ComponentModel.DataAnnotations.Schema;

namespace BikeHub.Web.Models.Domain
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        [ForeignKey("Make")]
        public int MakeId { get; set; }
        public Make Make { get; set; }
    }
}
