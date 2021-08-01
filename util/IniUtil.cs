using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace SedentaryReminder.util
{
    public class IniUtil
    {
        private readonly string path = $"C:\\Users\\{System.Environment.UserName}\\AppData\\Local\\SedentaryReminder\\";
        private readonly string fileName = "";

        public IniUtil(string fileName)
        {
            this.fileName = fileName;
        }

        public IniUtil(string path, string fileName)
        {
            this.fileName = fileName;
            this.path = path;
        }

        /*
         * 读取ini文件内容。
         * return：成功返回ini内容，失败返回空字符串。
         */
        private string GetIniFile()
        {
            try
            {
                // using语句可以关闭 StreamReader
                using (StreamReader sr = new StreamReader(path + fileName, Encoding.Default))
                {
                    string line;
                    StringBuilder str = new StringBuilder();

                    // 从文件读取并显示行，直到文件的末尾 
                    while ((line = sr.ReadLine()) != null)
                    {
                        str.Append($"{line}\r\n");
                    }
                    return str.ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "";
            }
        }

        /*
         * parm1：ini字符串内容。
         * parm2：节点名。
         * parm3：返回字符串是否包含节点名。
         * 根据节点名从ini中找到节点内容。
         * return：成功返回节点内容，失败返回空字符串。
         */
        private string GetNodeContentByNodeFromIni(string ini, string node, bool includeNode = false)
        {
            // 获取节点首次出现地址
            int nodeBeginIndex = ini.IndexOf($"[{node}]\r\n");


            // 如果节点不存在返回空
            if (nodeBeginIndex == -1)
                return "";

            int nodeEndIndex = ini.IndexOf("\r\n[", nodeBeginIndex + node.Length + 2);
            if (nodeEndIndex == -1)
            {
                // 后面没有'['，证明当前节点在文本最后一个节点位置，nodeEndIndex直接取文本长度
                nodeEndIndex = ini.Length;
            }
            else
            {
                // 当前节点的下一个'['位置已经找到
                // 自增2是因为上面获取的是'\r\n['的位置，nodeEndIndex需要忽略掉'\r\n'
                nodeEndIndex += 2;
            }

            string nodeContent = ini.Substring(nodeBeginIndex, nodeEndIndex - nodeBeginIndex);
            return includeNode ? nodeContent :
                nodeContent.Substring(node.Length + 4, nodeContent.Length - (node.Length + 4));
        }


        /*
         * parm1：ini字符串内容。
         * parm2：节点名。
         * 根据节点名从ini中找到节点在ini中的起始位置。
         * return：成功返回索引，失败或节点不存在返回-1。
         */
        private int GetNodeBeginIndexByNodeFromIni(string ini, string node)
        {
            // 获取节点首次出现地址
            int nodeBeginIndex = ini.IndexOf($"[{node}]\r\n");

            // 如果节点不存在，或节点存在但是处于Value中，返回-1。
            if (nodeBeginIndex == -1
                || (nodeBeginIndex != 0 && !ini.Substring(nodeBeginIndex - 2, 2).Equals("\r\n")))
                return -1;

            return nodeBeginIndex;
        }

        /*
         * parm1：ini字符串内容。
         * parm2：节点名。
         * 根据节点名从ini中找到节点在ini中的结尾位置。
         * return：成功返回索引，失败或节点不存在返回-1。
         */
        private int GetNodeEndIndexByNodeFromIni(string ini, string node)
        {
            // 获取节点首次出现地址
            int nodeBeginIndex = GetNodeBeginIndexByNodeFromIni(ini, node);

            // 节点不存在
            if (nodeBeginIndex == -1)
                return -1;


            int nodeEndIndex = ini.IndexOf("\r\n[", nodeBeginIndex + node.Length + 2);
            if (nodeEndIndex == -1)
            {
                // 后面没有'['，证明当前节点在文本最后一个节点位置
                nodeEndIndex = ini.Length;
            }

            return nodeEndIndex;
        }

        /*
         * parm1：nodeContent节点内容。
         * parm2：要获取的value绑定的Key。
         * parm3：返回字符串是否包含Key。
         * 根据Key从节点内容中找到Value，nodeContent不能包含节点名。
         */
        private string GetValueByKeyFromNodeContent(string nodeContent, string key, bool includeKey = false)
        {
            int keyBeginIndex = nodeContent.IndexOf($"{key}=");
            // Key不存在，或者Key存在，但是Key位于Value中，返回空字符串。
            if (keyBeginIndex == -1
                || (keyBeginIndex != 0 && !nodeContent.Substring(keyBeginIndex - 2, 2).Equals("\r\n")))
                return "";

            // Key存在，返回从Key到\r\n之间的Value
            int valueLength =
                nodeContent.IndexOf("\r\n", keyBeginIndex) - keyBeginIndex - (key.Length + 1);

            return includeKey ? nodeContent.Substring(keyBeginIndex, valueLength + key.Length + 1) :
                nodeContent.Substring(keyBeginIndex + key.Length + 1, valueLength);
        }

        /*
        * parm1：ini字符串内容。
        * parm2：节点名。
        * 根据Key从NodeContent节点内容中找到Key在NodeContent中的起始位置。
        * return：成功返回索引，失败或节点不存在返回-1。
        */
        private int GetKeyBeginIndexByKeyFromNodeContent(string nodeContent, string key)
        {
            int keyBeginIndex = nodeContent.IndexOf($"{key}=");
            // Key不存在，或者Key存在，但是Key位于Value中，返回-1。
            if (keyBeginIndex == -1
                || (keyBeginIndex != 0 && !nodeContent.Substring(keyBeginIndex - 2, 2).Equals("\r\n")))
                return -1;
            return keyBeginIndex;
        }


        public string ReadString(string node, string key, string defaultValue = "")
        {
            // 读取Ini文件内容
            string ini = GetIniFile();
            if (ini.Length <= 0)
                return defaultValue;

            // 根据node节点名获取nodeContent节点内容
            string nodeContent = GetNodeContentByNodeFromIni(ini, node);
            if (nodeContent.Equals(""))
                return defaultValue;

            string value = GetValueByKeyFromNodeContent(nodeContent, key);
            if (value.Equals(""))
                return defaultValue;
            return value;
        }


        public int ReadInt(string node, string key, int defaultValue = 0)
        {
            try
            {
                string str = ReadString(node, key);
                return str.Equals("") ? defaultValue : int.Parse(str);
            } 
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return defaultValue;
            }
        }

        public float ReadFloat(string node, string key, float defaultValue = 0.0f)
        {
            try
            {
                string str = ReadString(node, key);
                return str.Equals("") ? defaultValue : float.Parse(str);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return defaultValue;
            }
        }

        public bool WriteString(string node, string key, string value)
        {
            string oldIni = "";
            string newIni = "";

            // 如果ini存在就直接读入
            if (File.Exists(path + fileName))
                oldIni = GetIniFile();

            // 判断oldIni是否是空文件
            if (oldIni.Length == 0)
                // 如果oldIni是空文件，直接写入节点名和Key-Value
                newIni = $"[{node}]\r\n{key}={value}\r\n";
            else
            {
                // 先判断节点是否存在，如果获取node节点开始索引为-1，证明节点不存在
                int nodeBeginIndex = GetNodeBeginIndexByNodeFromIni(oldIni, node);
                int nodeEndIndex = nodeBeginIndex == -1 ? -1 : 
                    GetNodeEndIndexByNodeFromIni(oldIni, node);
                if (nodeBeginIndex == -1)
                    // 节点不存在，直接在文尾写入节点名和Key-Value
                    newIni = oldIni + $"[{node}]\r\n{key}={value}\r\n";
                else
                {
                    // 节点存在，检索节点中是否存在Key
                    string nodeContent = GetNodeContentByNodeFromIni(oldIni, node);
                    int keyBeginIndex = GetKeyBeginIndexByKeyFromNodeContent(nodeContent, key);
                    if (keyBeginIndex == -1)
                    {
                        // Key不存在 ，在节点最后写入Key-Value
                        Console.WriteLine("###:" + oldIni.Substring(nodeEndIndex - 2, 2));
                        newIni = oldIni.Substring(nodeEndIndex -2, 2).Equals("\r\n") ?
                            oldIni.Insert(nodeEndIndex, $"{key}={value}") :
                            oldIni.Insert(nodeEndIndex, $"\r\n{key}={value}");
                    }
                    else
                    {
                        // Key存在，修改Key后面的Value
                        // 首先给Key起始位置加上节点起始位置和节点名以及'[]'的长度才是真实的Key在ini中的起始位置
                        keyBeginIndex += nodeBeginIndex + node.Length + 4;

                        // 获取Value长度
                        int valueLength = oldIni.IndexOf("\r\n", keyBeginIndex) - keyBeginIndex - key.Length - 1;
                        newIni = oldIni;
                        if (valueLength != 0)
                            // Value长度不为0，需要替换当前Value，首先删除当前Value
                            newIni = newIni.Remove(keyBeginIndex + key.Length + 1, valueLength);
                        // 在Key后写入新Value
                        newIni = newIni.Insert(keyBeginIndex + key.Length + 1, value);  
                    }
                } 
            }
            try
            {
                File.WriteAllText(path + fileName, newIni, Encoding.GetEncoding("GB2312"));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool WriteInt(string node, string key, int value)
        {
            return WriteString(node, key, value.ToString());
        }

        public bool WriteFloat(string node, string key, float value)
        {
            return WriteString(node, key, value.ToString());
        }

        //public Dictionary<string, Dictionary<string, string>> ReadStrings() {
        //    string ini = GetIniFile();
        //    if (ini.Length <= 0)
        //        return null;

        //    string[] inis = ini.Split('\n');
        //    string currentNodeStr = "";

        //    Dictionary<string, string> currentNode = null;
        //    Dictionary<string, Dictionary<string, string>> lists =
        //        new Dictionary<string, Dictionary<string, string>>();


        //    int i = 0;
        //    bool isNode = (inis[i].IndexOf("[") != -1 && inis[i].IndexOf("]") != -1 &&
        //            inis[i].IndexOf("\r") != -1);
        //}
    }
}
