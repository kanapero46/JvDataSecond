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

    {
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

    String Kaisai;
    int Kaiji;   //回次
    int Nichiji; //日次
    String Cource; //競馬場
    String Name;   //レース名
    String Track;   //芝・ダート・障害
    int Distance;   //距離
    YEAR_CND Year;  //競走年号条件



	public Class1()
	{
	}
}
