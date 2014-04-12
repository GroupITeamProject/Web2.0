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
        static void Main()
        {
            bool checkerTwo = false;
            bool h = true;
            String s = "http://www.dit.enda";
            bool checkerOne = s.StartsWith("http://www.", System.StringComparison.CurrentCultureIgnoreCase);
            String[] domainArray = new String[] { ".aero",".biz",".cat",".com",".coop",".edu",".gov",".info",".int",".jobs",".mil",".mobi",".museum",
".name",".net",".org",".travel",".ac",".ad",".ae",".af",".ag",".ai",".al",".am",".an",".ao",".aq",".ar",".as",".at",".au",".aw",
".az",".ba",".bb",".bd",".be",".bf",".bg",".bh",".bi",".bj",".bm",".bn",".bo",".br",".bs",".bt",".bv",".bw",".by",".bz",".ca",
".cc",".cd",".cf",".cg",".ch",".ci",".ck",".cl",".cm",".cn",".co",".cr",".cs",".cu",".cv",".cx",".cy",".cz",".de",".dj",".dk",".dm",
".do",".dz",".ec",".ee",".eg",".eh",".er",".es",".et",".eu",".fi",".fj",".fk",".fm",".fo",".fr",".ga",".gb",".gd",".ge",".gf",".gg",".gh",
".gi",".gl",".gm",".gn",".gp",".gq",".gr",".gs",".gt",".gu",".gw",".gy",".hk",".hm",".hn",".hr",".ht",".hu",".id",".ie",".il",".im",
".in",".io",".iq",".ir",".is",".it",".je",".jm",".jo",".jp",".ke",".kg",".kh",".ki",".km",".kn",".kp",".kr",".kw",".ky",".kz",".la",".lb",
".lc",".li",".lk",".lr",".ls",".lt",".lu",".lv",".ly",".ma",".mc",".md",".mg",".mh",".mk",".ml",".mm",".mn",".mo",".mp",".mq",
".mr",".ms",".mt",".mu",".mv",".mw",".mx",".my",".mz",".na",".nc",".ne",".nf",".ng",".ni",".nl",".no",".np",".nr",".nu",
".nz",".om",".pa",".pe",".pf",".pg",".ph",".pk",".pl",".pm",".pn",".pr",".ps",".pt",".pw",".py",".qa",".re",".ro",".ru",".rw",
".sa",".sb",".sc",".sd",".se",".sg",".sh",".si",".sj",".sk",".sl",".sm",".sn",".so",".sr",".st",".su",".sv",".sy",".sz",".tc",".td",".tf",
".tg",".th",".tj",".tk",".tm",".tn",".to",".tp",".tr",".tt",".tv",".tw",".tz",".ua",".ug",".uk",".um",".us",".uy",".uz", ".va",".vc",
".ve",".vg",".vi",".vn",".vu",".wf",".ws",".ye",".yt",".yu",".za",".zm",".zr",".zw" };
           
                for(int i = 0; i<domainArray.Length; i++)
                {
         
                    if ( (s.EndsWith(domainArray[i])) == true)
                    {
                        checkerTwo = true;
                        h = false;
                    }
                    if (i == (domainArray.Length - 1))
                    {
                        h = false;
                        break;
                        
                    }

                   
                }
            
            while (h == false)
            {
                if (checkerOne == true && checkerTwo == true)
                {

                    WebClient w = new WebClient();
                    String k = w.DownloadString(s);
                    Regex x = new Regex("<[^>]*>");
                    //String target = s.replaceAll("(?i)<td[^>]*>", " ").replaceAll("\\s+", " ").trim();
                    String ss = x.Replace(k, " ");
                    Console.WriteLine(ss);
                    Console.ReadLine();
                }
                else
                { //PUT POP UP BOX HERE
                    Console.WriteLine("You dumbass, you god damn dumbass. \nWe are drowning under the avalanche of your inadequacies");
                    Console.ReadKey();
                }
             }  
          }
       }
  }


