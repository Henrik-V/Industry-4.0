using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TemperatureReader.Models
{
    public class Temperature
    {
        public int TemperatureId { get; set; }
        public string TimeStampo { get; set; }
        public float Celsius { get; set; }
        public float Fahrenheit { get; set; }

        public List<Temperature> GetTemperature(string connectionString)
        {
            List<Temperature> temperatureList = new List<Temperature>();

            SqlConnection connection = new SqlConnection(connectionString);

            string sqlQuery = "select FORMAT(TimeStampo, 'HH:mm:ss') AS TimeStampo, Celsius, Fahrenheit from TEMPERATURES";

            connection.Open();

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    Temperature temperature = new Temperature();

                   

                    temperature.TimeStampo = dataReader["TimeStampo"].ToString();
                    temperature.Celsius = float.Parse(dataReader["Celsius"].ToString());
                    temperature.Fahrenheit = float.Parse(dataReader["Fahrenheit"].ToString());

                    temperatureList.Add(temperature);
                }
            }

            return temperatureList;
        }
    }
}
