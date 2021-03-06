﻿using System;

namespace LibScs
{
    public class libScs
    {

        libScsDef ThisDef = new libScsDef();
       
        

        public static int LibScsMain(String spec, ref String Buff, ref String Cource)
        {
            switch(spec)
            {
                case "YS":
                    JVData_Struct.JV_YS_SCHEDULE JvSche = new JVData_Struct.JV_YS_SCHEDULE();
                    conv.JvConv JvConv = new conv.JvConv();

                    String res = "";
                    JvSche.SetDataB(ref Buff);
                    if (JvConv.JvConvJyoCdToString(JvSche.id.JyoCD, ref res) == 0) return 0; //競馬場コードが不明のときはエラー
                    Cource = res;
                    return 1;

                case "RA":
                    JVData_Struct.JV_RA_RACE JvRace = new JVData_Struct.JV_RA_RACE();
                    conv.JvConv JvConv1 = new conv.JvConv();
                    JvRace.SetDataB(ref Buff);
                    String resRA = "";
                    if (JvConv1.JvConvJyoCdToString(JvRace.id.JyoCD, ref resRA) == 0) return 0; //競馬場コードが不明のときはエラー
                    Cource = resRA;
                    return 1;

            }
            return 1;
        }

        //デバッグ文出力ライブラリ
        public static void LibConsoaleDebugLog(ref String Message)
        {
            if (!libScsDef.DEBUG()) return; //デバッグ無効時はログ出力をしない。
            
            Console.WriteLine(Message);
        }

    }
}
