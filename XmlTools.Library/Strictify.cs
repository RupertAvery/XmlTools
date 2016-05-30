using System.Linq;
using System.Xml.Linq;

namespace XmlTools
{
    public class Strictify : IXmlFilter
    {
        readonly XNamespace _presentationMlns = XNamespace.Get("http://schemas.openxmlformats.org/presentationml/2006/main");
        readonly XNamespace _drawingMlns = XNamespace.Get("http://schemas.openxmlformats.org/drawingml/2006/main");
        readonly XNamespace _contentTypesNs = XNamespace.Get("http://schemas.openxmlformats.org/package/2006/content-types");
        readonly XNamespace _relationshipsNs = XNamespace.Get("http://schemas.openxmlformats.org/officeDocument/2006/relationships");
        readonly XNamespace _chartNs = XNamespace.Get("http://schemas.openxmlformats.org/drawingml/2006/chart");

        private string _context;

        public int Order { get; set; }

        public XElement Apply(XElement element)
        {
            switch (_context)
            {
                case "Types":
                    if (element.Name.LocalName == "Types")
                    {
                        if (!
                            element.Elements()
                                .Any(
                                    x =>
                                        x.Name.LocalName == "Default" &&
                                        x.Attributes()
                                            .Any(y => y.Name.LocalName == "ContentType" && y.Value == "application/xml")))
                        {
                            element.Add(new XElement(_contentTypesNs + "Default",
                                new XAttribute("ContentType", "application/xml"),
                                new XAttribute("Extension", "xml")));
                        }
                    }
                    break;
                //case "tagLst":
                //    if (element.Name.Namespace == _presentationMlns && element.Name.LocalName == "tagLst")
                //    {
                //        if (element.Attributes().All(x => x.Value != _drawingMlns))
                //        {
                //            element.Add(new XAttribute(XNamespace.Xmlns + "a", _drawingMlns));
                //        }
                //        if (element.Attributes().All(x => x.Value != _relationshipsNs))
                //        {
                //            element.Add(new XAttribute(XNamespace.Xmlns + "r", _relationshipsNs));
                //        }
                //    }
                //    break;
                //case "theme":
                //    if (element.Name.Namespace == _drawingMlns && element.Name.LocalName == "theme")
                //    {
                //        if (!
                //            element.Elements()
                //                .Any(
                //                    x =>
                //                        x.Name.LocalName == "extraClrSchemeLst" && x.Name.Namespace == _drawingMlns.NamespaceName))
                //        {
                //            element.Add(new XElement(XName.Get("extraClrSchemeLst", _drawingMlns.NamespaceName)));
                //        }
                //    }
                //    if (element.Name.Namespace == _drawingMlns && element.Name.LocalName == "bevelT")
                //    {
                //        element.Attributes("prst").Remove();
                //    }
                //    break;
                //case "sldLayout":
                //    if (element.Name.Namespace == _drawingMlns && element.Name.LocalName == "rPr")
                //    {
                //        element.Attributes("dirty").Remove();
                //    }
                //    if (element.Name.Namespace == _drawingMlns && element.Name.LocalName == "prstGeom")
                //    {
                //        if (!element.Elements()
                //            .Any(
                //                x =>
                //                    x.Name.LocalName == "avLst" && x.Name.Namespace == _drawingMlns.NamespaceName))
                //        {
                //            element.Add(new XElement(XName.Get("avLst", _drawingMlns.NamespaceName)));
                //        }

                //    }
                //    break;
                //case "sld":
                //case "sldMaster":
                //    if (element.Name.Namespace == _chartNs && element.Name.LocalName == "chart")
                //    {
                //        if (element.Attributes().All(x => x.Value != _relationshipsNs))
                //        {
                //            element.Add(new XAttribute(XNamespace.Xmlns + "r", _relationshipsNs));
                //        }
                //    }

                //    if (element.Name.Namespace == _presentationMlns && element.Name.LocalName == "cSld")
                //    {
                //        element.Attributes("name").Remove();
                //    }
                //    if (element.Name.Namespace == _drawingMlns && element.Name.LocalName == "prstGeom")
                //    {
                //        if (!element.Elements()
                //            .Any(
                //                x =>
                //                    x.Name.LocalName == "avLst" && x.Name.Namespace == _drawingMlns.NamespaceName))
                //        {
                //            element.Add(new XElement(XName.Get("avLst", _drawingMlns.NamespaceName)));
                //        }

                //    }
                //    if (element.Name.Namespace == _drawingMlns && element.Name.LocalName == "rPr")
                //    {
                //        element.Attributes("dirty").Remove();
                //    }
                //    break;
            }

            foreach (var child in element.Elements())
            {
                Apply(child);
            }

            return element;
        }

        public XDocument Apply(XDocument file)
        {
            _context = file.Root.Name.LocalName;
            Apply(file.Root);
            return file;
        }

    }
}