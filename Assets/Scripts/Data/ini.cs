using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

public class ini : MonoBehaviour
{

    [DllImport("kernel32")]
    private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
    [DllImport("kernel32")]
    private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);


    //写入INI文件 
    public void IniWrite(string Section, string Key, string Value, string Path)
    {
        WritePrivateProfileString(Section, Key, Value, Path);
    }


    // 读出INI文件 
    public string IniRead(string Section, string Key, string Path)
    {
        StringBuilder temp = new StringBuilder(500);
        int i = GetPrivateProfileString(Section, Key, "", temp, 500, Path);
        return temp.ToString();
    }


    // 验证文件是否存在 
    // <returns>布尔值</returns> 
    public bool ExistINI(string Path)
    {
        return File.Exists(Path);
    }
}
