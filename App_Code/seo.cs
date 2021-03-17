using System;
using System.Data;
using System.Configuration;
using System.Web;
public class seo
{
	public seo()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static string temizle(string metin)
    {
        string ifade = metin;
        ifade = ifade.Replace("'", "");
        ifade = ifade.Replace("%", "");
        ifade = ifade.Replace("<", "");
        ifade = ifade.Replace(">", "");
        ifade = ifade.Replace("[", "");
        ifade = ifade.Replace("]", "");
        ifade = ifade.Replace("(", "");
        ifade = ifade.Replace(")", "");

        return ifade;
    }
}
