using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VRCPhotoArrange.Process
{
    /// <summary>
    /// Class of processes for classifying by event.
    /// </summary>
    class ClassificationProcess
    {
        public List<FileInfo> ClassifyImages(string readFilePath, 
                                   string specifiedStartTime, 
                                   string specifiedEndTime, 
                                   string specifiedWeekday)
        {
            DirectoryInfo di = new DirectoryInfo(readFilePath);

            TimeSpan ts_start = TimeSpan.Parse(specifiedStartTime);
            TimeSpan ts_end = TimeSpan.Parse(specifiedEndTime);

            var images = new List<FileInfo>();

            if (specifiedWeekday == "Everyday") {
                images = di.EnumerateFiles("VRChat_????x????_*_*.png")
                        .Where(x => TimeSpan.Parse(x.Name.Split('_')[3].Split('.')[0].Replace('-', ':')).TotalSeconds - ts_start.TotalSeconds >= 0
                             && TimeSpan.Parse(x.Name.Split('_')[3].Split('.')[0].Replace('-', ':')).TotalSeconds - ts_end.TotalSeconds < 0)
                        .ToList();
            }
            else {
                images = di.EnumerateFiles("VRChat_????x????_*_*.png")
                         .Where(x => DateTime.Parse(x.Name.Split('_')[2]).DayOfWeek.ToString() == specifiedWeekday
                             && TimeSpan.Parse(x.Name.Split('_')[3].Split('.')[0].Replace('-', ':')).TotalSeconds - ts_start.TotalSeconds >= 0
                             && TimeSpan.Parse(x.Name.Split('_')[3].Split('.')[0].Replace('-', ':')).TotalSeconds - ts_end.TotalSeconds < 0)
                         .ToList();
            }

            return images;
        }
    }
}
