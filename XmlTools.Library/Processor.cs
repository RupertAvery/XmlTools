using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace XmlTools
{
    public class Processor
    {
        public int FileCount { get; private set; }
        public bool Indented { get; set; }
        public bool SubFolders { get; set; }

        private readonly List<IXmlFilter> _filters = new List<IXmlFilter>();
        int _order = 0;
        public Action<string> OnStartProcessFile { get; set; }
        public void AddFilter(IXmlFilter filter)
        {
            filter.Order = _order++;
            _filters.Add(filter);
        }

        public void ProcessFolder(string path, string extension)
        {
            var options = SubFolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            var files = Directory.EnumerateFiles(path, extension, options);
            foreach (var file in files)
            {
                ProcessFile(file);
            }
        }

        public void ProcessFile(string file)
        {
            OnStartProcessFile?.Invoke(file);
            FileCount++;

            var doc = XDocument.Load(file);
            foreach (var filter in _filters.OrderBy(x => x.Order))
            {
                doc = filter.Apply(doc);
            }
            var formatOptions = Formatting.None;
            if (Indented) formatOptions = Formatting.Indented;
            using (var writer = new XmlTextWriter(file, Encoding.UTF8) { Formatting = formatOptions })
            {
                doc.Save(writer);
            }
        }
    }

}
