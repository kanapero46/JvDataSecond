using System;

public class JvKaisaiCore
{
    struct ArrayCource {
        public String Cource1;
        public String Cource2;
        public String Cource3;
    };

    ArrayCource FirstKaisai;
    ArrayCource SecondKaisai;

    public void setCource(String Cource)
    {
        //登録済みデータとの比較
        if (Cource.Equals(FirstKaisai.Cource1)) return;
        if (Cource.Equals(FirstKaisai.Cource2)) return;
        if (Cource.Equals(FirstKaisai.Cource3)) return;

    }

	
}
