using System.Xml.Linq;

namespace XmlTools
{
    public interface IXmlFilter
    {
        XDocument Apply(XDocument document);
        XElement Apply(XElement element);
        int Order { get; set; }
    }
}