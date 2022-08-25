using System;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage;

namespace ProFind.Lib.Global.Helpers
{
    public static class StorageFileToByteArrayExtension
    {
        public static async Task<byte[]> ToByteArrayAsync(this StorageFile file)
        {
            using (var inputStream = await file.OpenSequentialReadAsync())
            {
                var readStream = inputStream.AsStreamForRead();

                var byteArray = new byte[readStream.Length];
                await readStream.ReadAsync(byteArray, 0, byteArray.Length);
                return byteArray;
            }
        }
    }
}