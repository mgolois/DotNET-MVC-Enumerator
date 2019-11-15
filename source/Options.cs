/*
*  Command Line Parser Library 
*  https://github.com/gsscoder/commandline
*/

using System;
using System.IO;
using System.Text;
using CommandLine;

namespace DotNetMVCEnumerator.source
{
    class Options
    {
        [Option('o', "output", Required = false, HelpText = "CSV Output file")]
        public string CsvOutput { get; set; }

        [Option('a', "attribute", Required = false, HelpText = "Only Return Controller Methods Set With Specified Attribute")]
        public string AttributeSearch { get; set; }

        [Option('n', "negative", Required = false, HelpText = "Only Return Controller Methods Not Set With Specified Attribute")]
        public string NegativeSearch { get; set; }

        [Option('d', "directory", Required = true, HelpText = "Directories to scan")]
        public string Directory { get; set; }

    }
}
