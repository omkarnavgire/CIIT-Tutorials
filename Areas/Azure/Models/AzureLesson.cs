namespace CIITEdge.Areas.Azure.Models;

public class AzureLesson
{
    public string ModuleKey { get; set; } = "";
    public string ModuleTitle { get; set; } = "";
    public string Title { get; set; } = "";
    public string Controller { get; set; } = "";
    public string Action { get; set; } = "";
    public int Number { get; set; }
    public int Total { get; set; }
    public string Kind { get; set; } = string.Empty;
    public CIITEdge.Areas.Azure.AzureTopic Topic { get; set; } = null!;
}
