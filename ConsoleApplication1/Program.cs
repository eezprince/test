using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Tts.ServiceProvider;


namespace ConsoleApplication1
{
    class Program
    {
        static void Test()
        {
            ServiceProvider serviceProvider = null;
            using (serviceProvider = new ServiceProvider(Language.ZhCN,
                @"C:\Users\tianhz\Documents\Visual Studio 2015\Projects\Hackthon\Hackthon\bin\Font\LinZhiling\2052", @"E:\offline\TemplateTuningTool\offlinetool\LocaleHandler"))
            {
                serviceProvider.SpeechSynthesizer.SetOutputToWaveStream(null);
                serviceProvider.SpeechSynthesizer.Speak("123");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("fff");
            Test();
        }
    }
}
