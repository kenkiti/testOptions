using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommandLine;

namespace testOptions
{
    class Options
    {
        [Option('c', "code", Default = 4565, HelpText = "code")]
        public int code { get; set; }

        [Option('s', "start", Required = false, HelpText = "autostart")]
        public bool start_auto { get; set; }

        [Option('o', "connect", Required = false, HelpText = "connect server")]
        public bool connect_server { get; set; }

    }
}
