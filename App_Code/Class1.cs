using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Web;
using System.IO;


public class Class1
{
    public Class1()
    {

    }
    public SqlConnection baglan()
    {
        SqlConnection baglan = new SqlConnection("Data Source=localhost;Initial Catalog=Test_db;Integrated Security=true");

        baglan.Open();
        return (baglan);

    }
    public int cmd(string sqlcumle)
    {
        SqlConnection baglan = this.baglan();
        SqlCommand cmd = new SqlCommand(sqlcumle, baglan);
        int sonuc = 0;
        try
        {
            sonuc = cmd.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {

            throw new Exception(ex.Message + "(" + sqlcumle + ")");
        }
        cmd.Dispose();
        baglan.Close();

        baglan.Dispose();
        return (sonuc);
    }

    

    public DataSet getdatagridview(string sqlcumle)
    {
        SqlConnection baglan = this.baglan();
        SqlDataAdapter dap = new SqlDataAdapter(sqlcumle, baglan);
        DataSet ds=new DataSet();
        try
        {
            dap.Fill(ds, "Person_Details");
            SqlCommandBuilder cmbld = new SqlCommandBuilder(dap);
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message + "(" + sqlcumle + ")");
        }
        dap.Dispose();
        baglan.Close();
        baglan.Dispose();
        return ds;
    }
    public DataTable getdatatable(string sqlcumle)
    {
        SqlConnection baglan = this.baglan();
        SqlDataAdapter dap = new SqlDataAdapter(sqlcumle, baglan);
        DataTable dt = new DataTable();
        try
        {
            dap.Fill(dt);
        }
        catch (SqlException ex)
        {

            throw new Exception(ex.Message + "(" + sqlcumle + ")");
        }

        dap.Dispose();
        baglan.Close();
        baglan.Dispose();
        return dt;
    }


    public DataRow GetDataRow(string sqlcumle)
    {
        DataTable dt = getdatatable(sqlcumle);
        if (dt.Rows.Count == 0)
            return null;
        else
            return dt.Rows[0];
    }
    public string getdatacell(string sqlcumle)
    {
        DataTable dt = getdatatable(sqlcumle);
        if (dt.Rows.Count == 0)
            return null;
        else
            return dt.Rows[0][0].ToString();
    }
    public static string vitrin(string vitrin)
    {
        string deger = "";
        if (vitrin == "1")
        {
            deger = "evet";
        }
        else
        {
            deger = "hayir";
        }
        return deger;
    }

    public static string vitrin2(string vitrin2)
    {
        string deger = "";
        if (vitrin2 == "1")
        {
            deger = "yok.png";
        }
        else
        {
            deger = "onay.png";
        }
        return deger;
    }
}




