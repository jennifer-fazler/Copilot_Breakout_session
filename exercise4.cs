using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;

public class SwiftBic
{
    public string SwiftCode { get; set; }
    public decimal PaymentAmount { get; set; }
    public string PaymentCurrency { get; set; }
    public DateTime PaymentDate { get; set; }
    public string BicCode { get; set; }
}

public class Program
{
    public static void Main()
    {
        string filePath = "SWIFTBIC.TXT";
        var swiftBics = new List<SwiftBic>();

        try
        {
            var lines = File.ReadLines(filePath);

            foreach (var line in lines)
            {
                var swiftBic = new SwiftBic
                {
                    SwiftCode = line.Substring(0, 11).Trim(),
                    PaymentAmount = decimal.Parse(line.Substring(12, 7)),
                    PaymentCurrency = line.Substring(20, 3).Trim(),
                    PaymentDate = DateTime.ParseExact(line.Substring(24, 8), "yyyyMMdd", null),
                    BicCode = line.Substring(33, 11).Trim()
                };

                if (IsValid(swiftBic))
                {
                    swiftBics.Add(swiftBic);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"An error occurred with file: {ex.Message}");
        }

        using (var context = new DbContext())
        {
            context.Set<SwiftBic>().AddRange(swiftBics);
            context.SaveChanges();
        }
    }

    public static bool IsValid(SwiftBic swiftBic)
    {
        if (string.IsNullOrWhiteSpace(swiftBic.SwiftCode))
        {
            Console.WriteLine("Invalid SWIFT Code");
            return false;
        }

        if (swiftBic.PaymentAmount == 0)
        {
            Console.WriteLine("Invalid Payment Amount");
            return false;
        }

        if (string.IsNullOrWhiteSpace(swiftBic.PaymentCurrency))
        {
            Console.WriteLine("Invalid Payment Currency");
            return false;
        }

        if (swiftBic.PaymentDate == default(DateTime))
        {
            Console.WriteLine("Invalid Payment Date");
            return false;
        }

        if (string.IsNullOrWhiteSpace(swiftBic.BicCode))
        {
            Console.WriteLine("Invalid BIC Code");
            return false;
        }

        return true;
    }
}