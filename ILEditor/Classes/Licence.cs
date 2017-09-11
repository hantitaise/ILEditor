﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ILEditor.Classes
{
    class Licence
    {
        public static Boolean hasExpired = false;
        public static Boolean IsValid(string Key)
        {
            RegistryKey licenceinfo = Registry.CurrentUser.CreateSubKey("idle");
            Boolean result = false;
            double unixTime = 0;
            DateTime dtDateTime;
            hasExpired = false;
            try
            {
                using (WebClient client = new WebClient())
                {
                    string url = "http://worksofbarry.com/idle/valid.php?k=" + Key + "&u=" + Environment.MachineName;
                    string strout = client.DownloadString(url);
                    if (strout != "false")
                    {
                        if (Double.TryParse(strout, out unixTime) == false)
                            throw new Exception("Not a number");

                        dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                        dtDateTime = dtDateTime.AddSeconds(unixTime).ToLocalTime();

                        licenceinfo.SetValue("ts", dtDateTime);
                        if (DateTime.Now < dtDateTime)
                        {
                            result = true;
                        }
                        else
                        {
                            hasExpired = true;
                        }
                        licenceinfo.SetValue("key", Key);
                    }
                    else
                    {
                        if (licenceinfo.GetValue("ts") != null)
                        {
                            licenceinfo.DeleteValue("ts");
                            hasExpired = true;
                        }
                    }
                }
            }
            catch 
            {
                if (licenceinfo.GetValue("ts") != null)
                {
                    dtDateTime = DateTime.Parse(licenceinfo.GetValue("ts").ToString());
                    if (DateTime.Now < dtDateTime)
                    {
                        result = true;
                    }
                    else
                    {
                        hasExpired = true;
                        licenceinfo.DeleteValue("ts");
                    }

                }
            }

            licenceinfo.Close();

            return result;
        }

        public static Boolean CheckExistsIsValid()
        {
            RegistryKey licenceinfo = Registry.CurrentUser.CreateSubKey("idle");

            Boolean result = false;
            string key = "";
            
            if (licenceinfo.GetValue("key") != null)
            {
                key = licenceinfo.GetValue("key").ToString();
                if (IsValid(key))
                    result = true;
            }

            licenceinfo.Close();

            return result;
        }
    }
}
