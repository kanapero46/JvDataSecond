using System;

public class JvKaisaiCore
{
    public struct KAISAI_RC
    {
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
        if (Cource.Equals(FirstKaisai.Cource1)) { return; } else if (FirstKaisai.Cource1 == null) { FirstKaisai.Set = true; FirstKaisai.Cource1 = Cource; return; }
        if (Cource.Equals(FirstKaisai.Cource2)) { return; } else if (FirstKaisai.Cource2 == null) { FirstKaisai.Set = true; FirstKaisai.Cource2 = Cource; return; }
        if (Cource.Equals(FirstKaisai.Cource3)) { return; } else if (FirstKaisai.Cource3 == null) { FirstKaisai.Set = true; FirstKaisai.Cource3 = Cource; return;}
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
        int res = 0;

        try { res += ((FirstKaisai.Cource1.Length) >= 1 ? 1 : 0); } catch(NullReferenceException e) { return (res); }
        try { res += ((FirstKaisai.Cource2.Length) >= 1 ? 1 : 0); } catch (NullReferenceException e) { return (res); }
        try { res += ((FirstKaisai.Cource3.Length) >= 1 ? 1 : 0); } catch (NullReferenceException e) { return (res); }
        return (res);
    }
}
