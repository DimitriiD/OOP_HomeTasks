using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NUnitTestHomeTask
{
 
    public class Response1
        {
           public List<RespHelp1> countrydata { get; set; }
           public string stat { get; set; }
        }

    public class RespHelp1
        {
           public RespHelp2 info { get; set; }
           public string total_cases { get; set; }
           public string total_recovered { get; set; }
           public string total_unresolved { get; set; }
           public string total_deaths { get; set; }
           public string total_new_cases_today { get; set; }
           public string total_new_deaths_today { get; set; }
           public string total_active_cases { get; set; }
           public string total_serious_cases { get; set; }
           public string total_danger_rank { get; set; }
        }
    public class RespHelp2
        {
           public string ourid { get; set; }
           public string title { get; set; }
           public string code { get; set; }
        public string source { get; set; }

        }
    public class Response2
    {
        public string Updated { get; set; }
        public string Country { get; set; }
        public CtInf countryInfo { get; set; }
        public string cases { get; set; }
        public string todayCases { get; set; }
        public string deaths { get; set; }
        public string todayDeaths { get; set; }
        public string recovered { get; set; }
        public string active { get; set; }
        public string critical { get; set; }
        public string casesPerOneMillion { get; set; }
        public string deathsPerOneMillion { get; set; }
        public string tests { get; set; }
        public string testsPerOneMillion { get; set; }
        public string continent { get; set; }
    }
    public class CtInf
    {
        public string _id { get; set; }
        public string iso2 { get; set; }
        public string iso3 { get; set; }
        public string lat { get; set; }
        public string longr { get; set; }
        public string flag { get; set; }
    }
   
 
}