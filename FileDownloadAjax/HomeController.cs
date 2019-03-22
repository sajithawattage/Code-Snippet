[HttpGet]
public FileResult DownloadFile()
{
    var file = System.IO.File.ReadAllBytes(@"C:\StacloverflowAnsers\App_Data\9239-X.pdf");
    return new FileContentResult(file, "application/pdf");
}