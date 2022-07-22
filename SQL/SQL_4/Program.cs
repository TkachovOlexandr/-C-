using SQL_4;
using System.Data.SqlClient;

//PersonInfo users = null;
PersonInfo[] people = new PersonInfo[0];
int myLength = 5;
using (SqlConnection conn = new SqlConnection("Server=DESKTOP-32NV42E;Database=Phone_Book;Trusted_Connection=True;"))
{
    conn.Open();
    using (SqlCommand cmd = new SqlCommand(String.Format("SELECT TOP ({0}) [Personal_date].[Id], [Person_name], [Person_surname], [Person_age], [Phone_number] FROM (([Personal_date] INNER JOIN [Phone] ON [Personal_date].[Id] = [Phone].[Personal_date_id]) INNER JOIN [Phone_number] ON [Phone_number].[Id] = [Phone].[Phone_number_id]);", myLength), conn))
    {
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            for (int i = 0; i < myLength; i++)
            {
                Array.Resize(ref people, people.Length + 1);
                people[i] = new PersonInfo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4));
            }
        }
    }
}

for (int i = 0; i < people.Length; i++)
    Console.WriteLine(people[i].ToString());