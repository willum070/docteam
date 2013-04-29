﻿/******************************************************
 * This tool is designed to convert the XML generated by
 * Visual Studio into a Markdown-formatted document
 * for the REST API reference.
 * It is set up to extract the details from all members 
 * belonging to UI.ChronozoomSVC and magically convert it 
 * into Markdown. 
 * 
 * v.2 by William French
 ******************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace xslcon
{
    class MDConverter
    {
        static string baseClass = "M:UI.ChronozoomSVC.";
        static Regex nameRgx = new Regex(@"M:UI\.ChronozoomSVC\.\w*");

        // This is the path to the VS doc XML file we are going to process.
        // In the Chronozoom project it is found here: \ChronoZoom\Source\Chronozoom.UI\bin
        static string xmlpath = @"C:\Users\v-wfren\Documents\GitHub\ChronoZoom\Source\Chronozoom.UI\bin\UI.XML";

        static void Main(string[] args)
        {
            generateMarkdown();            
        }

        // Run everything and output a file.
        static void generateMarkdown()
        {
            if (xmlpath != null)
            {
                makeDoc(xmlpath);
            }
        }

        // Uses Linq to get the names and output as array.
        static string[] getNames(string path)
        {
            // Load the XML document.
            XDocument doc = XDocument.Load(path);

            // Create the stack to hold the names.
            Stack<string> nameStack = new Stack<string>();

            // Get all of the names.
            var query =
                from member in doc.Descendants("member")
                select
                    new XElement("member",
                                    member.Attribute("name").Value);

            // Filter and clean the strings.
            foreach (var member in query)
            {
                if (nameRgx.IsMatch(member.Value))
                {
                    string n = cleanString(member.Value);
                    nameStack.Push(n);
                }
            }

            // Make array, flip values and output.
            string[] nameArray = nameStack.ToArray();
            Array.Reverse(nameArray);
            return nameArray;
        }

        // Clean up name string.
        static string cleanString(string n)
        {
            n = n.Replace(baseClass, "");
            int i = n.IndexOf("(");
            if (i > 0)
            {
                n = n.Remove(i);
                return n;
            }
            else
            {
                return n;
            }
        }

        // Output a table of contents.
        static string makeToc(string[] input)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("## ChronoZoom REST Commands ##");
            for (int i = 0; i < input.Length; i++)
            {
                string item = input[i].ToString();
                string tocLine = "- [" + item + "](#" + item.ToLower() + ")";
                sb.AppendLine(tocLine);
            }

            return sb.ToString();
        }

        static void makeDoc(string path)
        {
            // Load the XML document.
            XDocument doc = XDocument.Load(path);

            // Create the string builder
            // for the entire reference portion of the doc.
            StringBuilder sb = new StringBuilder();

            // Get the names and add the TOC.
            string[] names = getNames(xmlpath);
            string toc = makeToc(names);
            sb.AppendLine(toc);

            // Get all of the members.
            var qMembers =
                from member in doc.Descendants("member")
                select
                    member;

            // Add each member to the doc.
            foreach (var member in qMembers)
            {
                // Process if it matches our desired class value.
                if (nameRgx.IsMatch(member.Attribute("name").Value))
                {
                    sb.AppendLine("## " + cleanString(member.Attribute("name").Value) + " ##");
                    sb.AppendLine(" ");
                    sb.AppendLine(member.XPathSelectElement("summary").Value.Trim());
                    sb.AppendLine(" ");

                    if (member.XPathSelectElement("returns") != null)
                    {
                        sb.AppendLine("**Returns**");
                        sb.AppendLine(" ");
                        sb.AppendLine(member.XPathSelectElement("returns").Value.Trim());
                        sb.AppendLine(" ");
                    }

                    sb.AppendLine("**Example**");
                    sb.AppendLine(" ");
                    sb.AppendLine("    " + member.XPathSelectElement("example").Value.Trim());
                    sb.AppendLine(" ");

                    var qParams =
                        from p in member.Descendants("param")
                        select
                            p;

                    if (qParams != null)
                    {
                        sb.AppendLine("**Parameters**");
                        sb.AppendLine(" ");
                        sb.AppendLine("|Parameter|Value|");
                        sb.AppendLine("|:--------|:----|");

                        foreach (var param in qParams)
                        {
                            sb.AppendLine("|" + param.Name + "|" + param.Value + "|");
                        }
                    }
                    else
                    {
                        sb.AppendLine("**Parameters**");
                        sb.AppendLine("None.");
                    }

                    sb.AppendLine(" ");
                    sb.AppendLine("[top](#chronozoom-rest-api-reference)");
                    sb.AppendLine("----------");
                    sb.AppendLine(" ");

                }
            }

            using (StreamWriter outfile = new StreamWriter(@"ChronoZoom_REST_API.md"))
            {
                outfile.Write(sb.ToString());
            }
        }
    }
}
