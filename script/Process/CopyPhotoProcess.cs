using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VRCPhotoArrange.Process
{
    /// <summary>
    /// Processes to copy data.
    /// </summary>
    class CopyPhotoProcess
    {
        public async Task CopyPhotos(string copyFilePath, List<FileInfo> images)
        {
            DirectoryInfo CopyTargetDir = new DirectoryInfo(copyFilePath);
            try
            {
                CopyTargetDir.Create();
            }
            catch (Exception e)
            {
                CopyTargetDir.Delete();
                CopyTargetDir.Create();
            }

            foreach (var image in images)
            {
                try
                {
                    await Task.Run(() => image.CopyTo(copyFilePath + @"\" + image.Name, true));
                }
                catch (Exception e)
                {
                    //noop

                }
            }
        }
    }
}
