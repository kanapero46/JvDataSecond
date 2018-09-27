using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JvFunction
{
    public partial class Form1 : Form
    {
        /**
         * グローバル変数
         * */
        Boolean statusData = false;

        //インスタンス宣言
        Main main = new Main();     //メインクラスのオブジェクト宣言


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String date = dateTimePicker1.Value.ToString("yyyyMMdd") + "000000";
            statusBar1.Text = "開催情報取得中(DataLab.接続中...)";

            /* インプットデータから */
            statusData = main.JvComMain(date);

            //ボタンの有効化
            for (int idx = 0; idx <= 2; idx++)
            {
                //EnableButtonFunction(main.getJomei(idx));
            }

            /* ステータスバーの文字修正 */
            if (statusData == true)
            {
                statusBar1.Text = "競馬場名をクリックすると、開催情報を取得することが出来ます。";
            }
            else
            {
                statusBar1.Text = "開催情報の取得に失敗しました。";
            }

            axJVLink1.JVClose();
        }


        //メイン画像のボタン有効化
        private void EnableButtonFunction(String Location)
        {
            switch (Location)
            {
                case "札幌":
                    sapporo.Enabled = true;
                    break;
                case "函館":
                    hakodate.Enabled = true;
                    break;
                case "福島":
                    fukushima.Enabled = true;
                    break;
                case "新潟":
                    niigata.Enabled = true;
                    break;
                case "東京":
                    tokyo.Enabled = true;
                    break;
                case "中山":
                    nakayama.Enabled = true;
                    break;
                case "中京":
                    chukyo.Enabled = true;
                    break;
                case "京都":
                    kyoto.Enabled = true;
                    break;
                case "阪神":
                    hanshin.Enabled = true;
                    break;
                case "小倉":
                    kokura.Enabled = true;
                    break;
            }
        }

        //JvLink設定ボタンの動作
        private void button2_Click(object sender, EventArgs e)
        {
            axJVLink1.JVSetUIProperties();
        }

        private void axJVLink2_JVEvtPay(object sender, AxJVDTLabLib._IJVLinkEvents_JVEvtPayEvent e)
        {

        }
    }
}
