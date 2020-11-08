//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using System;
using SampleRegression.Model;

namespace SampleRegression.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                VendorID = 1F,
                Trip_distance = 2.5F,
                RatecodeID = 1F,
                Payment_type = 1F,
                Total_amount = 17.25F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Fare_amount with predicted Fare_amount from sample data...\n\n");
            Console.WriteLine($"VendorID: {sampleData.VendorID}");
            Console.WriteLine($"Trip_distance: {sampleData.Trip_distance}");
            Console.WriteLine($"RatecodeID: {sampleData.RatecodeID}");
            Console.WriteLine($"Payment_type: {sampleData.Payment_type}");
            Console.WriteLine($"Total_amount: {sampleData.Total_amount}");
            Console.WriteLine($"\n\nPredicted Fare_amount: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
