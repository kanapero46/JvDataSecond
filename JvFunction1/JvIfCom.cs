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
    public partial class JvIfCom : Form
    {
        public JvIfCom()
        {
            InitializeComponent();
        }

        private void JvIfCom_Load(object sender, EventArgs e)
        {

        }

        /****************************** *
         * DataLabとの通信インタフェース  *
         * *****************************/

        //呼び出し順①：Jv-Linkの初期化
        public int IfJvInit(String sid){ return (JvIfCom1.JVInit(sid));}

        //呼び出し順2-1：蓄積系のデータ取得
        public int IfJvOpen(String datespec, String fromtime, int option, ref int readcount, ref int downloadcount, out String timestamp) {
            return (JvIfCom1.JVOpen(datespec, fromtime, option, ref readcount, ref downloadcount, out timestamp)); 
        }

        //呼び出し順3-1：Jv-Dataの読み込み
        public int IfJvRead(out String buff, out int size, out String filename)
        {
            int ret = JvIfCom1.JVRead(out buff, out size, out filename);

            if (ret != 0) JvIfCom1.JVFiledelete(filename); //JvReadに失敗した場合はファイルを消す。

            return (ret);
        }

        //Jv-Dataの読み込みスキップ
        public void IfJvSkip() { JvIfCom1.JVSkip(); }

        //Jv-LinkのClose処理：正しい場合は戻り値0が戻るが、呼び出し元には返さない。
        public void IfJvClose() { JvIfCom1.JVClose(); }









    }
}
