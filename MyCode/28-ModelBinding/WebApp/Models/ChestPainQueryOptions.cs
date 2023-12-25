namespace WebApp.Models;

public class ChestPainQueryOptions
{
    public string? Pvids { get; set; }
    public string? ChestPainReportIds { get; set; }
    public string? RegisterId { get; set; } = default;
    public string? Name { get; set; } = default;
    public string? Gender { get; set; } = default;
    public int? AgeBegin { get; set; }
    public int? AgeEnd { get; set; }
    public string? CpDiagnosisCode { get; set; } = default;
    public string? CwComingWayCode { get; set; } = default;
    public DateTime? CreateDocTimeBegin { get; set; }
    public DateTime? ReportUploadTimeBegin { get; set; }
    public DateTime? CreateDocTimeEnd { get; set; }
    public DateTime? ReportUploadTimeEnd { get; set; }
    public int? FinishPointNumberBegin { get; set; }
    public int? ProblemCheckNumberBegin { get; set; }
    public int? FinishPointNumberEnd { get; set; }
    public int? ProblemCheckNumberEnd { get; set; }
    public string? EnterStatus { get; set; }
    public int? Status { get; set; }
}