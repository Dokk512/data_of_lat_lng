using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
using System.Data.SQLite;
using System.Security.Policy;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        #region Convert_Json_From_Access
        //string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=radio-locator.com.mdb; Jet OLEDB:Database Password=qwer@1234;Persist Security Info=True";

        //using (OleDbConnection conn = new OleDbConnection(connString))
        //{
        //    conn.Open();

        //    OleDbCommand cmd = new OleDbCommand("SELECT * FROM Data", conn);
        //    OleDbDataReader rst = cmd.ExecuteReader();

        //    List<Dictionary<string, object>> data = new List<Dictionary<string, object>>();

        //    while (rst.Read())
        //    {
        //        Dictionary<string, object> row = new Dictionary<string, object>();

        //        row["source_url"] = rst["Source URL"] != DBNull.Value ? rst["Source URL"].ToString() : "";

        //        row["antenna_mode"] = rst["Antenna Mode"] != DBNull.Value ? rst["Antenna Mode"].ToString() : "";

        //        row["antenna_pattern"] = rst["Antenna Pattern"] != DBNull.Value ? rst["Antenna Pattern"].ToString() : "";

        //        row["area_of_coverage"] = rst["Area Of Coverage"] != DBNull.Value ? rst["Area Of Coverage"].ToString() : "";

        //        row["city"] = rst["City"] != DBNull.Value ? rst["City"].ToString() : "";

        //        row["construction_permit_expires"] = rst["Construction Permit Expires"] != DBNull.Value ? rst["Construction Permit Expires"].ToString() : "";

        //        row["construction_permit_granted"] = rst["Construction Permit Granted"] != DBNull.Value ? rst["Construction Permit Granted"].ToString() : "";

        //        row["critical_hours_number_of_towers"] = rst["Critical Hours Number Of Towers"] != DBNull.Value ? rst["Critical Hours Number Of Towers"].ToString() : "";

        //        row["critical_hours_power"] = rst["Critical Hours Power"] != DBNull.Value ? rst["Critical Hours Power"].ToString() : "";

        //        row["critical_hours_transmitter_location"] = rst["Critical Hours Transmitter Location"] != DBNull.Value ? rst["Critical Hours Transmitter Location"].ToString() : "";

        //        row["daytime_number_of_towers"] = rst["Daytime Number Of Towers"] != DBNull.Value ? rst["Daytime Number Of Towers"].ToString() : "";

        //        row["daytime_power"] = rst["Daytime Power"] != DBNull.Value ? rst["Daytime Power"].ToString() : "";

        //        row["daytime_transmitter_location"] = rst["Daytime Transmitter Location"] != DBNull.Value ? rst["Daytime Transmitter Location"].ToString() : "";

        //        row["digital_status"] = rst["Digital Status"] != DBNull.Value ? rst["Digital Status"].ToString() : "";

        //        row["effective_radiated_power"] = rst["Effective Radiated Power"] != DBNull.Value ? rst["Effective Radiated Power"].ToString() : "";

        //        row["frequency"] = rst["Frequency"] != DBNull.Value ? rst["Frequency"].ToString() : "";

        //        row["height_above_avg_terrain"] = rst["Height Above Avg Terrain"] != DBNull.Value ? rst["Height Above Avg Terrain"].ToString() : "";

        //        row["height_above_ground_level"] = rst["Height Above Ground Level"] != DBNull.Value ? rst["Height Above Ground Level"].ToString() : "";

        //        row["height_above_sea_level"] = rst["Height Above Sea Level"] != DBNull.Value ? rst["Height Above Sea Level"].ToString() : "";

        //        row["horizontal_effective_radiated_power"] = rst["Horizontal Effective Radiated Power"] != DBNull.Value ? rst["Horizontal Effective Radiated Power"].ToString() : "";

        //        row["horizontal_height_above_avg_terrain"] = rst["Horizontal Height Above Avg Terrain"] != DBNull.Value ? rst["Horizontal Height Above Avg Terrain"].ToString() : "";

        //        row["horizontal_height_above_ground_level"] = rst["Horizontal Height Above Ground Level"] != DBNull.Value ? rst["Horizontal Height Above Ground Level"].ToString() : "";

        //        row["horizontal_height_above_sea_level"] = rst["Horizontal Height Above Sea Level"] != DBNull.Value ? rst["Horizontal Height Above Sea Level"].ToString() : "";

        //        row["horizontal_maximum_effective_radiated_power"] = rst["Horizontal Maximum Effective Radiated Power"] != DBNull.Value ? rst["Horizontal Maximum Effective Radiated Power"].ToString() : "";

        //        row["hours_of_operation"] = rst["Hours Of Operation"] != DBNull.Value ? rst["Hours Of Operation"].ToString() : "";

        //        row["last_fcc_update"] = rst["Last Fcc Update"] != DBNull.Value ? rst["Last Fcc Update"].ToString() : "";

        //        row["license_expires"] = rst["License Expires"] != DBNull.Value ? rst["License Expires"].ToString() : "";

        //        row["license_granted"] = rst["License Granted"] != DBNull.Value ? rst["License Granted"].ToString() : "";

        //        row["maximum_effective_radiated_power"] = rst["Maximum Effective Radiated Power"] != DBNull.Value ? rst["Maximum Effective Radiated Power"].ToString() : "";

        //        row["new_city"] = rst["New City"] != DBNull.Value ? rst["New City"].ToString() : "";

        //        row["new_cp_frequency"] = rst["New Cp Frequency"] != DBNull.Value ? rst["New Cp Frequency"].ToString() : "";

        //        row["new_frequency"] = rst["New Frequency"] != DBNull.Value ? rst["New Frequency"].ToString() : "";

        //        row["nighttime_number_of_towers"] = rst["Nighttime Number Of Towers"] != DBNull.Value ? rst["Nighttime Number Of Towers"].ToString() : "";

        //        row["nighttime_power"] = rst["Nighttime Power"] != DBNull.Value ? rst["Nighttime Power"].ToString() : "";

        //        row["nighttime_transmitter_location"] = rst["Nighttime Transmitter Location"] != DBNull.Value ? rst["Nighttime Transmitter Location"].ToString() : "";

        //        row["number_of_towers"] = rst["Number Of Towers"] != DBNull.Value ? rst["Number Of Towers"].ToString() : "";

        //        row["power"] = rst["Power"] != DBNull.Value ? rst["Power"].ToString() : "";

        //        row["station_status"] = rst["Station Status"] != DBNull.Value ? rst["Station Status"].ToString() : "";

        //        row["status"] = rst["Status"] != DBNull.Value ? rst["Status"].ToString() : "";

        //        row["transmitter_location"] = rst["Transmitter Location"] != DBNull.Value ? rst["Transmitter Location"].ToString() : "";

        //        row["vertical_effective_radiated_power"] = rst["Vertical Effective Radiated Power"] != DBNull.Value ? rst["Vertical Effective Radiated Power"].ToString() : "";

        //        row["vertical_height_above_avg_terrain"] = rst["Vertical Height Above Avg Terrain"] != DBNull.Value ? rst["Vertical Height Above Avg Terrain"].ToString() : "";

        //        row["vertical_height_above_ground_level"] = rst["Vertical Height Above Ground Level"] != DBNull.Value ? rst["Vertical Height Above Ground Level"].ToString() : "";

        //        row["vertical_height_above_sea_level"] = rst["Vertical Height Above Sea Level"] != DBNull.Value ? rst["Vertical Height Above Sea Level"].ToString() : "";

        //        row["lat_long_location"] = rst["Lat_Long_Location"] != DBNull.Value ? rst["Lat_Long_Location"].ToString() : "";

        //        row["lat"] = rst["Lat"] != DBNull.Value ? rst["Lat"].ToString() : "";

        //        row["long"] = rst["Long"] != DBNull.Value ? rst["Long"].ToString() : "";

        //        row["location_within100km"] = rst["location_within100km"] != DBNull.Value ? rst["location_within100km"].ToString() : "";

        //        data.Add(row);
        //    }

        //    string json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);

        //    System.IO.File.WriteAllText("data.json", json);

        //    conn.Close();
        //}
        #endregion

        #region Convert_Decimal_From_Coordinates
        //string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=radio-locator.com.mdb; Jet OLEDB:Database Password=qwer@1234;Persist Security Info=True";

        //using (OleDbConnection conn = new OleDbConnection(connString))
        //{
        //    conn.Open();

        //    OleDbCommand cmd = new OleDbCommand("SELECT * FROM Data", conn);
        //    OleDbDataReader rst = cmd.ExecuteReader();

        //    while (rst.Read())
        //    {
        //        if (rst["Transmitter Location"].ToString() != "")
        //        {
        //            string coordinates = rst["Transmitter Location"].ToString();
        //            string decimalCoordinates = ConvertCoordinatesToDecimal(coordinates);

        //            string updateQuery = "UPDATE Data SET Lat_Long_Location = @DecimalCoordinates WHERE Id = @Id";

        //            using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn))
        //            {
        //                updateCmd.Parameters.AddWithValue("@DecimalCoordinates", decimalCoordinates);
        //                updateCmd.Parameters.AddWithValue("@Id", rst["id"]);
        //                updateCmd.ExecuteNonQuery();
        //            }
        //        }
        //    }
        //}
        #endregion

        #region Split_Lat_Long

        //string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=radio-locator.com.mdb; Jet OLEDB:Database Password=qwer@1234;Persist Security Info=True";
        //OleDbConnection conn = new OleDbConnection(connectionString);

        //conn.Open();
        //OleDbCommand cmd = new OleDbCommand("SELECT * FROM Data", conn);
        //OleDbDataReader rst = cmd.ExecuteReader();

        //while (rst.Read())
        //{
        //    string[] latLong = rst["Lat_Long_Location"].ToString().Split(',');
        //    double latitude = Convert.ToDouble(latLong[0].Trim());
        //    double longitude = Convert.ToDouble(latLong[1].Trim());

        //    int id = Convert.ToInt32(rst["id"]);

        //    using (OleDbCommand upcmd = new OleDbCommand("UPDATE [Data] SET [Lat]=@latitude, [Long]=@longitude WHERE [id]=@id", conn))
        //    {
        //        upcmd.Parameters.AddWithValue("@latitude", latitude);
        //        upcmd.Parameters.AddWithValue("@longitude", longitude);
        //        upcmd.Parameters.AddWithValue("@id", id);
        //        upcmd.ExecuteNonQuery();
        //    }
        //}
        //conn.Close();
        #endregion

        #region Retrieve_Data
        //string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=radio-locator.com.mdb; Jet OLEDB:Database Password=qwer@1234;Persist Security Info=True";
        //OleDbConnection conn = new OleDbConnection(connectionString);
        //conn.Open();
        //OleDbCommand cmd = new OleDbCommand("SELECT * FROM Data", conn);
        //OleDbDataReader rst = cmd.ExecuteReader();

        //OleDbConnection conn3 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=radio-locator.com1.mdb; Jet OLEDB:Database Password=qwer@1234;Persist Security Info=True");
        //conn3.Open();

        OleDbConnection conn1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=USLocation.mdb; Jet OLEDB:Database Password=qwer@1234;Persist Security Info=True");
        conn1.Open();
        OleDbCommand cmd1 = new OleDbCommand("SELECT * FROM US", conn1);
        OleDbDataReader rst1 = cmd1.ExecuteReader();

        SQLiteConnection conn2 = new SQLiteConnection("Data Source=RetrieveRadioStation.db;Version=3;"); 
        conn2.Open();

        while (rst1.Read()) 
        {
            List<Tuple<string, string>> idLatLongList = new List<Tuple<string, string>>();
            
            double latitude = Convert.ToDouble(rst1["lat"]);
            double longitude = Convert.ToDouble(rst1["lng"]);
            double distanceKm = 100;

            double[] boundingBox = CalculateBoundingBox(latitude, longitude, distanceKm);
            double minLat = boundingBox[0];
            double maxLat = boundingBox[1];
            double minLon = boundingBox[2];
            double maxLon = boundingBox[3];

            using (OleDbCommand retrieveCommand = new OleDbCommand(@"SELECT * FROM Data WHERE Lat BETWEEN @minLat and @maxLat AND Long BETWEEN @minLon and @maxLon", conn1))
            {
                retrieveCommand.Parameters.AddWithValue("?", minLat);
                retrieveCommand.Parameters.AddWithValue("?", maxLat);
                retrieveCommand.Parameters.AddWithValue("?", minLon);
                retrieveCommand.Parameters.AddWithValue("?", maxLon);

                OleDbDataReader datarst = retrieveCommand.ExecuteReader();

                while (datarst.Read())
                {
                    string latLong = datarst["Lat_Long_Location"].ToString();
                    string id = datarst["id"].ToString();

                    idLatLongList.Add(Tuple.Create(id, latLong));
                }

                if (idLatLongList.Count > 0)
                {
                    idLatLongList = SortListByDistanceNearestFirst(idLatLongList, latitude, longitude).Take(10).ToList();

                    Dictionary<string, string> idLatLongDictionary = idLatLongList.ToDictionary(item => item.Item1, item => item.Item2);

                    int retrievedDataCount = idLatLongDictionary.Count;

                    int currentCityId = 0;
                    int sequence = 0;

                    foreach (var item in idLatLongDictionary)
                    {
                        string id = item.Key;
                        using (OleDbCommand cmd3 = new OleDbCommand(@"SELECT * FROM Data WHERE id = @id", conn1))
                        {
                            cmd3.Parameters.AddWithValue("@id", id);
                            using (OleDbDataReader rst3 = cmd3.ExecuteReader())
                            {
                                if (rst3 != null)
                                {
                                    while (rst3.Read())
                                    {
                                        int cityId = Convert.ToInt32(rst1["id"]);
                                        if (cityId != currentCityId)
                                        {
                                            currentCityId = cityId;
                                            sequence = 1; // Reset sequence number when city ID changes
                                        }

                                        SQLiteCommand cmd2 = new SQLiteCommand("INSERT INTO [Data] ([state], [city_id], [city], [lat], [lng], [retrievedDataWithin100km(nearest)], [sequence], [station_city], [station_id], [transmitter_location], [radio], [station_name], [phone], [fax], [station_address], [station_owner], [redirect_url], [audio_feed], [website_url]) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", conn2);
                                        cmd2.Parameters.AddWithValue("", rst1["state"].ToString());
                                        cmd2.Parameters.AddWithValue("", rst1["id"].ToString());
                                        cmd2.Parameters.AddWithValue("", rst1["city"].ToString());
                                        cmd2.Parameters.AddWithValue("", rst1["lat"].ToString());
                                        cmd2.Parameters.AddWithValue("", rst1["lng"].ToString());
                                        cmd2.Parameters.AddWithValue("", item);
                                        cmd2.Parameters.AddWithValue("", sequence);
                                        cmd2.Parameters.AddWithValue("", rst3["City"].ToString());
                                        cmd2.Parameters.AddWithValue("", id);
                                        cmd2.Parameters.AddWithValue("", rst3["Transmitter Location"].ToString());
                                        cmd2.Parameters.AddWithValue("", rst3["Radio"].ToString());
                                        cmd2.Parameters.AddWithValue("", rst3["Station"].ToString());
                                        cmd2.Parameters.AddWithValue("", rst3["Phone"].ToString());
                                        cmd2.Parameters.AddWithValue("", rst3["Fax"].ToString());
                                        cmd2.Parameters.AddWithValue("", rst3["Station Address"].ToString());
                                        cmd2.Parameters.AddWithValue("", rst3["Station Owner"].ToString());
                                        cmd2.Parameters.AddWithValue("", rst3["Redirect"].ToString());
                                        cmd2.Parameters.AddWithValue("", rst3["Audio Feed URL"].ToString());
                                        cmd2.Parameters.AddWithValue("", rst3["Website URL"].ToString());
                                        cmd2.ExecuteNonQuery();

                                        string cityName = rst1["city"].ToString();
                                        string idFromUSLocation = rst1["id"].ToString();
                                        Console.WriteLine($"Row processed: ID = {idFromUSLocation}, Date & Time = {DateTime.Now}, City = {cityName}");
                                        sequence++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        
        conn1.Close();
        #endregion
    }

    public static string ConvertCoordinatesToDecimal(string coordinates)
    {
        string[] parts = coordinates.Split(',');

        // Extract latitude and longitude strings
        string latitudeString = parts[0].Trim();
        string longitudeString = parts[1].Trim();

        double latitude = ConvertToDecimal(latitudeString);

        double longitude = ConvertToDecimal(longitudeString);

        string decimalCoordinates = $"{latitude:F6}, {longitude:F6}";

        return decimalCoordinates;
    }

    public static double ConvertToDecimal(string coordinate)
    {
        string[] parts = coordinate.Split('°', '\'', '\"');

        double degrees = double.Parse(parts[0]);
        double minutes = double.Parse(parts[1]);
        double seconds = double.Parse(parts[2]);

        double decimalValue = degrees + (minutes / 60) + (seconds / 3600);

        // Check if the direction is South (for latitude) or West (for longitude) and negate the decimal value accordingly
        if (coordinate.Contains("S") || coordinate.Contains("W"))
        {
            decimalValue = -decimalValue;
        }

        return decimalValue;
    }

    public static double[] CalculateBoundingBox(double latitude, double longitude, double distanceKm)
    {
        double minLatitude = latitude - (180.0 / Math.PI) * (distanceKm / 6371.0);
        double maxLatitude = latitude + (180.0 / Math.PI) * (distanceKm / 6371.0);
        double minLongitude = longitude - ((180.0 / Math.PI) * (distanceKm / 6371.0)) / Math.Cos(latitude * Math.PI / 180.0);
        double maxLongitude = longitude + ((180.0 / Math.PI) * (distanceKm / 6371.0)) / Math.Cos(latitude * Math.PI / 180.0);

        return new double[] { minLatitude, maxLatitude, minLongitude, maxLongitude };
    }

    public static List<Tuple<string, string>> SortListByDistanceNearestFirst(List<Tuple<string, string>> list, double latitude, double longitude)
        {
        return list.OrderBy(item => CalculateDistance(latitude, longitude, GetLatitudeFromLatLong(item.Item2), GetLongitudeFromLatLong(item.Item2))).ToList();
    }

    public static List<Tuple<string, string>> SortListByDistanceFarthestFirst(List<Tuple<string, string>> list, double latitude, double longitude)
    {
        return list.OrderByDescending(item => CalculateDistance(latitude, longitude, GetLatitudeFromLatLong(item.Item2), GetLongitudeFromLatLong(item.Item2))).ToList();
    }

    public static double GetLatitudeFromLatLong(string latLong)
    {
        return Convert.ToDouble(latLong.Split(',')[0]);
    }

    public static double GetLongitudeFromLatLong(string latLong)
    {
        return Convert.ToDouble(latLong.Split(',')[1]);
    }

    public static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
    {
        // Formula to calculate distance between two coordinates
        const double R = 6371; // Radius of the earth in km
        var dLat = DegreeToRadian(lat2 - lat1);
        var dLon = DegreeToRadian(lon2 - lon1);
        var a =
            Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
            Math.Cos(DegreeToRadian(lat1)) * Math.Cos(DegreeToRadian(lat2)) *
            Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
        var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        var d = R * c; // Distance in km
        return d;
    }

    public static double DegreeToRadian(double deg)
    {
        return deg * (Math.PI / 180);
    }
}
