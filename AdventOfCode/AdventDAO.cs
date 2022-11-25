using MySql.Data.MySqlClient;



namespace AdventOfCode
{
    public class AdventDAO
    {
        public static string? getInputForDaySub(int day, int sub)
        {
            string connstring = "server=localhost;uid=nico;pwd=1221;database=aocinputdb";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            string stm = "SELECT input FROM tasks WHERE day = ?day AND sub = ?sub";
            var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.Add(new MySqlParameter("day", day));
            cmd.Parameters.Add(new MySqlParameter("sub", sub));

            return cmd.ExecuteScalar().ToString();
        }

        public static void setInputForDaySub(int day, int sub, string input)
        {
            string connstring = "server=localhost;uid=nico;pwd=1221;database=aocinputdb";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            string query = "INSERT INTO tasks (day, sub, input) VALUES (?day, ?sub, ?input)";
            var cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add(new MySqlParameter("day", day));
            cmd.Parameters.Add(new MySqlParameter("sub", sub));
            cmd.Parameters.Add(new MySqlParameter("input", input));

            cmd.ExecuteNonQuery();
        }
    }
}
