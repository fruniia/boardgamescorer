namespace BoardGameScoring.Domain.Interfaces;

public interface IAuditInfo : IEntity
{
	int? CreatedBy { get; set; }
	DateTime? CreatedDate { get; set; }
	int? UpdatedBy { get; set; }
	DateTime? UpdatedDate { get; set; }
}
