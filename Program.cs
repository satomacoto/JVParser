using Newtonsoft.Json;
using static JVData_Struct;

namespace JVParser;

class Program
{
    static void Main(string[] args)
    {
        // To use Shift-JIS encoding, use the following:
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

        // read line and convert to json
        string? line;
        while ((line = Console.ReadLine()) != null)
        {
            var jsonString = JVReadToJson(line);
            Console.WriteLine(jsonString);
        }

    }

    static string JVReadToJson(string line)
    {
        var av = new JV_AV_INFO();
        var bn = new JV_BN_BANUSI();
        var br = new JV_BR_BREEDER();
        var bt = new JV_BT_KEITO();
        var cc = new JV_CC_INFO();
        var ch = new JV_CH_CHOKYOSI();
        var ck = new JV_CK_CHAKU();
        var cs = new JV_CS_COURSE();
        var dm = new JV_DM_INFO();
        var h1 = new JV_H1_HYOSU_ZENKAKE();
        var h6 = new JV_H6_HYOSU_SANRENTAN();
        var hc = new JV_HC_HANRO();
        var hn = new JV_HN_HANSYOKU();
        var hr = new JV_HR_PAY();
        var hs = new JV_HS_SALE();
        var hy = new JV_HY_BAMEIORIGIN();
        var jc = new JV_JC_INFO();
        var jg = new JV_JG_JOGAIBA();
        var o1 = new JV_O1_ODDS_TANFUKUWAKU();
        var o2 = new JV_O2_ODDS_UMAREN();
        var o3 = new JV_O3_ODDS_WIDE();
        var o4 = new JV_O4_ODDS_UMATAN();
        var o5 = new JV_O5_ODDS_SANREN();
        var o6 = new JV_O6_ODDS_SANRENTAN();
        var ra = new JV_RA_RACE();
        var rc = new JV_RC_RECORD();
        var se = new JV_SE_RACE_UMA();
        var sk = new JV_SK_SANKU();
        var tc = new JV_TC_INFO();
        var tk = new JV_TK_TOKUUMA();
        var tm = new JV_TM_INFO();
        var um = new JV_UM_UMA();
        var wc = new JV_WC_WOODCHIP();
        var we = new JV_WE_WEATHER();
        var wf = new JV_WF_INFO();
        var wh = new JV_WH_BATAIJYU();
        var ys = new JV_YS_SCHEDULE();


        var jsonString = "";


        var dataKubun = line.Substring(0, 2);
        switch (dataKubun)
        {
            case "AV":
                av.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(av);
                break;
            case "BN":
                bn.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(bn);
                break;
            case "BR":
                br.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(br);
                break;
            case "BT":
                bt.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(bt);
                break;
            case "CC":
                cc.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(cc);
                break;
            case "CH":
                ch.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(ch);
                break;
            case "CK":
                ck.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(ck);
                break;
            case "CS":
                cs.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(cs);
                break;
            case "DM":
                dm.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(dm);
                break;
            case "H1":
                h1.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(h1);
                break;
            case "H6":
                h6.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(h6);
                break;
            case "HC":
                hc.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(hc);
                break;
            case "HN":
                hn.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(hn);
                break;
            case "HR":
                hr.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(hr);
                break;
            case "HS":
                hs.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(hs);
                break;
            case "HY":
                hy.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(hy);
                break;
            case "JC":
                jc.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(jc);
                break;
            case "JG":
                jg.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(jg);
                break;
            case "O1":
                o1.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(o1);
                break;
            case "O2":
                o2.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(o2);
                break;
            case "O3":
                o3.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(o3);
                break;
            case "O4":
                o4.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(o4);
                break;
            case "O5":
                o5.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(o5);
                break;
            case "O6":
                o6.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(o6);
                break;
            case "RA":
                ra.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(ra);
                break;
            case "RC":
                rc.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(rc);
                break;
            case "SE":
                se.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(se);
                break;
            case "SK":
                sk.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(sk);
                break;
            case "TC":
                tc.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(tc);
                break;
            case "TK":
                tk.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(tk);
                break;
            case "TM":
                tm.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(tm);
                break;
            case "UM":
                um.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(um);
                break;
            case "WC":
                wc.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(wc);
                break;
            case "WE":
                we.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(we);
                break;
            case "WF":
                wf.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(wf);
                break;
            case "WH":
                wh.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(wh);
                break;
            case "YS":
                ys.SetDataB(ref line);
                jsonString = JsonConvert.SerializeObject(ys);
                break;
            default:
                // 読み飛ばし
                break;
        }
        return jsonString;
    }
}