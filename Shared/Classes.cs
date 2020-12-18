using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA3.Shared
{
    public class Top
    {
        public int mal_id { get; set; }
        public int rank { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string image_url { get; set; }
        public string type { get; set; }
        public int episodes { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public int members { get; set; }
        public double score { get; set; }
    }
    public class Genre
    {
        public int mal_id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Producer
    {
        public int mal_id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Anime
    {
        public int mal_id { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public string image_url { get; set; }
        public string synopsis { get; set; }
        public string type { get; set; }
        public DateTime airing_start { get; set; }
        public int? episodes { get; set; }
        public int members { get; set; }
        public List<Genre> genres { get; set; }
        public string source { get; set; }
        public List<Producer> producers { get; set; }
        public double? score { get; set; }
        public List<string> licensors { get; set; }
        public bool r18 { get; set; }
        public bool kids { get; set; }
        public bool continuing { get; set; }
    }


    public class Root
    {
        public string request_hash { get; set; }
        public bool request_cached { get; set; }
        public int request_cache_expiry { get; set; }
        public List<Top> top { get; set; }
        public string season_name { get; set; }
        public int season_year { get; set; }
        public List<Anime> anime { get; set; }
    }
}
