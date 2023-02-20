using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Chart_Bind_JSON_Data
{
    public class ViewModel
    {
        public List<Model> Items { get; set; }

        public ViewModel()
        {
            using (var stream = GetType().Assembly.GetManifestResourceStream("WPF_Chart_Bind_JSON_Data.Capacities.json"))
            using (TextReader textStream = new StreamReader(stream))
            {
                var text = textStream.ReadToEnd();
                Items = JsonConvert.DeserializeObject<List<Model>>(text);
            }
        }
    }
}
