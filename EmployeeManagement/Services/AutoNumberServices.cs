using System;
using System.Data.SqlClient;
using EmployeeManagement.Model;

namespace EmployeeManagement.Services
{
    class AutoNumberServices : AbstractServices
    {
        public string getEmployeeNo(string employeeSuffix)
        {
            string employeePrefix = "BLG";
            int employeePadding = 4;
            string employeeGroupType = "EMPLOYEE NO";

            AutoNumberModel autonumbers = find(employeeGroupType);
            if (autonumbers == null)
            {
                autonumbers = new AutoNumberModel()
                {
                    prefix = employeePrefix,
                    suffix = employeeSuffix,
                    zeroPadding = employeePadding,
                    groupType = employeeGroupType
                };
                save(autonumbers);
                autonumbers = find(employeeGroupType);
            }

            autonumbers.suffix = employeeSuffix;
            update(autonumbers);
            AutoNumberModel newautonumbers = find(autonumbers.id);
            return newautonumbers.displaySequence;
        }
        public AutoNumberModel find(int id)
        {
            try
            {
                AutoNumberModel entity = null;
                string query = "SELECT * " +
                               "FROM autonumbers " +
                               "WHERE id = @id ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id.ToString());

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            dataReader.Read();
                            entity = new AutoNumberModel();
                            entity.id = int.Parse(dataReader["id"].ToString());
                            entity.lastModifiedDate = DateTime.Parse(dataReader["lastModifiedDate"].ToString());
                            entity.isActive = dataReader["isActive"].ToString() == "1" ? true : false;
                            entity.prefix = dataReader["prefix"].ToString();
                            entity.suffix = dataReader["suffix"].ToString();
                            entity.currentSequence = int.Parse(dataReader["currentSequence"].ToString());
                            entity.zeroPadding = int.Parse(dataReader["zeroPadding"].ToString());
                            entity.displaySequence = dataReader["displaySequence"].ToString();
                            entity.groupType = dataReader["groupType"].ToString();
                        }
                        dataReader.Close();
                    }
                    connection.Close();
                }

                return entity;

            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Service Error: " + ex.Message);
                return null;
            }
        }
        private AutoNumberModel find(string groupType)
        {
            try
            {
                AutoNumberModel entity = null;
                string query = "SELECT * " +
                               "FROM autonumbers " +
                               "WHERE groupType = @groupType ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@groupType", groupType);

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            dataReader.Read();
                            entity = new AutoNumberModel();
                            entity.id = int.Parse(dataReader["id"].ToString());
                            entity.lastModifiedDate = DateTime.Parse(dataReader["lastModifiedDate"].ToString());
                            entity.isActive = dataReader["isActive"].ToString() == "1" ? true : false;
                            entity.prefix = dataReader["prefix"].ToString();
                            entity.suffix = dataReader["suffix"].ToString();
                            entity.currentSequence = int.Parse(dataReader["currentSequence"].ToString());
                            entity.zeroPadding = int.Parse(dataReader["zeroPadding"].ToString());
                            entity.displaySequence = dataReader["displaySequence"].ToString();
                            entity.groupType = dataReader["groupType"].ToString();
                        }
                        dataReader.Close();
                    }
                    connection.Close();
                }

                return entity;

            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Service Error: " + ex.Message);
                return null;
            }
        }
        private AutoNumberModel find(string prefix, string groupType, int zeroPadding, int currentSequence)
        {
            try
            {
                AutoNumberModel entity = null;
                string query = "SELECT * " +
                               "FROM autonumbers " +
                               "WHERE groupType = @groupType " +
                               "AND prefix = @prefix " +
                               "AND zeroPadding = @zeroPadding " +
                               "AND currentSequence = @currentSequence ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@groupType", groupType);
                    command.Parameters.AddWithValue("@prefix", prefix);
                    command.Parameters.AddWithValue("@zeroPadding", zeroPadding);
                    command.Parameters.AddWithValue("@currentSequence", currentSequence);
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            dataReader.Read();
                            entity = new AutoNumberModel();
                            entity.id = int.Parse(dataReader["id"].ToString());
                            entity.lastModifiedDate = DateTime.Parse(dataReader["lastModifiedDate"].ToString());
                            entity.isActive = dataReader["isActive"].ToString() == "1" ? true : false;
                            entity.prefix = dataReader["prefix"].ToString();
                            entity.suffix = dataReader["suffix"].ToString();
                            entity.currentSequence = int.Parse(dataReader["currentSequence"].ToString());
                            entity.zeroPadding = int.Parse(dataReader["zeroPadding"].ToString());
                            entity.displaySequence = dataReader["displaySequence"].ToString();
                            entity.groupType = dataReader["groupType"].ToString();
                        }
                        dataReader.Close();
                    }
                    connection.Close();
                }

                return entity;

            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Service Error: " + ex.Message);
                return null;
            }
        }

        private bool save(AutoNumberModel entity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO autonumbers " +
                                   "(prefix, suffix, zeroPadding, displaySequence, groupType) " +
                                   "VALUES " +
                                   "(@prefix, @suffix, @zeroPadding, @displaySequence, @groupType) ";

                    string startSequence = entity.currentSequence.ToString();
                    char charPadding = '0';
                    string displaySequence = entity.prefix + startSequence.PadLeft(entity.zeroPadding, charPadding) + entity.suffix;

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@prefix", entity.prefix);
                    command.Parameters.AddWithValue("@suffix", entity.suffix);
                    command.Parameters.AddWithValue("@zeroPadding", entity.zeroPadding);
                    command.Parameters.AddWithValue("@displaySequence", displaySequence);
                    command.Parameters.AddWithValue("@groupType", entity.groupType);
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Service Error: " + ex.Message);
                return false;
            }
        }

        private bool update(AutoNumberModel entity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE autonumbers " +
                                   "SET lastModifiedDate = @lastModifiedDate, " +
                                   "prefix = @prefix, " +
                                   "suffix = @suffix, " +
                                   "currentSequence = @currentSequence, " +
                                   "zeroPadding = @zeroPadding, " +
                                   "displaySequence = @displaySequence, " +
                                   "groupType = @groupType " +
                                   "WHERE id = @id ";

                    string startSequence = (entity.currentSequence + 1).ToString();
                    char charPadding = '0';
                    string displaySequence = entity.prefix + startSequence.PadLeft(entity.zeroPadding, charPadding) + entity.suffix;

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@lastModifiedDate", DateTime.Now);
                    command.Parameters.AddWithValue("@prefix", entity.prefix);
                    command.Parameters.AddWithValue("@suffix", entity.suffix);
                    command.Parameters.AddWithValue("@currentSequence", entity.currentSequence + 1);
                    command.Parameters.AddWithValue("@zeroPadding", entity.zeroPadding);
                    command.Parameters.AddWithValue("@displaySequence", displaySequence);
                    command.Parameters.AddWithValue("@groupType", entity.groupType);
                    command.Parameters.AddWithValue("@id", entity.id);
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Service Error: " + ex.Message);
                return false;
            }
        }
        public bool updateNewEmployeeNo(string employeeNo)
        {
            string employeePrefix = "BLG";
            int employeePadding = 4;
            string employeeGroupType = "EMPLOYEE NO";
            int sequence = int.Parse(employeeNo.Substring(3, 4)) - 1;

            AutoNumberModel autoNumber = find(employeePrefix, employeeGroupType, employeePadding, sequence);
            if (autoNumber == null)
            {
                return false;
            }

            update(autoNumber);

            return true;
        }
        public string generatePassword(bool alphaNumeric, int size)
        {
            string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string small_alphabets = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "1234567890";

            string characters = numbers;
            if (alphaNumeric)
            {
                characters += alphabets + small_alphabets + numbers;
            }

            int length = size;
            string otp = string.Empty;

            for (int i = 0; i < length; i++)
            {
                string character = string.Empty;
                do
                {
                    int index = new Random().Next(0, characters.Length);
                    character = characters.ToCharArray()[index].ToString();
                } while (otp.IndexOf(character) != -1);
                otp += character;
            }

            return otp;
        }
    }
}
