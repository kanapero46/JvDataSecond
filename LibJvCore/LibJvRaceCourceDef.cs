using System;
using System.Collections.Generic;
using System.Text;

namespace LibJvCore
{
    //このクラスをインスタンスする際はMaaxRcを確定させる。
    public class LibJvRaceCourceDef
    {

        public LibJvCoreDef.RACE_COURSE[] RaceCource;   
        private Boolean InitJvRc = false;               //インスタンスされているかの判定

        //@Constract
        public LibJvRaceCourceDef(int MaxRCNum)
        {
            RaceCource = new LibJvCoreDef.RACE_COURSE[MaxRCNum];
        }

        /** このライブラリを利用する際の呼び出し処理　引数に１週間の開催節数を指定 */
        public int LibJvRaceCourceInit(int MaxRCcnt)
        {
            if (MaxRCcnt > 0) return (-1);  //１以上でないとエラーとする。

            RaceCource = new LibJvCoreDef.RACE_COURSE[MaxRCcnt];
            InitJvRc = true;
            return (1);
        }

        /** 競馬場名の登録：未実装 */
        public int LibJvSetRaceCource1(String RcName, int KindRc)
        {
            return (0);
        }

        /** 競馬場名の登録2 */
        public int LibJvSetRaceCource2(LibJvCoreDef.RACE_COURSE ArrayRc)
        {
            //すべてが空の場合はエラーで返す。
            if(ArrayRc.East.Equals("") && ArrayRc.West.Equals("") && ArrayRc.Local.Equals(""))
            {
                return (0);
            }

            int len = this.RaceCource.Length;
            RaceCource[len] = ArrayRc;
            return (1);
        }

        /** 競馬場名の取得(1日分) */
        public LibJvCoreDef.RACE_COURSE LibJvGetRaccCource(int ArrayNum)
        {
            return (this.RaceCource[ArrayNum]);
        }
        
        /** 競馬場名の取得（1節分） */
        public LibJvCoreDef.RACE_COURSE[] LibJvMaxGetRaccCource()
        {
            return (RaceCource);
        }
    }
}
