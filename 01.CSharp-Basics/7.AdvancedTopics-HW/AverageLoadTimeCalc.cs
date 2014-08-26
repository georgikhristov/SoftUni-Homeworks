using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Globalization;


class AverageLoadTimeCalc
{
    static void Main()
    {
        // so that 2.8 is regarded as a number, not a string
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 
        
        Console.Write("Enter the number of entries: ");
        int n = int.Parse(Console.ReadLine());
        
        // we defined a new class Report to hold each entry data
        var report = new List<Report>(); 
        
        for (int i = 0; i < n; i++)
        {
            // we split the data of each entry into 4 strings - date, hour, url, load time
            var str = Console.ReadLine().Split(' ');
            //we add a new member of the list report with the data of the entry
            report.Add(new Report(str[0], str[1], str[2], Convert.ToDouble(str[3]),1)); 
        }

        for (int i = 0; i < report.Count - 1; i++)
        {
            for (int j = i + 1; j < report.Count; j++)
            {
                if (report[i].url == report[j].url)
                {
                    report[i].count++;
                    report[i].loadTime += report[j].loadTime;
                    report.RemoveAt(j);
                    j--;
                }
            }
        }
        for (int i = 0; i < report.Count; i++)
        {
            report[i].loadTime /= (double)report[i].count;
            Console.WriteLine("{0} -> {1}", report[i].url, report[i].loadTime);
        }
    }
}
class Report
{
    public string date { get; set; }
    public string hour { get; set; }
    public string url { get; set; }
    public double loadTime { get; set; }
    public int count { get; set; }
    public Report(string date_, string hour_, string url_, double loadTime_, int count_)
    {
        date = date_;
        hour = hour_;
        url = url_;
        loadTime = loadTime_;
        count = count_;
    }
}

