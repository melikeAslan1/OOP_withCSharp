using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SDK;
namespace TersCevir
{
    public class TersCevirEfekti : ISDK
    {
        public string EklentiAdi => "TERS CEVİRME EFEKTİ";

        public string Islem(string str)
        {
            String strYeni = "";

            for (int i = str.Length-1; i >= 0; i--)
            {
                strYeni += str[i];
            }
            return strYeni;
        }
    }
}
