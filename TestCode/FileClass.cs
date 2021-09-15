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
    public class FileClass
    {
        StreamReader FileRead;
        List<string> datas;
        public DataClass[] Printdata { get; set; }
        public DataClass TitleData { get; set; }

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

        public DataClass[] ReadFile(string file)
        {
            int count = 0;
            List<DataClass> listdata = new List<DataClass>();
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
                            if (strs[i] == "\"+INF\"" || strs[i] == "\"-INF\"" || strs[i] == "OF")
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
                            TitleData = new DataClass() { Number = Number, Date = Date, Time = Time, UE2 = UE2, IE2 = IE2, PE2 = PE2, SE2 = SE2, QE2 = QE2, PFE2 = PFE2, DEGE2 = DEGE2, FUE2 = FUE2, FIE2 = FIE2, UPlustpkE2 = UPlustpkE2, UMinuspkE2 = UMinuspkE2, IPluspkE2 = IPluspkE2, IMinusE2 = IMinusE2, air = "air", refrig = "refrig", tv = "tv", dry = "dry", vacuum = "vaccum" };
                            count++;
                            continue;

                        }
                       
                        switch (Choice)
                        {
                            case ChoiceBtn.AIR:
                                air = "0";
                                dry = "0";
                                refrig = "0";
                                vacuum = "0";
                                tv = "0";
                                if(double.TryParse(IE2,out double convertIE2))
                                {
                                    if(convertIE2 > 0.06)
                                    {
                                        air = "1";
                                    }
                                    else
                                    {
                                        air = "0";
                                    }
                                }
                                break;
                            case ChoiceBtn.DRY:
                                air = "0";                                
                                refrig = "0";
                                vacuum = "0";
                                tv = "0";
                                if (double.TryParse(IE2, out double conIE2))
                                {
                                    if (conIE2 > 0.1)
                                    {
                                        dry = "1";
                                    }
                                    else
                                    {
                                        dry = "0";
                                    }
                                }

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
                                if (FIE2 == "NaN")
                                {
                                    refrig = "0";
                                }
                                else
                                {
                                    refrig = "1";
                                }
                                break;
                            case ChoiceBtn.TV:
                                air = "0";
                                dry = "0";
                                refrig = "0";
                                vacuum = "0";
                                if(double.Parse(PE2)>=5)
                                {
                                    tv = "1";
                                }
                                else
                                {
                                    tv = "0";
                                }
                                break;
                            case ChoiceBtn.VACCUM:
                                air = "0";
                                dry = "0";
                                refrig = "0";
                                tv = "0";
                                //if (FIE2 == "NaN" && !double.TryParse(IE2, out double IE2double) && double.Parse(IE2) == 0)
                                //{
                                //    vacuum = "0";
                                //}
                                //else
                                //{
                                //    vacuum = "1";
                                //}
                                if (IE2 != "NaN") 
                                {
                                    if (double.Parse(IE2)>0)
                                    {
                                        vacuum = "1";
                                    }
                                    else
                                    {
                                        if (FUE2 == "NaN")
                                        {
                                            vacuum = "1";
                                        }
                                        else
                                        {
                                            vacuum = "0";
                                        }
                                    }
                                }else
                                {
                                    //if(FIE2!="NaN")
                                    //{
                                        vacuum = "1";
                                    //}else
                                    //{
                                    //    vacuum = "0";
                                    //}
                                }
                                //if ((double.Parse(IE2) > 0 || IE2 != "NaN") && FIE2 != "NaN" )
                                //{
                                //    vacuum = "1";
                                //}else
                                //{
                                //    vacuum = "0";
                                //}
                                //if (FIE2 == "NaN" || IE2 == "NaN"|| double.Parse(IE2) == 0)
                                //{
                                //    vacuum = "0";
                                //}
                                //else
                                //{
                                //    vacuum = "1";
                                //}
                                break;

                        }

                        listdata.Add(new DataClass() { Number = Number, Date = Date, Time = Time, UE2 = UE2, IE2 = IE2, PE2 = PE2, SE2 = SE2, QE2 = QE2, PFE2 = PFE2, DEGE2 = DEGE2, FUE2 = FUE2, FIE2 = FIE2, UPlustpkE2 = UPlustpkE2, UMinuspkE2 = UMinuspkE2, IPluspkE2 = IPluspkE2, IMinusE2 = IMinusE2, air = air, refrig = refrig, tv = tv, dry = dry, vacuum = vacuum });


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
