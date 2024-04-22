using Assignment5;
using Directory = Assignment5.Directory;
using File = Assignment5.File;

class program
{
    public static void Main(string[] args)
    {
        var localProvider = new LocalStorageProvider();
        var cloudProvider = new CloudStorageProvider();

        var rootDirectory = new Directory("Root");
        var documents = new Directory("Documents");
        var photo = new File("Photo.jpg", localProvider);
        var report = new File("Report.docx", cloudProvider);

        rootDirectory.Add(documents);
        documents.Add(photo);
        documents.Add(report);

        var encryptedPhoto = new EncryptionDecorator(photo);
        var compressedReport = new CompressionDecorator(report);

        rootDirectory.Display();

        encryptedPhoto.Display();
        compressedReport.Display();

        photo.SaveData("Photo Data");
        report.SaveData("Report Data");
    }
}