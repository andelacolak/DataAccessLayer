﻿using System;
using System.Collections.Generic;
using System.Text;
using CommandLine;

namespace console
{
    class Options
    {
        [Option( 'c', "collection", Required = true, HelpText = "C" )]
        public string InputFile { get; set; }

        //[Option( null, "length", HelpText = "The maximum number of bytes to process." )]
        //public int MaximumLenght { get; set; }

        //[Option( "v", null, HelpText = "Print details during execution." )]
        //public bool Verbose { get; set; }

        //[HelpOption( HelpText = "Display this help screen." )]
        //public string GetUsage()
        //{
        //    var usage = new StringBuilder();
        //    usage.AppendLine( "Quickstart Application 1.0" );
        //    usage.AppendLine( "Read user manual for usage instructions..." );
        //    return usage.ToString();
        //}
    }
}
