using System;

public class JvRaceData
{
    enum YEAR_CND
    {
        OTHER,
        TWO_YEAR_ONLY,
        THREE_YEAR_ONLY,
        THREE_OVER_YEAR,
        FOUR_OVER_YEAR,
        STEEPLE_CHASE_THREE_OVER,
        STEEPLE_CHASE_FOUR_OVER,
    };//アラブ系は定義していない。

    enum GRADE
    {
        G1,
        G2,
        G3,
        Jpn1,
        Jpn2,
        Jpn3,
        JG1,
        JG2,
        JG3,
        GRADE,      //新設重賞・重賞
        TOKUBETU,   //重賞以外の特別競走
        OTHER,      //一般競走
    }

    struct RACECMD
    {
        public int Garde;
        public String Class;
        public String NPname; //競馬新聞表記
    }

    RACECMD ClassTable ={ 
        { GRADE.G1 , "A" , "ＧⅠ" },
        { GRADE.G2 , "B" , "ＧⅡ" },
        { GRADE.G3 , "C" , "ＧⅢ" },
        { GRADE.GRADE , "D" , "重賞" },
        { GRADE.TOKUBETU , "E" , "特別" },
        { GRADE.JG1 , "F" , "Ｊ・ＧⅠ" },
        { GRADE.JG2 , "G" , "Ｊ・ＧⅡ" },
        { GRADE.JG3 , "H" , "Ｊ・ＧⅢ" },  
        { GRADE.OTHER , " " , "" },
    };


    enum RACE_CMD
    {
        OTHER,
        LESS_500,
        LESS_1000,
        LESS_1600,
        MAKE_DEBUT,
        UN_RACED,       //未出走
        MAIDEN,         //未勝利
        OPEN,
    };

    String Kaisai;
    String Date;    //日付
    int Kaiji;   //回次
    int Nichiji; //日次
    String Cource; //競馬場
    String Name;   //レース名
    String Track;   //芝・ダート・障害
    int Distance;   //距離
    int Year;  //競走年号条件
    String Grade;  //グレード
    String SignCode;   //競走記号コード　左から 産地・性別コード・交流競走コード




	public Class1()
	{

	}
}
