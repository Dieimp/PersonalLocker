using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLocker.Model
{
    public class LockerModel
    {
        public string sysName { get; set; }
        public string sysLogin { get; set; }
        public string sysPasswrod { get; set; }
        public string sysPath { get; set; }

        public LockerModel(string sysName, string sysLogin, string sysPasswrod, string sysPath)
        {
            this.sysName = sysName;
            this.sysLogin = sysLogin;
            this.sysPasswrod = sysPasswrod;
            this.sysPath = sysPath;
        }

        public bool pathExists(string SysPath)
        {
            try
            {
                return !string.IsNullOrEmpty(SysPath) && File.Exists(SysPath);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<LockerModel> GetContentsInsideOfLocker(string SysPath)
        {
            List<LockerModel> contents = new List<LockerModel>();

            try
            {
                using (var reader = new StreamReader(SysPath))
                {
                    var headerLine = reader.ReadLine();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        contents.Add( new LockerModel(sysName = values[0].ToString(), sysLogin = values[1].ToString(), sysPasswrod = values[2].ToString(), sysPath = sysPath ));

                        

                    }
                }
                    return contents;
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine("Error " + e.Message);
                throw;
            }
        }
    }
}
