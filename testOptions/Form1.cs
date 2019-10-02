using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CommandLine;

namespace testOptions
{
    public partial class Form1 : Form
    {
        private Options opt = null;

        public Form1()
        {
            InitializeComponent();

            string[] args = System.Environment.GetCommandLineArgs();

            // ジェネリクスでオプションクラスを指定し、パースする
            var parseResult = Parser.Default.ParseArguments<Options>(args);

            // 結果はTagに入っている
            switch (parseResult.Tag)
            {
                // パース成功
                case ParserResultType.Parsed:
                    // パースの成否でパース結果のオブジェクトの方が変わる
                    var parsed = parseResult as Parsed<Options>;

                    // 成功時はキャストしたオブジェクトからパース結果が取得可能
                    opt = parsed.Value;

                    Console.WriteLine($"opt.code = {opt.code}");
                    Console.WriteLine($"opt.start_auto = {opt.start_auto}");
                    Console.WriteLine($"opt.connect = {opt.connect_server}");

                    break;
                // パース失敗
                case ParserResultType.NotParsed:
                    // パースの成否でパース結果のオブジェクトの方が変わる
                    var notParsed = parseResult as NotParsed<Options>;

                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Commands = System.Environment.GetCommandLineArgs();

            for (int i = 0; i < Commands.Length; i++)
            {
                textBox1.Text += string.Format("command : {0:d} : {1}\r\n", i, Commands[i]);
            }


        }
    }
}
