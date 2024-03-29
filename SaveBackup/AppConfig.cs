public class AppConfig
{
    public string SaveLocation { get; set; } = string.Empty;
    public string BackupLocation { get; set; } = string.Empty;
    public bool UseGit { get; set; } = false;
    public bool Verbose { get; set; } = false;
    public bool PauseOnFinish { get; set; } = false;
}