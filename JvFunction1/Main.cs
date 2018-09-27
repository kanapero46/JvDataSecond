using AxJVDTLabLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibScs;

namespace JvFunction
{

    struct CONNER
    {
        public int conner1;
        public int conner2;
        public int conner3;
        public int conner4;
    }
    struct KaisaiInfoStructures
    {
        public int idx;             //Dummyのインデックス
        public int[] index;         //配列インデックス
        public String[] Jomei;      //場名
        public int[] DayRaceMaxCounter; //各場の１日レース最大数
        public int MaxRaceCounter;  //レース最大数
    }

    struct JvDataStructures
    {
        public String Date;            /* 日付 */
        public int Kai;             /* 回 */
        public int Nichi;           /* 日目 */
        public String RaceCourse;      /* 場名 */
        public int RaceNumber;         /* レース番号 */
        public String RaceName;        /* レース名 */
        public String TD;          /* 芝・ダート */
        public int Distance;           /* 距離(mつけない) */
    }

    struct JvRaceDataBasicStructures
    {
        public int Waku;            /* 枠番 RACE */
        public int Umaban;          /* 馬番 RACE*/
        public String Bamei;        /* 馬名 Race */
        public String Jokkey;       /* 騎手 RACE */
        public Double Omosa;        /* 斤量 RACE */
    }

    struct BloodData
    {
        public String fHorse;       /* 父 MASTER */
        public String mHours;       /* 母 MASTER */
        public String BMS;          /* 母父 MASTER */
        public String BMS1;         /* 母母父 MASTER */
    }

    struct JvRaceDataStructures     /* レース情報基本データ構造体 */
    {
        public JvRaceDataBasicStructures id;    /* 基本情報 */
        public BloodData Blood;     /* 血統情報 */
        public String Kyakushitu;   /* 脚質 RACE */
        public String sex;          /* 性別 RACE */
        public int Year;            /* 年齢 RACE */
    }

    struct JvRaceDataMasterStructures   /* レース情報過去データ構造体 */
    {
        public int ID;                /* レース情報ヘッダ */
        public JvRaceDataBasicStructures Common;    /* レース情報共通情報(馬名など) */
        public BloodData Blood;
        public String BabaJotai;     /* 馬場状態 */
        public String Rank;          /* 着順 （取消などが入るためString型で保持 */
        public String Time;          /* 走破タイム */
        public int SyusouTosu;       /* 頭数 */
        public String Bataiju;          /* 馬体重 */
        public String Zougen;        /* 馬体重増減 */
        public String BataijuDiff;      /* 増減差 */
        public CONNER Conner;        /* コーナー順位 */
        public String final3F;       /* 上がり3F */
        public String AiteUma;       /* 相手馬 */
        public String DiffTime;      /* タイム差 */
    }

    //JVとのやり取りやデータはこの関数で保持。
    //他のクラスやフォームはデータのゲットをする設計を考える。
    //エラーコードチェックは呼び出し元で行うこと。
    class Main
    {
        //インスタンス宣言
        JvIfCom JvCom = new JvIfCom();


        //グローバル配列定義
        String[] NameRc = new string[3];

        //Form1：開催競馬場データの取得
        public Boolean JvComMain(String date)
        {
            int ret = 0;
            Boolean JvEndFlag = true;

            ret = JvCom.IfJvInit("UNKNOWN");
            if (ret != 0) return (false);

            String datespec = "RACE"; date = "20180920000000";
            int opKind = 2; int ReadCount = 0; int DownloadCount = 0;
            String LastTime;

            ret = JvCom.IfJvOpen(datespec, date, opKind, ref ReadCount, ref DownloadCount, out LastTime);
            if (ret != 0) return (false);

            String Buffer, filename, RaceCource = "";
            int size = 20000;

            do
            {
                ret = JvCom.IfJvRead(out Buffer, out size, out filename);
                if (ret < -3) return (false);

                if (ret == -1 || Buffer == null)
                {
                    JvEndFlag = false;
                    break;
                }

                String RecordSpec = Buffer.Substring(0, 2);
                libScs.LibScsMain(RecordSpec, ref Buffer, ref RaceCource);

            } while (JvEndFlag);





            JvCom.IfJvClose();
            return (true);
        }

    }
}
