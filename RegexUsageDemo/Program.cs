using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
namespace RegexUsageDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入一个邮箱：");
            //while (true)
            //{
            //    Console.WriteLine(Regex.IsMatch(Console.ReadLine(), @"^[-a-zA-Z0-9_]+@[a-zA-Z]+(\.[a-zA-Z]+){1,2}$"));
            //}
            //Console.WriteLine("请输入一个身份证号：");
            //while (true)
            //{
            //    Console.WriteLine(Regex.IsMatch(Console.ReadLine(),@"^([1-9]\d{14}|[1-9]\d{16}[1-9xX])$",RegexOptions.ECMAScript));
            //}
            //Console.WriteLine("请输入手机号：");
            //while (true)
            //{
            //    Console.WriteLine(Regex.IsMatch(Console.ReadLine(), @"^1[3-9]\d{9}$",RegexOptions.ECMAScript));
            //}
            //Console.WriteLine("请输入电话号（包含座机）：");
            //while (true)
            //{
            //    Console.WriteLine(Regex.IsMatch(Console.ReadLine(), @"^((\d{3,4}\-?\d{7,8})|\d{5}|1[3-9]\d{9})$", RegexOptions.ECMAScript));
            //}
            //Console.WriteLine("请输入IP地址：");
            //while (true)
            //{
            //    Console.WriteLine(Regex.IsMatch(Console.ReadLine(), @"^\d+(\.\d+){3}$", RegexOptions.ECMAScript));
            //}
            //Console.WriteLine("请输入日期：");
            //while (true)
            //{
            //    Console.WriteLine(Regex.IsMatch(Console.ReadLine(), @"^\d{4}-\d{2}-\d{2}$", RegexOptions.ECMAScript));
            //}
            //Console.WriteLine("请输入网址：");
            //while (true)
            //{
            //    Console.WriteLine(Regex.IsMatch(Console.ReadLine(), @"^(https?|ftp|file|thunder|ed2k)://[-.a-zA-Z0-9]+(\?([a-zA-Z][a-zA-Z0-9]+)=\w+)?$", RegexOptions.ECMAScript));
            //}

            //邮箱地址提取
            //string str = File.ReadAllText("email.txt");
            //MatchCollection matchCollection = Regex.Matches(str, @"[-a-zA-Z0-9_]+@[a-zA-Z]+(\.[a-zA-Z]+){1,2}"); //Regex.Matches(str, @"([^@]+)");
            //foreach (Match item in matchCollection)
            //{
            //    Console.WriteLine("地址：{0}", item.Groups[0].Value);
            //}
            //从文件路径中提取文件名
            //string path = @"c:\testspace\test/readme.txt";
            //Match match = Regex.Match(path,@"[^\/\\]+\.[a-zA-Z]+$");
            //Console.WriteLine("提取到的文件名是：{0}", match.Value);
            //提取IP地址信息
            //string ipAddress = "192.168.1.1[port=20,type=ftp]";
            //Match match = Regex.Match(ipAddress,@"([0-9]+(?:\.[0-9]+){3})\[port=([0-9]+)(?:,type=([a-zA-Z]+))?\]");
            //for (int i = 0; i < match.Groups.Count; i++)
            //{
            //    Console.WriteLine(match.Groups[i].Value);
            //}
            //Console.WriteLine("IP地址为:{0},端口号为：{1}",match.Groups[1].Value, match.Groups[2].Value);
            //字符中替换
            //string str = "fadsfsdafewjlkjrjrelkre435349igat9904324ljlsda24";
            //string res = Regex.Replace(str, @"\d+","--");
            //Console.WriteLine(res);
            //贪婪匹配
            //string str = "abccccc";
            //Console.WriteLine(Regex.IsMatch(str,"^abc*?$"));
            //Console.WriteLine(Regex.Match(str, "^abc*?$").Value);
            string str = "111。111111。1111。1111。";
            
            MatchCollection matchCollection = Regex.Matches(str, "(.)+?。");
            foreach (Match item in matchCollection)
            {
                Console.WriteLine(item.Value);
            }
            Console.ReadKey();
        }
    }
}
