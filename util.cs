using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

namespace WebApp_FS
{
    public class util
    {
        static Rootobject r { get; set; }
        public static string TargetFilePath { get; set; }

        public static void MonitorInput()
        {
            if (!File.Exists(TargetFilePath))
                return;
            //set the Root object
            r = Deserialize(TargetFilePath);
        }

        static Rootobject Deserialize(string TargetFilePath)
        {
            var jsonCotent = File.ReadAllText(TargetFilePath);
            return JsonConvert.DeserializeObject<Rootobject>(jsonCotent);
        }

        public static void Change(string Hours, string NukaColaQuantum, string Lunchbox)
        {
            if (!string.IsNullOrEmpty(NukaColaQuantum))
                r.vault.storage.resources.NukaColaQuantum = int.Parse(NukaColaQuantum);
            if (!string.IsNullOrEmpty(Lunchbox))
            {
                r.vault.storage.resources.Lunchbox = int.Parse(Lunchbox);
                r.vault.LunchBoxesCount = int.Parse(Lunchbox);
            }
            if (!string.IsNullOrEmpty(Hours))
            {
                r.timeMgr.timeSaveDate = AdjustTime(int.Parse(Hours));
                if (r.timeMgr.timeGameBegin > r.timeMgr.timeSaveDate)
                    r.timeMgr.timeGameBegin = r.timeMgr.timeSaveDate;
            }

            UpdateFile();
        }

        static void UpdateFile()
        {
            var temp = JsonConvert.SerializeObject(r);
            if (File.Exists(TargetFilePath))
                File.Delete(TargetFilePath);
            File.WriteAllText(TargetFilePath, temp);
        }

        static long AdjustTime(int hours)
        {
            var TimeInt = (int)(r.timeMgr.time);
            var timeLength = TimeInt.ToString().Length;

            var delta = r.timeMgr.timeSaveDate - r.timeMgr.timeGameBegin;
            var deltaLength = delta.ToString().Length;

            var tailLength = deltaLength - timeLength;
            var seconds = hours * 3600;
            var timeSaveDateString = r.timeMgr.timeSaveDate.ToString();
            var valid = timeSaveDateString.Substring(0, timeSaveDateString.Length - tailLength);
            var tail = timeSaveDateString.Substring(timeSaveDateString.Length - tailLength, tailLength);
            var validAfter = long.Parse(valid) - seconds;
            return long.Parse(validAfter.ToString() + tail);
        }

        public static void OpenSaveLocation(string path)
        {
            if (Directory.Exists(path))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("explorer.exe", path);
                Process.Start(startInfo);
            }

        }
    }
}
