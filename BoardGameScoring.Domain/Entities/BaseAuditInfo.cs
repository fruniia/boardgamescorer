namespace BoardGameScoring.Domain.Entities;
public abstract class BaseAuditInfo : BaseEntity, IAuditInfo
{
	public int? CreatedBy { get; set; }
	public DateTime? CreatedDate { get; set; }
	public int? UpdatedBy { get; set; }
	public DateTime? UpdatedDate { get; set; }
}
