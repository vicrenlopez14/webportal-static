using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace ProFind.Lib.Global.Helpers
{
    public static class StorageFileToByteArrayExtension
    {
        public static async Task<byte[]> ToByteArrayAsync(this StorageFile file)
        {
            // Read the bytes
            byte[] result;
            using (Stream stream = await file.OpenStreamForReadAsync())
            {
                using (var memoryStream = new MemoryStream())
                {

                    stream.CopyTo(memoryStream);
                    result = memoryStream.ToArray();
                }
            }

            return result;
        }
    }
}
