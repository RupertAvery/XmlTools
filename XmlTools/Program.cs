using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace XmlTools
{
    class Program
    {
        private static bool sorted = false;
        private static bool strict = false;
        private static List<string> sources = new List<string>();

        static void DisplayHeader()
        {
            Assembly currentAssembly = typeof(XmlTools.Program).Assembly;
            object[] attribs = currentAssembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), true);
            string company = "";
            if (attribs.Length > 0)
            {
                company = ((AssemblyCompanyAttribute)attribs[0]).Company;
            }
            var version = currentAssembly.GetName().Version;

            Console.WriteLine($"XmlTools v{version.Major}.{version.Minor} - {company}");
            Console.WriteLine("");
        }

        static void DisplayUsage()
        {
            Console.WriteLine("USAGE");
            Console.WriteLine("  XmlTools <options> <sources>");
            Console.WriteLine("");
            Console.WriteLine("options:");
            Console.WriteLine("  --s - Traverse subdirectories");
            Console.WriteLine("");
            Console.WriteLine("  --indent - enable whitespace indentation (default: disabled)");
            Console.WriteLine("  --sort   - alphabetically sorts all attributes and elements (default: disabled)");
            Console.WriteLine("             WARNING: This option will prevent Open XML based documents from loading.");
            Console.WriteLine("             Use only before performing diffs");
            Console.WriteLine("  --strict-openxml - modifies specific Open XML meta files to allow documents to be loaded");
            Console.WriteLine("             correctly in Google");
            Console.WriteLine("");
            Console.WriteLine("sources:");
            Console.WriteLine("  list of files and/or folders separated by spaces");
            Console.WriteLine("");
            Console.WriteLine("  XmlTools --indent --sort foo.xml");
            Console.WriteLine("  XmlTools -s --strict-openxml bar");
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            DisplayHeader();
            if (!args.Any())
            {
                DisplayUsage();
                return;
            }

            var argsStack = new Stack<string>(args.Reverse());

            var processor = new Processor
            {
                OnStartProcessFile = (filename) => { Console.WriteLine(filename); }
            };

            while (argsStack.Any())
            {
                var arg = argsStack.Pop();
                if (arg == "--sort")
                {
                    if (!sorted)
                    {
                        processor.AddFilter(new Sortify());
                        sorted = true;
                    }
                }
                else if (arg == "--indent")
                {
                    processor.Indented = true;
                }
                else if (arg == "--strict-openxml")
                {
                    if (!strict)
                    {
                        processor.AddFilter(new Strictify());
                        strict = true;
                    }
                }
                else if (arg == "-s")
                {
                    processor.SubFolders = true;
                }
                else
                {
                    sources.Add(arg);
                }
            }

            if (!sources.Any())
            {
                Console.WriteLine("No source files or directories specified.");
                return;
            }

            var st = new Stopwatch();
            st.Start();
            foreach (var source in sources)
            {
                if (IsOpenXmlDoc(source))
                {
                    var destination = Path.Combine(Path.GetDirectoryName(source), Path.GetFileNameWithoutExtension(source));
                    Console.WriteLine($"Extracting {Path.GetFileName(source)}...");
                    System.IO.Compression.ZipFile.ExtractToDirectory(source, destination);
                    processor.ProcessFolder(destination, "*.xml");
                }
                else if (File.GetAttributes(source).HasFlag(FileAttributes.Directory))
                {
                    processor.ProcessFolder(source, "*.xml");
                }
                else
                {
                    processor.ProcessFile(source);
                }
            }
            st.Stop();

            Console.WriteLine("");
            Console.WriteLine($"Updated {processor.FileCount} file(s) in {st.ElapsedMilliseconds}ms");
            Console.WriteLine("");

            Console.ReadLine();
        }

        private static bool IsOpenXmlDoc(string filename)
        {
            return
                filename.EndsWith(".pptx", StringComparison.InvariantCultureIgnoreCase) ||
                filename.EndsWith(".xlsx", StringComparison.InvariantCultureIgnoreCase) ||
                filename.EndsWith(".docx", StringComparison.InvariantCultureIgnoreCase);
        }

    }

}
