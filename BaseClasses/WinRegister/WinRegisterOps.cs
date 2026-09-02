using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace SAPCrystalReports.BaseClasses.WinRegister
{
    public class WinRegisterOps
    {
        public static void AtualizaRegistro(string path, string keyName, object data)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.CreateSubKey(path))
                {
                    if (key != null)
                    {
                        key.SetValue(keyName, data);
                    }
                }
            }

            catch (Exception ex)
            {
            }
        }

        public static object ReadRegister(string path, string registerName)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path))
                {
                    if (!(key is null))
                    {
                        var value = key.GetValue(registerName);

                        if (value == null)
                        {
                        }
                        return value;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

