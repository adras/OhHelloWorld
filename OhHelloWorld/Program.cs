using System;
using System.Text;
using System.Threading.Tasks;

class HelloWorld
{
    static void Main(string[] args)
    {
        for ((int x, string text, byte[] postText)[] data = { (0, "Hello ", new byte[] { 78, 101, 119, 32 }), (0xf4ca94A, "Br", null), (0b01100001011101100110010100100000, null, Encoding.ASCII.GetBytes("World")) }; data[0].x < data.Length; data[data[0].x + 1 < data.Length ? data[0].x + 1 : data.Length - 1].text = ((data[0].x + 1) * 3 == (BitConverter.ToInt32(Encoding.ASCII.GetBytes(data[0].text), 0) - (data[1].x) & (data[0].x++ + 1) * 3)) ? Encoding.ASCII.GetString(data[0].postText) : data[data[0].x + 1 < data.Length ? data[0].x + 1 : 1].text)
        {
            Console.Write(data[data[0].x].text + ((data[0].x == 2) ? $"{Encoding.ASCII.GetString(data[2].postText)}\n" : ((data[0].x) / 2.0f == 0.0f) ? Task.Run(() => { string txt2 = Encoding.ASCII.GetString(BitConverter.GetBytes(data[2].x)); for (string txt = ""; Task.Run<bool>(() => { txt += data[0].text[txt.Length]; return (txt.Length < txt2.Length / 2 + 1); }).Result;) { txt2 = txt2.Substring(0, (txt.Length - 1)) + txt2[txt2.Length - (txt.Length - 1) - 1] + txt2.Substring((txt.Length - 1) + 1, txt2.Length - 1 - (txt.Length - 1) * 2 - 1) + txt2[(txt.Length - 1)] + txt2.Substring(txt2.Length - (txt.Length - 1)); } return data[1].text + txt2; }).Result : ""));
        }
    }
}