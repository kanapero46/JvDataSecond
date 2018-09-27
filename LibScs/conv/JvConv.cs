using System;
using System.Collections.Generic;
using System.Text;

namespace LibScs.conv
{
    class JvConv
    {
        //競馬場コード　→　競馬場名（東京・中山など短縮形）　正常動作：戻り値１
        public int JvConvJyoCdToString(String Cource, ref String RC)
        {
            switch(Cource)
            {
                case "01": RC = "札幌"; break;
                case "02": RC = "函館"; break;
                case "03": RC = "福島"; break;
                case "04": RC = "新潟"; break;
                case "05": RC = "東京"; break;
                case "06": RC = "中山"; break;
                case "07": RC = "中京"; break;
                case "08": RC = "京都"; break;
                case "09": RC = "阪神"; break;
                case "10": RC = "小倉"; break;
                case "30": RC = "門別"; break;
                case "31": RC = "北見"; break;
                case "32": RC = "岩見沢"; break;
                case "33": RC = "帯広"; break;
                case "34": RC = "旭川"; break;
                case "35": RC = "盛岡"; break;
                case "36": RC = "水沢"; break;
                case "37": RC = "上山"; break;
                case "38": RC = "三条"; break;
                case "39": RC = "足利"; break;
                case "40": RC = "宇都宮"; break;
                case "41": RC = "高崎"; break;
                case "42": RC = "浦和"; break;
                case "43": RC = "船橋"; break;
                case "44": RC = "大井"; break;
                case "45": RC = "川崎"; break;
                case "46": RC = "金沢"; break;
                case "47": RC = "笠松"; break;
                case "48": RC = "名古屋"; break;
                case "49": RC = "紀三寺"; break;
                case "50": RC = "園田"; break;
                case "51": RC = "姫路"; break;
                case "52": RC = "益田"; break;
                case "53": RC = "福山"; break;
                case "54": RC = "高知"; break;
                case "55": RC = "佐賀"; break;
                case "56": RC = "荒尾"; break;
                case "57": RC = "中津"; break;
                case "58": RC = "札幌"; break;
                case "59": RC = "函館"; break;
                case "60": RC = "新潟"; break;
                case "61": RC = "中京"; break;
                case "A0": RC = "他外国"; break;
                case "A2": RC = "日本"; break;
                case "A4": RC = "アメリ"; break;
                case "A6": RC = "イギリ"; break;
                case "A8": RC = "フラン"; break;
                case "B0": RC = "インド"; break;
                case "B2": RC = "アイル"; break;
                case "B4": RC = "ニュー"; break;
                case "B6": RC = "オース"; break;
                case "B8": RC = "カナダ"; break;
                case "C0": RC = "イタリ"; break;
                case "C2": RC = "ドイツ"; break;
                case "C5": RC = "オマー"; break;
                case "C6": RC = "イラク"; break;
                case "C7": RC = "アラブ"; break;
                case "C8": RC = "シリア"; break;
                case "D0": RC = "スウェ"; break;
                case "D2": RC = "ハンガ"; break;
                case "D4": RC = "ポルト"; break;
                case "D6": RC = "ロシア"; break;
                case "D8": RC = "ウルグ"; break;
                case "E0": RC = "ペルー"; break;
                case "E2": RC = "アルゼ"; break;
                case "E4": RC = "ブラジ"; break;
                case "E6": RC = "ベルギ"; break;
                case "E8": RC = "トルコ"; break;
                case "F0": RC = "韓国"; break;
                case "F1": RC = "中国"; break;
                case "F2": RC = "チリ"; break;
                case "F4": RC = ""; break;
                case "F6": RC = ""; break;
                case "F8": RC = "パナマ"; break;
                case "G0": RC = "香港"; break;
                case "G2": RC = "スペイ"; break;
                case "G4": RC = ""; break;
                case "G6": RC = ""; break;
                case "G8": RC = ""; break;
                case "H0": RC = "西独"; break;
                case "H2": RC = "南アフ"; break;
                case "H4": RC = "スイス"; break;
                case "H6": RC = "モナコ"; break;
                case "H8": RC = "フィリ"; break;
                case "I0": RC = "プエル"; break;
                case "I2": RC = "コロン"; break;
                case "I4": RC = "チェコ"; break;
                case "I6": RC = "チェコ"; break;
                case "I8": RC = "スロバ"; break;
                case "J0": RC = "エクア"; break;
                case "J2": RC = "ギリシ"; break;
                case "J4": RC = "マレー"; break;
                case "J6": RC = "メキシ"; break;
                case "J8": RC = "モロッ"; break;
                case "K0": RC = "パキス"; break;
                case "K2": RC = "ポーラ"; break;
                case "K4": RC = "パラグ"; break;
                case "K6": RC = "サウジ"; break;
                case "K8": RC = "キプロ"; break;
                case "L0": RC = "タイ"; break;
                case "L2": RC = "ウクラ"; break;
                case "L4": RC = "ベネゼ"; break;
                case "L6": RC = "ユーゴ"; break;
                case "L8": RC = "デンマ"; break;
                case "M0": RC = "シンガ"; break;
                case "M2": RC = "マカオ"; break;
                case "M4": RC = "墺国"; break;
                case "M6": RC = "ヨルダ"; break;
                case "M8": RC = "カタル"; break;
                default:    RC = ""; return 0;  //定義されていない競馬場を指定した場合はエラーで返す。
            }
            return 1;
        }




    }
}
