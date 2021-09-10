using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace TestCode
{
    public enum ChoiceBtn
    {
        AIR,REFRIG,TV,DRY,VACCUM
    }
    public class Data
    {
        public string Number { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string UE2 { get; set; }
        public string IE2 { get; set; }
        public string PE2 { get; set; }
        public string SE2 { get; set; }
        public string QE2 { get; set; }
        public string PFE2 { get; set; }
        public string DEGE2 { get; set; }
        public string FUE2 { get; set; }
        public string FIE2 { get; set; }
        public string UPlustpkE2 { get; set; }
        public string UMinuspkE2 { get; set; }
        public string IPluspkE2 { get; set; }
        public string IMinusE2 { get; set; }
        public string air { get; set; }
        public string refrig { get; set; }
        public string tv { get; set; }
        public string dry { get; set; }
        public string vacuum { get; set; }
        public string print()
        {
            return Number + "\t" + Date + "\t" + Time + "\t" + UE2 + "\t" + IE2 + "\t" + PE2 + "\t" + SE2 + "\t" + QE2 + "\t" + PFE2 + "\t" + DEGE2 + "\t" + FUE2 + "\t" + FIE2 + "\t" + UPlustpkE2 + "\t" + UMinuspkE2 + "\t" + UMinuspkE2 + "\t" + UMinuspkE2;
        }
    }
    public class FileClass
    {
        StreamReader FileRead;
        List<string> datas;
        public Data[] Printdata { get; set; }
        public Data TitleData { get; set; }

        public string Number { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string UE2 { get; set; }
        public string IE2 { get; set; }
        public string PE2 { get; set; }
        public string SE2 { get; set; }
        public string QE2 { get; set; }
        public string PFE2 { get; set; }
        public string DEGE2 { get; set; }
        public string FUE2 { get; set; }
        public string FIE2 { get; set; }
        public string UPlustpkE2 { get; set; }
        public string UMinuspkE2 { get; set; }
        public string IPluspkE2 { get; set; }
        public string IMinusE2 { get; set; }
        public string air { get; set; }
        public string refrig { get; set; }
        public string tv { get; set; }
        public string dry { get; set; }
        public string vacuum { get; set; }
        public ChoiceBtn Choice { get; set; }

        public Data[] ReadFile(string file)
        {
            int count = 0;
            List<Data> listdata = new List<Data>();
            datas = new List<string>();
            using (FileRead = new StreamReader(file, Encoding.Default))
            {
                string readdata;
                int readcount = 0;
                while (true)
                {
                    readdata = FileRead.ReadLine();
                    if (readcount < 78)
                    {

                        datas.Add(readdata);
                        readcount++;
                    }
                    else
                    {


                        if (String.IsNullOrWhiteSpace(readdata))
                        {
                            break;
                        }
                        var strs = readdata.Split(',');

                        for(int i=0;i<=15;i++)
                        {
                            if (strs[i] == "\"+INF\"" || strs[i] == "\"-INF\"" || strs[i] == "\"OF\"")
                            {
                                strs[i] = "NaN";
                            }
                                
                        }
                        Number = strs[0];
                        Date = strs[1];
                        Time = strs[2];
                        UE2 = strs[3];
                        IE2 = strs[4];
                        PE2 = strs[5];
                        SE2 = strs[6];
                        QE2 = strs[7];
                        PFE2 = strs[8];
                        DEGE2 = strs[9];
                        FUE2 = strs[10];
                        FIE2 = strs[11];
                        UPlustpkE2 = strs[12];
                        UMinuspkE2 = strs[13];
                        IPluspkE2 = strs[14];
                        IMinusE2 = strs[15];


                        if (count == 0)
                        {
                            //첫줄이 아닌데 데이터 값이 double이 아닐 경우 오류 발생
                            if (listdata.Count != 0)
                                throw new Exception("데이터 이상");

                            // OutputRecord의 시간과 PV제목 지정
                            TitleData = new Data() { Number = Number, Date = Date, Time = Time, UE2 = UE2, IE2 = IE2, PE2 = PE2, SE2 = SE2, QE2 = QE2, PFE2 = PFE2, DEGE2 = DEGE2, FUE2 = FUE2, FIE2 = FIE2, UPlustpkE2 = UPlustpkE2, UMinuspkE2 = UMinuspkE2, IPluspkE2 = IPluspkE2, IMinusE2 = IMinusE2, air = "air", refrig = "refrig", tv = "tv", dry = "dry", vacuum = "vaccum" };
                            count++;
                            continue;

                        }
                        //if (double.TryParse(Number, out double number) == false)
                        //{
                        //    if (Number == "=+inf" || Number == "=-inf" || Number == "of")
                        //    {
                        //        Number = "NaN";
                        //    }

                        //}
                        //if (DateTime.TryParse(Date, out DateTime date) == false)
                        //{
                        //    if (Date == "=+inf" || Date == "=-inf" || Date == "of")
                        //    {
                        //        Date = "NaN";
                        //    }
                        //}
                        //if (DateTime.TryParse(Time, out DateTime time) == false)
                        //{
                        //    if (Time == "=+inf" || Time == "=-inf" || Time == "of")
                        //    {
                        //        Time = "NaN";
                        //    }
                        //}
                        //if (double.TryParse(UE2, out double ue2) == false)
                        //{
                        //    if (UE2 == "=+inf" || UE2 == "=-inf" || UE2 == "of")
                        //    {
                        //        UE2 = "NaN";
                        //    }
                        //}
                        //if (double.TryParse(IE2, out double ie2) == false)
                        //{
                        //    if (IE2 == "=+inf" || IE2 == "=-inf" || IE2 == "of")
                        //    {
                        //        IE2 = "NaN";
                        //    }
                        //}
                        //if (double.TryParse(PE2, out double pe2) == false)
                        //{
                        //    if (PE2 == "=+inf" || PE2 == "=-inf" || PE2 == "of")
                        //    {
                        //        PE2 = "NaN";
                        //    }

                        //}
                        //if (double.TryParse(SE2, out double se2) == false)
                        //{
                        //    if (SE2 == "=+inf" || SE2 == "=-inf" || SE2 == "of")
                        //    {
                        //        SE2 = "NaN";
                        //    }
                        //}
                        //if (double.TryParse(QE2, out double qe2) == false)
                        //{
                        //    if (QE2 == "=+inf" || QE2 == "=-inf" || QE2 == "of")
                        //    {
                        //        QE2 = "NaN";
                        //    }
                        //}

                        //if (double.TryParse(PFE2, out double pfe2) == false)
                        //{

                        //    if (PFE2 == "\"+INF\"" || PFE2 == "\"-INF\"" || PFE2 == "\"of\"")
                        //    {
                        //        PFE2 = "NaN";
                        //    }
                        //}
                        //if (double.TryParse(DEGE2, out double dege2) == false)
                        //{
                        //    if (DEGE2 == "\"+INF\"" || DEGE2 == "\"-INF\"" || DEGE2 == "\"of\"")
                        //    {
                        //        DEGE2 = "NaN";
                        //    }
                        //}
                        //if (double.TryParse(UMinuspkE2, out double uminuspke2) == false)
                        //{
                        //    if (UMinuspkE2 == "\"+INF\"" || UMinuspkE2 == "\"-INF\"" || UMinuspkE2 == "\"of\"")
                        //    {
                        //        UMinuspkE2 = "NaN";
                        //    }
                        //}
                        //if (double.TryParse(IMinusE2, out double iminuse2) == false)
                        //{
                        //    if (IMinusE2 == "\"+INF\"" || IMinusE2 == "\"-INF\"" || IMinusE2 == "\"of\"")
                        //    {
                        //        IMinusE2 = "NaN";
                        //    }

                        //}
                        //if (double.TryParse(FUE2, out double fue2) == false)
                        //{
                        //    if (FUE2 == "\"+INF\"" || FUE2 == "\"-INF\"" || FUE2 == "\"of\"")
                        //    {
                        //        FUE2 = "NaN";
                        //    }
                        //}
                        //if (double.TryParse(UPlustpkE2, out double upluspke2) == false)
                        //{
                        //    if (UPlustpkE2 == "\"+INF\"" || UPlustpkE2 == "\"-INF\"" || UPlustpkE2 == "\"of\"")
                        //    {
                        //        UPlustpkE2 = "NaN";
                        //    }
                        //}
                        //if (double.TryParse(IPluspkE2, out double ipluspke2) == false)
                        //{
                        //    if (IPluspkE2 == "\"+INF\"" || IPluspkE2 == "\"-INF\"" || IPluspkE2 == "\"of\"")
                        //    {
                        //        IPluspkE2 = "NaN";
                        //    }
                        //}

                        //if (double.TryParse(FIE2, out double fie2) == false)
                        //{
                        //    if (FIE2 == "\"+INF\"" || FIE2 == "\"-INF\"" || FIE2 == "\"of\"")
                        //    {
                        //        FIE2 = "NaN";
                        //    }
                        //}
                        switch (Choice)
                        {
                            case ChoiceBtn.AIR:
                                air = "0";
                                dry = "0";
                                refrig = "0";
                                vacuum = "0";
                                tv = "0";
                                break;
                            case ChoiceBtn.DRY:
                                air = "0";                                
                                refrig = "0";
                                vacuum = "0";
                                tv = "0";
                                break;
                            case ChoiceBtn.REFRIG:
                                air = "0";
                                dry = "0";
                                tv = "0";
                                vacuum = "0";
                                //if (DEGE2 == "NaN")
                                //    refrig = "0";
                                //else
                                //    refrig = "1";
                                if (double.TryParse(IE2, out double i) == true)
                                {
                                    if (i > 0.1)
                                    {
                                        refrig = "1";
                                    }
                                    else
                                    {
                                        refrig = "0";
                                    }
                                }
                                break;
                            case ChoiceBtn.TV:
                                air = "0";
                                dry = "0";
                                refrig = "0";
                                vacuum = "0";
                                if (double.TryParse(IE2, out double a) == true)
                                {
                                    if (a > 0.1)
                                    {
                                        tv = "1";
                                    }
                                    else
                                    {
                                        tv = "0";
                                    }
                                }
                                break;
                            case ChoiceBtn.VACCUM:
                                air = "0";
                                dry = "0";
                                refrig = "0";
                                tv = "0";
                                break;

                        }

                        listdata.Add(new Data() { Number = Number, Date = Date, Time = Time, UE2 = UE2, IE2 = IE2, PE2 = PE2, SE2 = SE2, QE2 = QE2, PFE2 = PFE2, DEGE2 = DEGE2, FUE2 = FUE2, FIE2 = FIE2, UPlustpkE2 = UPlustpkE2, UMinuspkE2 = UMinuspkE2, IPluspkE2 = IPluspkE2, IMinusE2 = IMinusE2, air = air, refrig = refrig, tv = tv, dry = dry, vacuum = vacuum });


                        Printdata = listdata.ToArray();
                    }
                }
                return Printdata;
            }          
        }
        public void Export(string filepath)
        {
            using (var sw = new StreamWriter(filepath, false, Encoding.Default))
            {
            
                //타이틀 출력
                sw.WriteLine($"{TitleData.Number},{ TitleData.Date},{ TitleData.Time},{ TitleData.UE2},{ TitleData.IE2},{ TitleData.PE2},{ TitleData.SE2},{ TitleData.QE2},{ TitleData.PFE2},{ TitleData.DEGE2},{ TitleData.FUE2 },{ TitleData.FIE2 },{ TitleData.UPlustpkE2 },{ TitleData.UMinuspkE2 },{ TitleData.IPluspkE2 },{ TitleData.IMinusE2 },{ TitleData.air},{ TitleData.refrig},{ TitleData.tv },{ TitleData.dry },{ TitleData.vacuum}");
                //데이터 출력
                foreach (var record in Printdata)
                {
                    sw.WriteLine($"{record.Number},{record.Date},{record.Time},{record.UE2},{record.IE2},{record.PE2},{record.SE2},{record.QE2},{record.PFE2},{record.DEGE2},{record.FUE2 },{record.FIE2},{record.UPlustpkE2},{record.UMinuspkE2},{record.IPluspkE2},{record.IMinusE2},{record.air},{record.refrig},{record.tv},{record.dry},{record.vacuum}");
                }
            }
        }
        public void InfoExport(string filepath)
        {
            using (var sw = new StreamWriter(filepath, false, Encoding.Default))
            {

                //데이터 출력
                foreach (var record in datas)
                {
                    sw.WriteLine(record);
                }
            }
        }
    }
}
