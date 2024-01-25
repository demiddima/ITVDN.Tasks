using System;
using System.Text;

namespace MiniAppAspNetMVC.Crypt
{
    public class CryptPass
    {
        public string Encode(string passwod)
        {
            try
            {
                byte[] encByte = new byte[passwod.Length];
                encByte = Encoding.UTF8.GetBytes(passwod);
                string encyptPass = Convert.ToBase64String(encByte);
                return encyptPass;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in encode " + ex.Message);
            }
        }
    }


}
