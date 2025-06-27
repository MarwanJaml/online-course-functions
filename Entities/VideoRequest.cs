using OnilneCourseFunctions.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("VideoRequest")]
public partial class VideoRequest
{
    [Key]
    public int VideoRequestId { get; set; }
    public int UserId { get; set; }
    [StringLength(50)]
    public string Topic { get; set; } = null!;
    [StringLength(50)]
    public string SubTopic { get; set; } = null!;
    [StringLength(200)]
    public string ShortTitle { get; set; } = null!;
    [StringLength(4000)]
    public string RequestDescription { get; set; } = null!;
    [StringLength(4000)]
    public string? Response { get; set; }
    [StringLength(2000)]
    public string? VideoUrls { get; set; }
    [StringLength(50)]
    public string? RequestStatus { get; set; } // Add this property

    [ForeignKey("UserId")]
    [InverseProperty("VideoRequests")]
    public virtual UserProfile User { get; set; } = null!;
}