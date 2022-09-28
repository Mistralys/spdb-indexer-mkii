using Newtonsoft.Json;
using SPDB_MKII.Classes.DatabaseInfos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDB_MKII.Classes
{
    internal class DelimitedJSONParser
    {
        private readonly List<string> items = new();

        public List<string> Items => items;

        public int Count => Items.Count;

        public DelimitedJSONParser(string source, string delimiter)
        {
            string[] list = source.Split(delimiter);

            foreach (string item in list)
            {
                items.Add(item.Trim());
            }
        }
    }
}
