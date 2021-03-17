using System;
using System.Data;

using System.Collections.Generic;
using System.Data.SqlClient;

/// <summary>
/// Respublika klassı
/// </summary>
public class Respublika
{
	public Respublika()
	{
        _Rayonlar = new Rayonlar();
	}
    private Rayonlar _Rayonlar;
}
public class Rayonlar
{
    public Rayonlar()
    {
        _ResRayonlari = new List<Rayon>();

        string strSQL;
        using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Test_db;Integrated Security=True"))
        {
            strSQL = "SELECT R.RegionCode FROM Regions ORDER BY Position";
            connection.Open();
            SqlCommand command = new SqlCommand(strSQL, connection);
            SqlDataReader sreader = command.ExecuteReader();
            while (sreader.Read())
            {
                _ResRayonlari.Add(new Rayon((int)sreader[0]));
            }
            sreader.Close();
        }
    }

    private List<Rayon> _ResRayonlari;
    public List<Rayon> ResRayonlari
    {
        get
        {
            return _ResRayonlari;
        }
    }
}
