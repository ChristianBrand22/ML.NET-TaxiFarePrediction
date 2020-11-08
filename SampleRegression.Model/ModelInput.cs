//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace SampleRegression.Model
{
    public class ModelInput
    {
        [ColumnName("VendorID"), LoadColumn(0)]
        public float VendorID { get; set; }


        [ColumnName("tpep_pickup_datetime"), LoadColumn(1)]
        public string Tpep_pickup_datetime { get; set; }


        [ColumnName("tpep_dropoff_datetime"), LoadColumn(2)]
        public string Tpep_dropoff_datetime { get; set; }


        [ColumnName("passenger_count"), LoadColumn(3)]
        public float Passenger_count { get; set; }


        [ColumnName("trip_distance"), LoadColumn(4)]
        public float Trip_distance { get; set; }


        [ColumnName("RatecodeID"), LoadColumn(5)]
        public float RatecodeID { get; set; }


        [ColumnName("store_and_fwd_flag"), LoadColumn(6)]
        public bool Store_and_fwd_flag { get; set; }


        [ColumnName("PULocationID"), LoadColumn(7)]
        public float PULocationID { get; set; }


        [ColumnName("DOLocationID"), LoadColumn(8)]
        public float DOLocationID { get; set; }


        [ColumnName("payment_type"), LoadColumn(9)]
        public float Payment_type { get; set; }


        [ColumnName("fare_amount"), LoadColumn(10)]
        public float Fare_amount { get; set; }


        [ColumnName("extra"), LoadColumn(11)]
        public float Extra { get; set; }


        [ColumnName("mta_tax"), LoadColumn(12)]
        public float Mta_tax { get; set; }


        [ColumnName("tip_amount"), LoadColumn(13)]
        public float Tip_amount { get; set; }


        [ColumnName("tolls_amount"), LoadColumn(14)]
        public float Tolls_amount { get; set; }


        [ColumnName("improvement_surcharge"), LoadColumn(15)]
        public float Improvement_surcharge { get; set; }


        [ColumnName("total_amount"), LoadColumn(16)]
        public float Total_amount { get; set; }


    }
}
