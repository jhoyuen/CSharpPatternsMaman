using FileUploaderProxy;

IFileUploader uploader = new FileUploaderProxy.FileUploaderProxy();

Console.WriteLine("Enter full path of file to upload:");
var path = Console.ReadLine();

while(string.IsNullOrEmpty(path))
{
    if (File.Exists(path))
        break;
    Console.WriteLine("No file path specified. Enter full path of file to upload:");
    path = Console.ReadLine();
}

uploader.Upload(path);