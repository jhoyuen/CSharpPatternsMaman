namespace FileUploaderProxy;

public class FileUploaderProxy : IFileUploader
{
    private readonly RealFileUploader _realUploader = new();
    private readonly long _maxAllowedSizeInBytes = 5 * 1024 * 1024; // 5 MB

    public void Upload(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Error: File does not exist.");
            return;
        }

        var fileInfo = new FileInfo(filePath);
        Console.WriteLine($"[LOG] Preparing to upload: {fileInfo.Name}, Size: {fileInfo.Length} bytes");

        if (fileInfo.Length > _maxAllowedSizeInBytes)
        {
            Console.WriteLine("Error: File size exceeds 5 MB limit.");
            return;
        }

        // Additional access checks can go here
        _realUploader.Upload(filePath);
    }
}
