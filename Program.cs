using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Data;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Diagnostics;

 

namespace WebScrappy
{
    class Program
    {                
        static void Main(){
             WebClient w = new WebClient();
             String s = w.DownloadString("http://www.dit.ie");
             Regex x = new Regex("<[^>]*>");
             //String target = s.replaceAll("(?i)<td[^>]*>", " ").replaceAll("\\s+", " ").trim();
             String ss = x.Replace(s, " ");
             Console.WriteLine(ss);
             Console.ReadLine();


            
        }
    }
}
