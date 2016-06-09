# XmlTools

This is really a set of tools for working with XML files inside Open XML documents such as DOCX, PPTX or XLSX.

THe core library defines an inteface *IXmlFilter* that allows you to apply some transformation on an XDocument or XElement. The *Processor* class allows you to load, stack and execute filters against XDocuments.

There are currently two filters built into the library, Sortify and Strictify.  

*Sortify* in conjunction with the Indent option will sort the contents of each node by name and then by attribute and attribute value.  The use for this is primarily to aid in performing diffs against XML documents.  Please do note that sorting the elements in an Open XML document will cause it to become unopenable as element order seems to matter.

*Strictify* is an experimental filter to fix bad Open XML documents that do not conform to strict Open XML standards.

The *XmlToolUI* project wraps the library in a (hopefully) easy-to-use application.  Here you can select OpenXML documents. Pressing Extract will unzip the file and run all XML files in the destination folder through the selected filters. Pressing Rebuild will compress ALL files in the destination folder into the source file name (or an incremental file name if the option to not overwrite is enabled)

# License

*The MIT License (MIT)*
Copyright (c) 2016 David Khristepher Santos

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

