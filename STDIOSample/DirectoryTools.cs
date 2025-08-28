using System.ComponentModel;
using ModelContextProtocol.Server;

namespace STDIOSample.Tools;

public class FileDetails
{
    public string Name { get; set; } = string.Empty;
    public string Extension { get; set; } = string.Empty;
    public DateTime CreationTime { get; set; }
    public DateTime LastModifiedTime { get; set; }
}

[McpServerToolType]
public class DirectoryTools
{
    private string GetDownloadsPath()
    {
        // Get the downloads folder path based on the operating system
        if (OperatingSystem.IsWindows())
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        }
        else if (OperatingSystem.IsMacOS() || OperatingSystem.IsLinux())
        {
            // In Unix-like systems, Downloads is typically in the home directory
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        }
        throw new PlatformNotSupportedException("Current operating system is not supported.");
    }

    [McpServerTool, Description("List all files in the Downloads directory")]
    public IEnumerable<FileDetails> ListDownloadsDirectory()
    {
        try
        {
            var downloadsPath = GetDownloadsPath();
            var directory = new DirectoryInfo(downloadsPath);

            if (!directory.Exists)
            {
                return Enumerable.Empty<FileDetails>();
            }

            return directory.GetFiles()
                          .Select(file => new FileDetails
                          {
                              Name = file.Name,
                              Extension = file.Extension,
                              CreationTime = file.CreationTime,
                              LastModifiedTime = file.LastWriteTime
                          })
                          .OrderBy(f => f.Name);
        }
        catch (Exception)
        {
            // Log the error if needed
            return Enumerable.Empty<FileDetails>();
        }
    }

    [McpServerTool, Description("Delete all files in the Downloads directory")]
    public bool CleanDownloadsDirectory()
    {
        try
        {
            var downloadsPath = GetDownloadsPath();
            var directory = new DirectoryInfo(downloadsPath);

            if (!directory.Exists)
            {
                return false;
            }

            var deletedCount = 0;
            var errors = new List<string>();

            foreach (var file in directory.GetFiles())
            {
                if (!file.Name.StartsWith(".")) // Skip system files like .DS_Store
                {
                    try
                    {
                        file.Delete();
                        deletedCount++;
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }

            if (errors.Any())
            {  
                return false;
            }

             return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}
