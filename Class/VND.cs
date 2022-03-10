using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


public class VND
{

    private static string ParseMoney1(string _digit, int _position)
    {

        switch (_digit)
        {
            case "1": return "một ";
            case "2": return "hai ";
            case "3": return "ba ";
            case "4": return "bốn ";
            case "5": return "năm ";
            case "6": return "sáu ";
            case "7": return "bảy ";
            case "8": return "tám ";
            case "9": return "chín ";
            case "10": return "mười ";
            //case "1": return "mot ";
            //case "2": return "hai ";
            //case "3": return "ba ";
            //case "4": return "bon ";
            //case "5": return "nam ";
            //case "6": return "sau ";
            //case "7": return "bay ";
            //case "8": return "tam ";
            //case "9": return "chin ";
            //case "10": return "muoi ";
        }
        return string.Empty;
    }

    private static string ParseMoney2(int _len)
    {
        switch (_len)
        {
            case 1: return "mươi ";
            case 2: return "trăm ";
            case 3: return "nghìn ";
            case 6: return "triệu ";
            case 9: return "tỉ ";

            //case 1: return "muoi ";
            //case 2: return "tram ";
            //case 3: return "nghin ";
            //case 6: return "trieu ";
            //case 9: return "ty ";
        }
        return string.Empty;
    }

    private static string Analize(string _moneyTemp)
    {
        string _strReturn = string.Empty;
        string _temp = string.Empty;
        while (_moneyTemp != string.Empty)
        {
            _temp = _moneyTemp.Substring(0, 3);
            _moneyTemp = _moneyTemp.Remove(0, 3);

            string _t = _temp;
            //string _t = Convert.ToInt32(_temp).ToString();
            for (int i = 0; i < _temp.Length; i++)
            {

                if (i == 1 && Convert.ToInt32(_t.Substring(1, 2)) / 10 == 1)
                {
                    _strReturn += "mười ";
                }
                else
                {
                    if (i == 2 && _t[2] == '1' && Convert.ToInt32(_t.Substring(1, 2)) / 10 >= 2)
                        _strReturn += "mốt";
                    else
                    {
                        if (_t[i] != '0' && i == 2 && _t[1] == '0' && _strReturn != string.Empty)
                            _strReturn += "lẻ ";
                        if (i == 2 && _t[1] != '0' && _t[2] == '5' && _strReturn != string.Empty)
                        {
                            _strReturn += "lăm ";
                        }
                        else
                            _strReturn += ParseMoney1(_t[i].ToString(), i);

                        if (_t[i] != '0')
                            _strReturn += ParseMoney2(_t.Length - i - 1);

                    }

                }

            }
            if (Convert.ToInt32(_temp) != 0)
                _strReturn += ParseMoney2(_moneyTemp.Length);
        }
        return _strReturn;
    }

    public static string process(string _moneyTemp)
    {
        string _temp = string.Empty;
        string _strReturn = string.Empty;
        string _bilionGroup = string.Empty;
        string _milionGroup = string.Empty;
        while (_moneyTemp.Length % 3 != 0)
        {
            _moneyTemp = "0" + _moneyTemp;
        }

        if (_moneyTemp.Length > 9)
        {
            _bilionGroup = _moneyTemp.Substring(0, _moneyTemp.Length - 9);
            _strReturn += Analize(_bilionGroup);
            _strReturn += "tỷ ";
        }
        _milionGroup = _moneyTemp.Substring(_bilionGroup.Length);
        _strReturn += Analize(_milionGroup);


        return _strReturn;
    }



}
