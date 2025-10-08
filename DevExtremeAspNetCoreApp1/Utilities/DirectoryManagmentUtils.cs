namespace DevExtremeAspNetCoreApp1.Utilities
{
    public static class DirectoryManagmentUtils
    {
        public static string GetDocumentSampleFolderPath(HttpContext context)
        {
            // Assuming a folder named "Documents" exists in the root directory of the application.  
            return Path.Combine("Data","DIT");
        }
    }
}
