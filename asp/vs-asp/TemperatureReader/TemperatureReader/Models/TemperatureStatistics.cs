using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TemperatureReader.Models
{
    public class TemperatureStatistics
    {
        public int DataInformationId { get; set; }
        public float AverageCelsius { get; set; }
        public float MinCelsius { get; set; }
        public float MaxCelsius { get; set; }
        public float AverageFahrenheit { get; set; }
        public float MinFahrenheit { get; set; }
        public float MaxFahrenheit { get; set; }

        public float SampleTime {get;set;}

        public string TemperatureUnit {get;set;}


        public List<TemperatureStatistics> GetTemperatureStatistics(string connectionString)
        {
            List<TemperatureStatistics> temperatureStatisticsList = new List<TemperatureStatistics>();

            SqlConnection connection = new SqlConnection(connectionString);

            string sqlQuery = "select * from TempData";

            connection.Open();

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader dataReader = command.ExecuteReader();

            if(dataReader != null)
            {
                while(dataReader.Read())
                {
                    TemperatureStatistics temperatureStatistics = new TemperatureStatistics();

                    temperatureStatistics.DataInformationId = Convert.ToInt32(dataReader["DataInformationId"]);

                    temperatureStatistics.AverageCelsius = float.Parse(float.Parse(dataReader["AverageCelsius"].ToString()).ToString("N2"));
                    temperatureStatistics.MinCelsius = float.Parse(dataReader["MinCelsius"].ToString());
                    temperatureStatistics.MaxCelsius = float.Parse(dataReader["MaxCelsius"].ToString());

                    temperatureStatistics.AverageFahrenheit = float.Parse(float.Parse(dataReader["AverageFahrenheit"].ToString()).ToString("N2"));
                    temperatureStatistics.MinFahrenheit = float.Parse(dataReader["MinFahrenheit"].ToString());
                    temperatureStatistics.MaxFahrenheit = float.Parse(dataReader["MaxFahrenheit"].ToString());

                    temperatureStatistics.TemperatureUnit = dataReader["TemperatureUnit"].ToString();

                    temperatureStatisticsList.Add(temperatureStatistics);
                }
            }

            return temperatureStatisticsList;
        }
        

    }
}
