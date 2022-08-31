using Syncfusion.Pdf.Parsing;
using System;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace ProFind.Lib.Global.Helpers
{
    public static class PickFileHelper
    {
        public static async Task<StorageFile> PickImage()
        {
            /* var picker = new Windows.Storage.Pickers.FileOpenPicker
             {
                 ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail,
                 SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary
             };
             picker.FileTypeFilter.Add(".jpg");
             picker.FileTypeFilter.Add(".jpeg");
             picker.FileTypeFilter.Add(".png");

             var file = await picker.PickSingleFileAsync();
             return file;*/

            //Opens a file picker.
            var picker = new FileOpenPicker();
            picker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            picker.ViewMode = PickerViewMode.List;
            //Filters PDF files in the documents library.
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".png");
            var file = await picker.PickSingleFileAsync();
            if (file == null) return null;

            return file;
        }

        public static async Task<byte[]> PickImageBytes()
        {
            var file = await PickImage();
            if (file == null) return null;
            var stream = await file.OpenStreamForReadAsync();
            var bytes = new byte[stream.Length];
            await stream.ReadAsync(bytes, 0, (int)stream.Length);
            return bytes;
        }

        public static async Task<PdfLoadedDocument> PickPDF()
        {
            //Opens a file picker.
            var picker = new FileOpenPicker();
            picker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            picker.ViewMode = PickerViewMode.List;
            //Filters PDF files in the documents library.
            picker.FileTypeFilter.Add(".pdf");
            var file = await picker.PickSingleFileAsync();
            if (file == null) return null;
            //Reads the stream of the loaded PDF document.
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            Stream fileStream = stream.AsStreamForRead();
            byte[] buffer = new byte[fileStream.Length];
            fileStream.Read(buffer, 0, buffer.Length);
            //Loads the PDF document.
            PdfLoadedDocument loadedDocument = new PdfLoadedDocument(buffer);
            return loadedDocument;
        }
    }
}