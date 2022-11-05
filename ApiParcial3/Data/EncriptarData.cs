using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace ApiParcial3.Data
{
    public class EncriptarData
    {
        
            //codificar base64
            public static string Encriptar(string str)
            {
                byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(str);
                return Convert.ToBase64String(encbuff);
            }

            //Decodificar base64
            public static string Base64_Decode(string str)
            {
                try
                {
                    byte[] decbuff = Convert.FromBase64String(str);
                    return System.Text.Encoding.UTF8.GetString(decbuff);
                }
                catch
                {
                    //si se envia una cadena si codificación base64, mandamos vacio
                    return "";
                }
            }
        

    }
}