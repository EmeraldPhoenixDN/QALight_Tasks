using System;

namespace QALight_Task_1
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            var mobileAndroid = new Mobile();
            
            //Call mobile`s methods
            mobileAndroid.ShowPhoneName();
            mobileAndroid.ShowOsName();

            //If else block to choose needed method
            Console.WriteLine("Type 1 if you want to get OS version value from void class.\nType 2 if you want to get OS version value from int class: ");
            var choice = Convert.ToInt32(Console.ReadLine());
            
            if (choice == 1)
            {
                mobileAndroid.ShowOsVerison();
            }

            else
            {
                var osVersion = mobileAndroid.GetOsVersion();
                Console.WriteLine($"OS version value from int method: {osVersion}");
            }


        }
    }
}
