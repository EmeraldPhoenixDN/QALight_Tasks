using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QALight_Task_1
{
    public class Mobile
    {
        private string _phoneModel = "Pixel 7";
        private string _osName = "Android";
        private int _osVersion = 14;
       
        public void ShowPhoneName()
        {
            Console.WriteLine($"Phone name is {_phoneModel}");
        }

        public void ShowOsName()
        {
            Console.WriteLine($"OS name is {_osName}");
        }

        public void ShowOsVerison()
        {
            Console.WriteLine($"OS version is {_osVersion}");
        }

        public int GetOsVersion()
        {
            return _osVersion;
        }

    }
}
