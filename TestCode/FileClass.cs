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


        AIR ,
        AirRefrig, AirTv, AirDry, AirVaccum,
        AirRefrigTv,AirRefrigDry,AirRefrigVaccum, AirTVDry, AirTvVaccuum, AirTVRefrig, AirDryVacuum, AirDryTV, AirDryRefrig,
        AirRefrigTvDry,AirRefrigTvVaccum, AirRefrigDryTV, AirRefrigDryVacuum, AirRefrigVacuumTV,AirRefrigVacuumDry, 
        AirTVRefrigDry,AirTVRefrigVacuum,AirTVDryVacuum,AirTVDryRefrig,AirTVVacuumRefrig,AirTVVacuumDry,
        AirDryRefrigTV,AirDryRefrigVacuum,AirDryTVRefrig,AirDryTVVacuum,AirDryVaccumTV,AirDryVacuumRefrig,
        AirVacuumRefrigTV,AirVacuumRefrigDry,AirVacuumTVDry, AirVacuumTVRefrig, AirVacuumDryRefrig, AirVacuumDryTV,


        REFRIG,
        RefrigAir, RefrigTv, RefrigDry, RefrigVaccum,
        RefrigAirTv, RefrigAirDry, RefrigAirVaccum, RefrigTVDry, RefrigTvVaccuum, RefrigTVAir, RefrigDryVacuum, RefrigDryTV, RefrigDryAir,
        RefrigAirTvDry, RefrigAirTvVaccum, RefrigAirDryTV, RefrigAirDryVacuum, RefrigAirVacuumTV, RefrigAirVacuumDry,
        RefrigTVAirDry, RefrigTVAirVacuum, RefrigTVDryVacuum, RefrigTVDryAir, RefrigTVVacuumAir, RefrigTVVacuumDry,
        RefrigDryAirTV, RefrigDryAirVacuum, RefrigDryTVAir, RefrigDryTVVacuum, RefrigDryVaccumTV, RefrigDryVacuumAir,
        RefrigVacuumAirTV, RefrigVacuumAirDry, RefrigVacuumTVDry, RefrigVacuumTVAir, RefrigVacuumDryAir, RefrigVacuumDryTV,


        TV,
        TVAir, TVRefrig, TVDry, TVVaccum,
        TVAirRefrig, TVAirDry, TVAirVaccum, TVRefrigDry, TVRefrigVaccuum, TVRefrigAir, TVDryVacuum, TVDryRefrig, TVDryAir,
        TVAirRefrigDry, TVAirRefrigVaccum, TVAirDryRefrig, TVAirDryVacuum, TVAirVacuumRefrig, TVAirVacuumDry,
        TVRefrigAirDry, TVRefrigAirVacuum, TVRefrigDryVacuum, TVRefrigDryAir, TVRefrigVacuumAir, TVRefrigVacuumDry,
        TVDryAirRefrig, TVDryAirVacuum, TVDryRefrigAir, TVDryRefrigVacuum, TVDryVaccumRefrig, TVDryVacuumAir,
        TVVacuumAirRefrig, TVVacuumAirDry, TVVacuumRefrigDry, TVVacuumRefrigAir, TVVacuumDryAir, TVVacuumDryRefrig,

        DRY,
        DryAir, DryRefrig, DryTV, DryVaccum,
        DryAirRefrig, DryAirTV, DryAirVaccum, DryRefrigTV, DryRefrigVaccuum, DryRefrigAir, DryTVVacuum, DryTVRefrig, DryTVAir,
        DryAirRefrigTV, DryAirRefrigVaccum, DryAirTVRefrig, DryAirTVVacuum, DryAirVacuumRefrig, DryAirVacuumTV,
        DryRefrigAirTV, DryRefrigAirVacuum, DryRefrigTVVacuum, DryRefrigTVAir, DryRefrigVacuumAir, DryRefrigVacuumTV,
        DryTVAirRefrig, DryTVAirVacuum, DryTVRefrigAir, DryTVRefrigVacuum, DryTVVaccumRefrig, DryTVVacuumAir,
        DryVacuumAirRefrig, DryVacuumAirTV, DryVacuumRefrigTV, DryVacuumRefrigAir, DryVacuumTVAir, DryVacuumTVRefrig,


        VACUUM,
        VacuumAir, VacuumRefrig, VacuumTV, VacuumDry,
        VacuumAirRefrig, VacuumAirTV, VacuumAirVaccum, VacuumRefrigTV, VacuumRefrigVaccuum, VacuumRefrigAir, VacuumTVDry, VacuumTVRefrig, VacuumTVAir,
        VacuumAirRefrigTV, VacuumAirRefrigVaccum, VacuumAirTVRefrig, VacuumAirTVDry, VacuumAirDryRefrig, VacuumAirDryTV,
        VacuumRefrigAirTV, VacuumRefrigAirDry, VacuumRefrigTVDry, VacuumRefrigTVAir, VacuumRefrigDryAir, VacuumRefrigDryTV,
        VacuumTVAirRefrig, VacuumTVAirDry, VacuumTVRefrigAir, VacuumTVRefrigDry, VacuumTVVaccumRefrig, VacuumTVDryAir,
        VacuumDryAirRefrig, VacuumDryAirTV, VacuumDryRefrigTV, VacuumDryRefrigAir, VacuumDryTVAir, VacuumDryTVRefrig,
        
       AirRefrigTVDryVaccum
    
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

                        for (int i = 0; i <= 15; i++)
                        {
                            if (strs[i] == "\"+INF\"" || strs[i] == "\"-INF\"" || strs[i] == "OF" || strs[i] == "#NAME?")
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
                                // 제작중

                                //if (T1 == Time)
                                //{
                                //    writecount = 1;
                                //}
                                //else if (T2 == Time)
                                //{
                                //    writecount = 0;
                                //}

                                //air = writecount.ToString();
                                //
                                //air = "0";
                                //if(double.TryParse(PE2,out double convertPE2))
                                //{
                                //    if(convertPE2 > 5)
                                //    {
                                //        air = "1";
                                //    }
                                //    else
                                //    {
                                //        air = "0";
                                //    }
                                //}
                                break;
                            case ChoiceBtn.DRY:
                                air = "0";
                                refrig = "0";
                                vacuum = "0";
                                tv = "0";
                                //Dry 미완료 

                                //if (double.Parse(IE2) > 0.1)
                                //{
                                //    dry = "1";

                                //}
                                //else
                                //{
                                //    if (IE2 == "NaN")

                                //    {
                                //        dry = "1";
                                //    }
                                //    else
                                //    {
                                //        dry = "0";
                                //    }
                                //}

                                dry = "0";
                                //if (DataCount == 2)
                                //{
                                //    dry = "1";
                                //}else
                                //{
                                //    dry = "0";
                                //}
                                //if(IE2=="NaN")
                                //{
                                //    DataCount++;                                    
                                //}


                                break;
                            case ChoiceBtn.REFRIG:

                                air = "0";
                                dry = "0";
                                tv = "0";
                                vacuum = "0";
                                // 완료
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
                                // 완료
                                if (double.Parse(PE2) >= 15)
                                {
                                    tv = "1";
                                }
                                else
                                {
                                    if (PE2 == "NaN")
                                    {
                                        tv = "1";
                                    }
                                    else
                                    {
                                        tv = "0";
                                    }
                                }
                                break;
                            case ChoiceBtn.VACUUM:
                                air = "0";
                                dry = "0";
                                refrig = "0";
                                tv = "0";
                                // 완료

                                if (IE2 != "NaN")
                                {
                                    if (double.Parse(IE2) > 0)
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
                                }
                                else
                                {
                                    vacuum = "1";
                                }

                                break;
                            case ChoiceBtn.DryTV:
                                air = "0";
                                dry = "0";
                                refrig = "0";
                                tv = "0";
                                vacuum = "0";
                                break;
                            default:
                                air = "0";
                                dry = "0";
                                refrig = "0";
                                tv = "0";
                                vacuum = "0";
                                break;

                        }
                        //listdata.Add(new DataClass() { Number = Number, Date = Date, Time = Time, UE2 = UE2, IE2 = IE2, PE2 = PE2, SE2 = SE2, QE2 = QE2, PFE2 = PFE2, DEGE2 = DEGE2, FUE2 = FUE2, FIE2 = FIE2, UPlustpkE2 = UPlustpkE2, UMinuspkE2 = UMinuspkE2, IPluspkE2 = IPluspkE2, IMinusE2 = IMinusE2 });
                        listdata.Add(new DataClass() { Number = Number, Date = Date, Time = Time, UE2 = UE2, IE2 = IE2, PE2 = PE2, SE2 = SE2, QE2 = QE2, PFE2 = PFE2, DEGE2 = DEGE2, FUE2 = FUE2, FIE2 = FIE2, UPlustpkE2 = UPlustpkE2, UMinuspkE2 = UMinuspkE2, IPluspkE2 = IPluspkE2, IMinusE2 = IMinusE2, air = air, refrig = refrig, tv = tv, dry = dry, vacuum = vacuum });


                        Printdata = listdata.ToArray();
                    }
                }
                return Printdata;
            }
        }
        
            
        public void Labeling(DataClass[] data,string that, string T1,string T2)
        {
            int writecount = 0;
            foreach (var a in data)
            {


                
                if (T1 == a.Number)
                {
                    writecount = 1;
                }
                else if (T2 == a.Number)
                {
                    writecount = 0;
                }
                //switch (Choice)
                //{

                //    case ChoiceBtn.AIR:
                //        a.dry = "0";
                //        a.refrig = "0";
                //        a.vacuum = "0";
                //        a.tv = "0";

                //        // 제작중



                //        a.air = writecount.ToString();
                //        //
                //        //air = "0";
                //        //if(double.TryParse(PE2,out double convertPE2))
                //        //{
                //        //    if(convertPE2 > 5)
                //        //    {
                //        //        air = "1";
                //        //    }
                //        //    else
                //        //    {
                //        //        air = "0";
                //        //    }
                //        //}
                //        break;
                //    case ChoiceBtn.DRY:
                //        air = "0";
                //        refrig = "0";
                //        vacuum = "0";
                //        tv = "0";
                //        //Dry 미완료 

                //        //if (double.Parse(IE2) > 0.1)
                //        //{
                //        //    dry = "1";

                //        //}
                //        //else
                //        //{
                //        //    if (IE2 == "NaN")

                //        //    {
                //        //        dry = "1";
                //        //    }
                //        //    else
                //        //    {
                //        //        dry = "0";
                //        //    }
                //        //}

                //        dry = "0";
                //        //if (DataCount == 2)
                //        //{
                //        //    dry = "1";
                //        //}else
                //        //{
                //        //    dry = "0";
                //        //}
                //        //if(IE2=="NaN")
                //        //{
                //        //    DataCount++;                                    
                //        //}


                //        break;
                //    case ChoiceBtn.REFRIG:

                //        air = "0";
                //        dry = "0";
                //        tv = "0";
                //        vacuum = "0";
                //        // 완료
                //        if (FIE2 == "NaN")
                //        {
                //            refrig = "0";
                //        }
                //        else
                //        {
                //            refrig = "1";
                //        }
                //        break;
                //    case ChoiceBtn.TV:
                //        air = "0";
                //        dry = "0";
                //        refrig = "0";
                //        vacuum = "0";
                //        // 완료
                //        if (double.Parse(PE2) >= 15)
                //        {
                //            tv = "1";
                //        }
                //        else
                //        {
                //            if (PE2 == "NaN")
                //            {
                //                tv = "1";
                //            }
                //            else
                //            {
                //                tv = "0";
                //            }
                //        }
                //        break;
                //    case ChoiceBtn.VACUUM:
                //        air = "0";
                //        dry = "0";
                //        refrig = "0";
                //        tv = "0";
                //        // 완료

                //        if (IE2 != "NaN")
                //        {
                //            if (double.Parse(IE2) > 0)
                //            {
                //                vacuum = "1";
                //            }
                //            else
                //            {
                //                if (FUE2 == "NaN")
                //                {
                //                    vacuum = "1";
                //                }
                //                else
                //                {
                //                    vacuum = "0";
                //                }
                //            }
                //        }
                //        else
                //        {
                //            vacuum = "1";
                //        }

                //        break;
                //    case ChoiceBtn.DryTV:
                //        air = "0";
                //        dry = "0";
                //        refrig = "0";
                //        tv = "0";
                //        vacuum = "0";
                //        break;
                //    default:
                //        a.air = writecount.ToString();
                //        a.dry = "0";
                //        a.refrig = "0";
                //        a.tv = "0";
                //        a.vacuum = "0";
                //        break;

                //}


                switch (that)
                {

                    case "air":
                        a.air = writecount.ToString();
                        break;
                    case "refrig":
                        a.refrig = writecount.ToString();
                        break;
                    case "tv":
                        a.tv = writecount.ToString();
                        break;
                    case "dry":
                        a.dry = writecount.ToString();
                        break;
                    case "vacuum":
                        a.vacuum = writecount.ToString();
                        break;
                }
                if(a.air==null)
                {
                    a.air = "0";
                }
                if (a.refrig == null)
                {
                    a.refrig = "0";
                }
                if (a.tv == null)
                {
                    a.tv = "0";
                }
                if(a.dry== null)
                {
                    a.dry = "0";
                }
                if(a.vacuum== null)
                {
                    a.vacuum = "0";
                }
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
