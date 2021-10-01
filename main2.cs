using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.VisualBasic.Devices;
using App = MyApp;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // A();
            Write();
        }
        static void A() {
            // Program.A();
        }
        static void Write() {
            var userprofile = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"));
            string[] text = { "plik jest", "nieszkodliwy" };
            File.WriteAllLines(userprofile + "\\Desktop\\sample.txt", text);
            Console.WriteLine("Plik został napisany.");
}}}
