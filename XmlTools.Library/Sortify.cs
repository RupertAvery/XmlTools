using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace XmlTools
{
    public class Sortify : IXmlFilter
    {
        public int Order { get; set; }
        public XDocument Apply(XDocument document)
        {
            return new XDocument(
                document.Declaration,
                from child in document.Nodes()
                where child.NodeType != XmlNodeType.Element
                select child,
                Apply(document.Root));
        }

        public XElement Apply(XElement element)
        {
            return new XElement(element.Name,
                element.Attributes().OrderBy(x => x.Name.LocalName),
                from child in element.Nodes()
                where child.NodeType != XmlNodeType.Element
                select child,
                from child in element.Elements()
                orderby GetOrderBy(child)
                select Apply(child));
        }

        private static string GetOrderBy(XElement node)
        {
            return node.Name.LocalName + string.Join("",
                node.Attributes()
                    .OrderBy(attr => attr.Name.LocalName)
                    .Select(attr => attr.Name.LocalName + attr.Value)
                );
        }

    }
}