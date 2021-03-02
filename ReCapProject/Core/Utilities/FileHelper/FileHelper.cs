using Core.Utilities.Result;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Core.Utilities.FileHelper
{
    public class FileHelper
    {
        public static string newPath(IFormFile file)
        {
            FileInfo fileInfo = new FileInfo(file.FileName);
            string fileExtension = fileInfo.Extension;

            var newPath = Guid.NewGuid().ToString() + "_" 
                + DateTime.Now.Month + "_" 
                + DateTime.Now.Day + "_" 
                + DateTime.Now.Year 
                + fileExtension;

            string result = $@"wwwroot\Images\{newPath}";
            return result;
        }

        public static string Add(IFormFile file)
        {
            var result = newPath(file);

            try
            {
                var sourcePath = Path.GetTempFileName();

                if (file.Length > 0)
                {
                    using (var stream = new FileStream(sourcePath, FileMode.Create))
                        file.CopyTo(stream);
                }
                File.Move(sourcePath, result);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return result;
        }

        public static IResult Delete(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
            return new SuccessResult();
        }

        public static string Update(string sourcePath, IFormFile file)
        {
            var result = newPath(file);

            try
            {
                if (sourcePath.Length > 0)
                {
                    using (var stream = new FileStream(result, FileMode.Create))
                        file.CopyTo(stream);
                }
                File.Delete(sourcePath);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return result;
        }
    }
}
