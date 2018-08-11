using System;
using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine(new WebClient().DownloadString("http://google.com/"));
        }
        catch (WebException ex) when (ex.Status == WebExceptionStatus.Timeout)
        {
            Console.WriteLine("Timeout!");
        }
        catch (WebException ex) when (ex.Status == WebExceptionStatus.NameResolutionFailure)
        {
            Console.WriteLine("Name resolution failure!");
        }
        catch (WebException ex)
        {
            Console.WriteLine($"Some other failure: {ex.Status}");
        }
    }
}