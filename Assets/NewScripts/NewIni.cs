using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

public class NewIni : MonoBehaviour
{
    public NewIni(string filePath)
    {
        this.Path = filePath;
    }

    string Path;

    [DllImport("kernel32")]
    private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
    [DllImport("kernel32")]
    private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);


    //写入INI文件 
    public void IniWrite(string Section, string Key, string Value)
    {
        WritePrivateProfileString(Section, Key, Value, Path);
    }


    // 读出INI文件 
    public string IniRead(string Section, string Key)
    {
        StringBuilder temp = new StringBuilder(500);
        int i = GetPrivateProfileString(Section, Key, "", temp, 500, Path);
        return temp.ToString();
    }


    // 验证文件是否存在 
    public bool ExistINI()
    {
        return File.Exists(Path);
    }
}
