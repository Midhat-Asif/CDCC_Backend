using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDCC_Backend.Models;

public class CdccBaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column,MaxLength(36)]
    public string Id { get; set; }
    public DateTime? CreatedOn { get; set; }
    [ConcurrencyCheck]
    public DateTime? UpdatedOn { get; set; }
}