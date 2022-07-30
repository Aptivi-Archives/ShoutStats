/*
 * MIT License
 * 
 * Copyright (c) 2021 Aptivi
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using System;
using ShoutStats.Core;
using Terminal = System.Console;

namespace ShoutStats.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 2)
            {
                try
                {
                    // Parse the address and the port
                    if (!args[0].Contains(Uri.SchemeDelimiter))
                    {
                        args[0] = Uri.UriSchemeHttps + Uri.SchemeDelimiter + args[0];
                    }
                    string Address = args[0];
                    int Port = Convert.ToInt32(args[1]);
                    bool UseSecure = args[0].Contains("https://");
                    Terminal.WriteLine("Getting information about stream {0}:{1}...", Address, Port);

                    // Get the stream info
                    ShoutcastServer ParsedServer = new(Address, Port, UseSecure);

                    // Print the server information
                    Terminal.WriteLine($"Host: {ParsedServer.ServerHost}");
                    Terminal.WriteLine($"Port: {ParsedServer.ServerPort}");
                    Terminal.WriteLine($"URL: {ParsedServer.ServerHostFull}");
                    Terminal.WriteLine($"Secure protocol: {ParsedServer.ServerHttps}");
                    Terminal.WriteLine($"Server version: {ParsedServer.ServerVersion}");
                    Terminal.WriteLine($"Total streams: {ParsedServer.TotalStreams}");
                    Terminal.WriteLine($"Active streams: {ParsedServer.ActiveStreams}");
                    Terminal.WriteLine($"Current listeners: {ParsedServer.CurrentListeners}");
                    Terminal.WriteLine($"Peak listeners: {ParsedServer.PeakListeners}");
                    Terminal.WriteLine($"Max listeners: {ParsedServer.MaxListeners}");
                    Terminal.WriteLine($"Unique listeners: {ParsedServer.UniqueListeners}");
                    Terminal.WriteLine($"Average time (s): {ParsedServer.AverageTime}");
                    Terminal.WriteLine($"Average time (span): {ParsedServer.AverageTimeSpan}");

                    // Print the stream information
                    foreach (StreamInfo stream in ParsedServer.Streams)
                    {
                        Terminal.WriteLine("---------------------------------------");
                        Terminal.WriteLine($"Stream ID: {stream.StreamId}");
                        Terminal.WriteLine($"Stream title: {stream.StreamTitle}");
                        Terminal.WriteLine($"Current song: {stream.SongTitle}");
                        Terminal.WriteLine($"Current listeners: {stream.CurrentListeners}");
                        Terminal.WriteLine($"Peak listeners: {stream.PeakListeners}");
                        Terminal.WriteLine($"Max listeners: {stream.MaxListeners}");
                        Terminal.WriteLine($"Unique listeners: {stream.UniqueListeners}");
                        Terminal.WriteLine($"Average time (s): {stream.AverageTime}");
                        Terminal.WriteLine($"Average time (span): {stream.AverageTimeSpan}");
                        Terminal.WriteLine($"Stream genre: {stream.StreamGenre}");
                        Terminal.WriteLine($"Stream homepage: {stream.StreamHomepage}");
                        Terminal.WriteLine($"Stream hits: {stream.StreamHits}");
                        Terminal.WriteLine($"Stream status: {stream.StreamStatus}");
                        Terminal.WriteLine($"Backup status: {stream.BackupStatus}");
                        Terminal.WriteLine($"Stream listed: {stream.StreamListed}");
                        Terminal.WriteLine($"Stream path: {stream.StreamPath}");
                        Terminal.WriteLine($"Stream uptime (s): {stream.StreamUptime}");
                        Terminal.WriteLine($"Stream uptime (span): {stream.StreamUptimeSpan}");
                        Terminal.WriteLine($"Stream bitrate: {stream.BitRate}");
                        Terminal.WriteLine($"Stream sample rate: {stream.SampleRate}");
                        Terminal.WriteLine($"MIME info: {stream.MimeInfo}");
                    }
                    Terminal.WriteLine("---------------------------------------");
                }
                catch (Exception ex)
                {
                    Terminal.WriteLine("Error trying to get information for the server: {0}", ex.Message);
                    Terminal.WriteLine(ex.StackTrace);
                    if (ex.InnerException != null)
                    {
                        Terminal.WriteLine("If this is a problem in ShoutStats, report it: {0}", ex.InnerException.Message);
                        Terminal.WriteLine(ex.InnerException.StackTrace);
                    }
                }
            }
            else
            {
                Terminal.WriteLine("Provide the address and the port for the stream.");
            }
        }
    }
}
