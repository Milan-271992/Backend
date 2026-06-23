using Core.Models;
using System.Text;
using System.Text.RegularExpressions;

namespace Core.Utils
{
    public class FileUtility
    {
        public string GetFileExtensionFromBase64(string base64String)
        {
            byte[] fileBytes = Convert.FromBase64String(base64String);
            var fileSignatures = new Dictionary<string, string>
        {
            { "FFD8", ".jpg" },     // JPEG
            { "89504E47", ".png" }, // PNG
            { "47494638", ".gif" }, // GIF
            { "25504446", ".pdf" }, // PDF
            { "504B0304", ".zip" }, // ZIP
            { "504B34", ".docx" },  // DOCX (part of ZIP family)
            { "494433", ".mp3" },   // MP3
        };

            string fileHeader = BitConverter.ToString(fileBytes.Take(4).ToArray()).Replace("-", "");

            foreach (var signature in fileSignatures)
            {
                if (fileHeader.StartsWith(signature.Key))
                {
                    return signature.Value;
                }
            }

            return "";

        }

       
    }
}
