﻿using System;

public class JvKaisaiCore
{
    struct KAISAI_RC {
        public Boolean Set;
        public String Cource1;
        public String Cource2;
        public String Cource3;
    };

    KAISAI_RC FirstKaisai;
    KAISAI_RC SecondKaisai;
    KAISAI_RC[] KaisaiRc = new KAISAI_RC[2];

    /** ******************************* 
    * 開催競馬場データのセッター
    **********************************/
    public void setCourceFirst(String Cource)
    {
        //登録済みデータとの比較
        try { if (Cource.Equals(FirstKaisai.Cource1)) return; }catch(NullReferenceException e) { FirstKaisai.Set = true; FirstKaisai.Cource1 = Corce; }
        try { if (Cource.Equals(FirstKaisai.Cource2)) return; }catch(NullReferenceException e) { FirstKaisai.Set = true; FirstKaisai.Cource2 = Corce; }
        try { if (Cource.Equals(FirstKaisai.Cource3)) return; }catch(NullReferenceException e) { FirstKaisai.Set = true; FirstKaisai.Cource3 = Corce; }
    }

    /** ******************************* 
    * 開催競馬場データのゲッター(1場ごと・競馬場コード順（札幌→東京→小倉）)
    * **********************************/
    public String getCourceOneCource(int CourceKind)
    {
        switch (CourceKind)
        {
            case 1:
                return FirstKaisai.Cource1;
            case 2:
                return FirstKaisai.Cource2;
            case 3:
                return FirstKaisai.Cource3;
            default:
                return "";
        }
    }

    /** ******************************* 
    * 開催競馬場データのゲッター(1日ごと競馬場コード順（札幌→東京→小倉）)
    * @return 取得できた開催競馬場数
    * **********************************/
    public int getKaisaiOneDay(ref KAISAI_RC pOut)
    {
        if (FirstKaisai.Set == false) return 0;
        pOut = FirstKaisai;

        int res = ((FirstKaisai.Cource1.Length) >= 1 ? 1 : 0)
                 + ((FirstKaisai.Cource2.Length) >= 1 ? 1 : 0)
                 + ((FirstKaisai.Cource3.Length) >= 1 ? 1 : 0);

        return (res);

    }
}
