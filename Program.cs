using System;

namespace hackertyper
{
    class MainClass
    {
        public static string text = "";

        public static string help = "hackertyper by sl4v\n" +
        	"\n-h             show help" +
        	"\n-v             show version" +
        	"\n-f [file/url]  use file or url" + // System.Net.WebClient can open urls AND files, apparently
        	"\n(no args)      uses url: http://pastebin.com/raw/UcmyhKDG"; // TODO: Figure out a way to embed the text file

        public static void UseURL(string url)
        {
            try
            {
                Console.WriteLine("ELITE H4XING...");
                System.Net.WebClient client = new System.Net.WebClient();
                text = client.DownloadString(url);
                Console.Clear();
            }
            catch (Exception)
            {
                Console.WriteLine("Error retrieving data from URL.");
                throw;
            }

        }

        public static void HackerType()
        {
            string text_until_now = "";
            Random random = new Random();
            for (int i = 0; text.Length > i; i++)
            {
                text_until_now += text[i];
                if (i % random.Next(2, 12) == 0)
                {
                    Console.ReadKey(true);
                    Console.Write(text_until_now);
                    text_until_now = "";
                }
            }
        }

        public static void Main(string[] args)
        {
            if (args.Length >= 1)
            {
                switch (args[0])
                {
                    case "-h":
                        Console.WriteLine(help);
                        Environment.Exit(0);
                        break;
                    case "-v":
                        Console.WriteLine("I just made this lol. By sl4v");
                        Environment.Exit(0);
                        break;
                    case "-f":
                        UseURL(args[1]);
                        break;
                }
            }
            else
            {
                UseURL("http://pastebin.com/raw/UcmyhKDG");
            }
            HackerType();
        }
    }
}