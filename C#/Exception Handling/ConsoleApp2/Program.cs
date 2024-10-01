using System;
using System.Diagnostics;
using System.Threading;

namespace testington
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string damianPath = "https://cdn.discordapp.com/attachments/1057776217413140572/1181642967103045643/0TqNUPJ.png?ex=665aac85&is=66595b05&hm=b588c074628f18e9c392d54e894b80c3e28a6bd5cd275bb673e0d1039349258b&";
            string songPath = @"C:\Users\user\Downloads\SOIUL_CUKER_OF_THE_SNATCH_DEMON_GRANDMA_CHILD.wav";
            string geometryDashPath = @"C:\Users\user\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Steam\Geometry Dash.url";
            string secretSurprise = "https://www.niggafart.com";

            Console.WriteLine("Choose a file to open:");
            Console.WriteLine("1. Damian face");
            Console.WriteLine("2. Song");
            Console.WriteLine("3. Geometry Dash");
            Console.WriteLine("4. Free CP (illegal)");

            string choice = Console.ReadLine();

            string selectedPath;
            switch (choice)
            {
                case "1":
                    selectedPath = damianPath;
                    break;
                case "2":
                    selectedPath = songPath;
                    break;
                case "3":
                    selectedPath = geometryDashPath;
                    break;
                case "4":
                    selectedPath = secretSurprise;
                    break;
                default:
                    Console.WriteLine("wrong choice nigglet");
                    return;
            }
            OpenFile(selectedPath);
        }

        static void OpenFile(string filePath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            };

            try
            {
                while (true)
                {
                    Thread.Sleep(1000);
                    Process.Start(startInfo);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("dumbass nigga you used the wrong directory");
            }
        }
    }
}