using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUploaderProxy;

/// <summary>
/// The Real Uploader (Actual Logic)
/// </summary>
public class RealFileUploader : IFileUploader
{
    public void Upload(string filePath)
    {
        string fileName = Path.GetFileName(filePath);
        string binDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string destinationPath = Path.Combine(binDirectory, "UploadedFiles");

        // Ensure upload target folder exists
        Directory.CreateDirectory(destinationPath);

        string finalPath = Path.Combine(destinationPath, fileName);

        File.Copy(filePath, finalPath, overwrite: true);

        Console.WriteLine($"Uploaded '{fileName}' to: {finalPath}");
    }
}
