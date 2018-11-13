using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Text;
using System.Reflection;
using Entity.Components;
using System.Globalization;



/// <summary>
/// Summary description for HelperFunction
/// </summary>
public class HelperFunctionEntity
{

    private static Hashtable m_executingPages = new Hashtable();
    public HelperFunctionEntity()
    {
        // TODO: Add constructor logic here
        //       
    }
    public string GetEngNumberToUnicode(string uniNumber)
    {
        string strNumber = "";
        int TotalChars = uniNumber.Length;
        for (int i = 0; i < TotalChars; i++)
        {
            string strEchar = "";
            string strNChar = uniNumber.ToString().Substring(i, 1);
            switch (strNChar)
            {
                case "0":
                    strEchar = "०";
                    strNumber = strNumber + strEchar;
                    break;
                case "1":
                    strEchar = "१";
                    strNumber = strNumber + strEchar;
                    break;

                case "2":
                    strEchar = "२";
                    strNumber = strNumber + strEchar;
                    break;

                case "3":
                    strEchar = "३";
                    strNumber = strNumber + strEchar;
                    break;

                case "4":
                    strEchar = "४";
                    strNumber = strNumber + strEchar;
                    break;

                case "5":
                    strEchar = "५";
                    strNumber = strNumber + strEchar;
                    break;

                case "6":
                    strEchar = "६";
                    strNumber = strNumber + strEchar;
                    break;

                case "7":
                    strEchar = "७";
                    strNumber = strNumber + strEchar;
                    break;

                case "8":
                    strEchar = "८";
                    strNumber = strNumber + strEchar;
                    break;
                case "9":
                    strEchar = "९";
                    strNumber = strNumber + strEchar;
                    break;
            }
        }
        return strNumber;
    }
    public string GetUnicodeToEngNumber(string uniNumber)
    {
        string strNumber = "";
        int TotalChars = uniNumber.Length;
        for (int i = 0; i < TotalChars; i++)
        {
            string strEchar = "";
            string strNChar = uniNumber.ToString().Substring(i, 1);
            switch (strNChar)
            {
                case "०":
                    strEchar = "0";
                    strNumber = strNumber + strEchar;
                    break;
                case "१":
                    strEchar = "1";
                    strNumber = strNumber + strEchar;
                    break;

                case "२":
                    strEchar = "2";
                    strNumber = strNumber + strEchar;
                    break;

                case "३":
                    strEchar = "3";
                    strNumber = strNumber + strEchar;
                    break;

                case "४":
                    strEchar = "4";
                    strNumber = strNumber + strEchar;
                    break;

                case "५":
                    strEchar = "5";
                    strNumber = strNumber + strEchar;
                    break;

                case "६":
                    strEchar = "6";
                    strNumber = strNumber + strEchar;
                    break;

                case "७":
                    strEchar = "7";
                    strNumber = strNumber + strEchar;
                    break;

                case "८":
                    strEchar = "8";
                    strNumber = strNumber + strEchar;
                    break;
                case "९":
                    strEchar = "9";
                    strNumber = strNumber + strEchar;
                    break;
            }
        }
        return strNumber;
    }

    public string CheckDate(string str)
    {
        string[] shortdate = str.Split(' ');
        return shortdate[0];
    }
    public string NepaliMonths1EnglishDate(string NepaliYear, string NepaliMonth)
    {
        NCCSNepaliDateLib.NepaliDateClass nepalidate = new NCCSNepaliDateLib.NepaliDateClass();
        short NYear = short.Parse(NepaliYear);
        short NMonth = short.Parse(NepaliMonth);
        short NDay = 1;
        nepalidate.SetNepaliDate(NYear, NMonth, NDay);
        DateTime EngDate = nepalidate.GetEnglishDate();
        return EngDate.GetDateTimeFormats()[7].ToString();
        
    }
    public string checkFiscalYear(string month, string year)
    {
        string FY = "";
        try
        {
            int MM, CY, AY;

            MM = Int32.Parse(month);
            CY = Int32.Parse(year);
            if (MM < 4)
            {
                AY = CY - 1;
                FY = AY.ToString() + "/" + CY.ToString().Substring(2, 2);
            }
            else if (MM >= 4)
            {
                AY = CY + 1;
                FY = CY.ToString() + "/" + AY.ToString().Substring(2, 2);
            }
            else
            { }
        }
        catch
        {

        }
        return FY;
    }
    public string ConvertNepaliTOEnglish(string day, string month, string year)
     {


        NCCSNepaliDateLib.NepaliDateClass nepalidate = new NCCSNepaliDateLib.NepaliDateClass();

        nepalidate.SetNepaliDate(Convert.ToInt16(year), Convert.ToInt16(month), Convert.ToInt16(day));
        DateTime ENGDate = nepalidate.GetEnglishDate();
        return ENGDate.ToString("dd/MM/yyyy");

    }
    public string ConvertNepaliTOEnglishShortMonth(string day, string month, string year)
    {


        NCCSNepaliDateLib.NepaliDateClass nepalidate = new NCCSNepaliDateLib.NepaliDateClass();
        nepalidate.SetNepaliDate(Convert.ToInt16(year), Convert.ToInt16(month), Convert.ToInt16(day));
        DateTime ENGDate = nepalidate.GetEnglishDate();
        return ENGDate.GetDateTimeFormats()[7].ToString();
    }
    public string ConvertNepaliTOEnglishMonthChar(string day, string month, string year)
    {


        NCCSNepaliDateLib.NepaliDateClass nepalidate = new NCCSNepaliDateLib.NepaliDateClass();
        nepalidate.SetNepaliDate(Convert.ToInt16(year), Convert.ToInt16(month), Convert.ToInt16(day));
        DateTime ENGDate = nepalidate.GetEnglishDate();
        return ENGDate.GetDateTimeFormats()[7].ToString();

    }
    public string GetSingleNepaliDate(string EnglishDate)
    {
        CultureInfo ci = new CultureInfo("en-GB");
        short Nyear;
        short Nmonth;
        short Nday;
        NCCSNepaliDateLib.NepaliDateClass nepalidate = new NCCSNepaliDateLib.NepaliDateClass();
        DateTime englishDate = new DateTime();
        try
        {
            englishDate = Convert.ToDateTime(EnglishDate,ci);
        }
        catch
        {
            englishDate = DateTime.Today;
        }
        nepalidate.SetEnglishDate(englishDate.Date);
        nepalidate.GetNepaliDate(out Nyear, out Nmonth, out Nday);
        string NepaliDate=Nday.ToString()+"/" +Nmonth.ToString() + "/" + Nyear.ToString();
        return NepaliDate;
    }
    public string NepaliDay()
    {
        short Nyear;
        short Nmonth;
        short Nday;
        NCCSNepaliDateLib.NepaliDateClass nepalidate = new NCCSNepaliDateLib.NepaliDateClass();
        DateTime englishDate = new DateTime();
        englishDate = DateTime.Today;
        nepalidate.SetEnglishDate(englishDate.Date);
        nepalidate.GetNepaliDate(out Nyear, out Nmonth, out Nday);
        return Nday.ToString();
    }
    public string NepaliMonth()
    {
        short Nyear;
        short Nmonth;
        short Nday;
        NCCSNepaliDateLib.NepaliDateClass nepalidate = new NCCSNepaliDateLib.NepaliDateClass();
        DateTime englishDate = new DateTime();
        englishDate = DateTime.Today;
        nepalidate.SetEnglishDate(englishDate.Date);
        nepalidate.GetNepaliDate(out Nyear, out Nmonth, out Nday);
        return Nmonth.ToString();
    }
    public string NepaliYear()
    {
        short Nyear;
        short Nmonth;
        short Nday;
        NCCSNepaliDateLib.NepaliDateClass nepalidate = new NCCSNepaliDateLib.NepaliDateClass();
        DateTime englishDate = new DateTime();
        englishDate = DateTime.Today;
        nepalidate.SetEnglishDate(englishDate.Date);
        nepalidate.GetNepaliDate(out Nyear, out Nmonth, out Nday);
        return Nyear.ToString();
    }
    public string SplitNepaliDateToEnglish(string nepalidate)
    {
        string[] shortdates = nepalidate.Split('/');
        string day = shortdates[0];
        string month = shortdates[1];
        string year = shortdates[2];
        string englishdate;
        englishdate = ConvertNepaliTOEnglish(day, month, year);
        return englishdate;
    }
}
