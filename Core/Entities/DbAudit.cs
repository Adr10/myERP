using System.ComponentModel.DataAnnotations;

namespace myERP.Core.Entities
{
    public class DbAudit
    {
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdateAt { get; set; }

        [StringLength(50)]
        public string updatedBy { get; set; }
    }
}
