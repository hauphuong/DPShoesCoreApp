using DPShoesCoreApp.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DPShoesCoreApp.Data.Entities
{
    [Table("Footers")]
    public class Footer : DomainEntity<string>
    {
        [Required]
        public string Content { set; get; }
    }
}
