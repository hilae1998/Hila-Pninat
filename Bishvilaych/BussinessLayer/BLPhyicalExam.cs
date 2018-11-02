using BussinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Specialized;
using System.Data;
//craet BLPhyicalExam by ortal alon
namespace BussinesLayer
{
    public class BLPhyicalExam
    {
         public PhysicalExam GetPhyicalExam(DateTime dt, string id)
        {
            DAPhyicalExam dap = new DAPhyicalExam();
            ListDictionary Params = new ListDictionary();
            Params.Add("@date", dt);
            Params.Add("@id", id);
            DataSet ds = dap.GetPhyicalExam(Params);
            PhysicalExam p = new PhysicalExam();
            p.UpdateCode = BLCtrl.getInt( ds.Tables[0].Rows[0],"UpdateCode",0);
            p.ApearsWell = BLCtrl.getBool( ds.Tables[0].Rows[0],"ApearsWell",false);
            p.ApearsWellT = BLCtrl.getString(ds.Tables[0].Rows[0], "ApearsWellT","");
            p.PupilsEqual = BLCtrl.getBool(ds.Tables[0].Rows[0], "PupilsEqual",false);
            p.TmNormal = BLCtrl.getBool(ds.Tables[0].Rows[0], "TmNormal",false);
            p.TmNormalT = BLCtrl.getString(ds.Tables[0].Rows[0], "TmNormalT","");
            p.Oropharynx = BLCtrl.getBool(ds.Tables[0].Rows[0], "Oropharynx",false);
            p.OropharynxT = BLCtrl.getString(ds.Tables[0].Rows[0], "OropharynxT","");
            p.Atraumatic = BLCtrl.getBool(ds.Tables[0].Rows[0], "Atraumatic",false);
            p.AtraumaticT = BLCtrl.getString(ds.Tables[0].Rows[0], "AtraumaticT","");
            p.HeentMucosa = BLCtrl.getBool(ds.Tables[0].Rows[0], "HeentMucosa",false);
            p.HeentMucosaT = BLCtrl.getString(ds.Tables[0].Rows[0], "HeentMucosaT","");
            p.Supple = BLCtrl.getBool(ds.Tables[0].Rows[0], "Supple",false);
            p.SuppleT = BLCtrl.getString(ds.Tables[0].Rows[0], "SuppleT","");
            p.thyromegaly = BLCtrl.getBool(ds.Tables[0].Rows[0], "thyromegaly",false);
            p.thyromegalyT = BLCtrl.getString(ds.Tables[0].Rows[0], "thyromegalyT","");
            p.HeartsoundsRegular = BLCtrl.getBool(ds.Tables[0].Rows[0], "HeartsoundsRegular",false);
            p.HeartsoundsRegularT = BLCtrl.getString(ds.Tables[0].Rows[0], "HeartsoundsRegularT","");
            p.Murmur = BLCtrl.getBool(ds.Tables[0].Rows[0], "Murmur",false);
            p.MurmurT = BLCtrl.getString(ds.Tables[0].Rows[0], "MurmurT","");
            p.GoodAir = BLCtrl.getBool(ds.Tables[0].Rows[0], "GoodAir",false);
            p.GoodAirT = BLCtrl.getString(ds.Tables[0].Rows[0], "GoodAirT","");
            p.ClearToAuscultation = BLCtrl.getBool(ds.Tables[0].Rows[0], "ClearToAuscultation",false);
            p.ClearToAuscultationT = BLCtrl.getString(ds.Tables[0].Rows[0], "ClearToAuscultationT","");
            p.SymmetricalBreast = BLCtrl.getBool(ds.Tables[0].Rows[0], "SymmetricalBreast",false);
            p.SymmetricalBreastT =BLCtrl.getString( ds.Tables[0].Rows[0],"SymmetricalBreastT","");
            p.Palpable = BLCtrl.getBool(ds.Tables[0].Rows[0], "Palpable",false);
            p.PalpableT = BLCtrl.getString(ds.Tables[0].Rows[0], "PalpableT","");
            p.SkinChanges = BLCtrl.getBool(ds.Tables[0].Rows[0], "SkinChanges",false);
            p.SkinChangesT = BLCtrl.getString(ds.Tables[0].Rows[0], "SkinChangesT","");
            p.Nipple = BLCtrl.getBool(ds.Tables[0].Rows[0], "Nipple",false);
            p.NippleT = BLCtrl.getString(ds.Tables[0].Rows[0], "NippleT","");
            p.Axillary = BLCtrl.getBool(ds.Tables[0].Rows[0], "Axillary",false);
            p.AxillaryT = BLCtrl.getString(ds.Tables[0].Rows[0], "AxillaryT","");
            p.Soft = BLCtrl.getBool(ds.Tables[0].Rows[0], "Soft",false);
            p.SoftT = BLCtrl.getString(ds.Tables[0].Rows[0], "SoftT","");
            p.Tender = BLCtrl.getBool(ds.Tables[0].Rows[0], "Tender",false);
            p.TenderT = BLCtrl.getString(ds.Tables[0].Rows[0], "TenderT","");
            p.ABDdescription = BLCtrl.getString(ds.Tables[0].Rows[0], "ABDdescription","");
            p.BowelSounds = BLCtrl.getBool(ds.Tables[0].Rows[0], "BowelSounds",false);
            p.BowelSoundsT = BLCtrl.getString(ds.Tables[0].Rows[0], "BowelSoundsT","");
            p.RenalArtery = BLCtrl.getBool(ds.Tables[0].Rows[0], "RenalArtery",false);
            p.RenalArteryT = BLCtrl.getString(ds.Tables[0].Rows[0], "RenalArteryT","");
            p.Masses = BLCtrl.getBool(ds.Tables[0].Rows[0], "Masses",false);
            p.MassesT = BLCtrl.getString(ds.Tables[0].Rows[0], "MassesT","");
            p.Organomegaly = BLCtrl.getBool(ds.Tables[0].Rows[0], "Organomegaly",false);
            p.OrganomegalyT = BLCtrl.getString(ds.Tables[0].Rows[0], "OrganomegalyT","");
            p.SkinAbnormalities = BLCtrl.getBool(ds.Tables[0].Rows[0], "SkinAbnormalities",false);
            p.SkinAbnormalitiesT = BLCtrl.getString(ds.Tables[0].Rows[0], "SkinAbnormalitiesT","");
            p.SignificantScoliosis = BLCtrl.getBool(ds.Tables[0].Rows[0], "SignificantScoliosis",false);
            p.SignificantScoliosisT = BLCtrl.getString(ds.Tables[0].Rows[0], "SignificantScoliosisT","");
            p.Kyphosis = BLCtrl.getBool(ds.Tables[0].Rows[0], "Kyphosis",false);
            p.KyphosisT = BLCtrl.getString(ds.Tables[0].Rows[0], "KyphosisT","");
            p.Edema = BLCtrl.getBool(ds.Tables[0].Rows[0], "Edema",false);
            p.EdemaT = BLCtrl.getString(ds.Tables[0].Rows[0], "EdemaT","");
            p.EXTRash = BLCtrl.getBool(ds.Tables[0].Rows[0], "EXTRash",false);
            p.EXTRashT = BLCtrl.getString(ds.Tables[0].Rows[0], "EXTRashT","");
            p.Varicosities = BLCtrl.getBool(ds.Tables[0].Rows[0], "Varicosities",false);
            p.VaricositiesT = BLCtrl.getString(ds.Tables[0].Rows[0], "VaricositiesT","");
            p.Pppx4 = BLCtrl.getBool(ds.Tables[0].Rows[0], "Pppx4",false);
            p.Pppx4T = BLCtrl.getString(ds.Tables[0].Rows[0], "Pppx4T","");
            p.PedalEdema = BLCtrl.getBool(ds.Tables[0].Rows[0], "PedalEdema",false);
            p.PedalEdemaT = BLCtrl.getString(ds.Tables[0].Rows[0], "PedalEdemaT","");
            p.Toes = BLCtrl.getBool(ds.Tables[0].Rows[0], "Toes",false);
            p.ToesT = BLCtrl.getString(ds.Tables[0].Rows[0], "ToesT","");
            p.Pattelar = BLCtrl.getBool(ds.Tables[0].Rows[0], "Pattelar",false);
            p.PattelarT = BLCtrl.getString(ds.Tables[0].Rows[0], "PattelarT","");
            p.Gait = BLCtrl.getBool(ds.Tables[0].Rows[0], "Gait",false);
            p.GaitT = BLCtrl.getString(ds.Tables[0].Rows[0], "GaitT","");
            p.Speech = BLCtrl.getBool(ds.Tables[0].Rows[0], "Speech",false);
            p.SpeechT = BLCtrl.getString(ds.Tables[0].Rows[0], "SpeechT","");
            p.Female = BLCtrl.getBool(ds.Tables[0].Rows[0], "Female",false);
            p.FemaleT = BLCtrl.getString(ds.Tables[0].Rows[0], "FemaleT","");
            p.PelvicMucosa =BLCtrl.getInt( ds.Tables[0].Rows[0],"PelvicMucosa",1);
            p.Kegels = BLCtrl.getInt( ds.Tables[0].Rows[0],"Kegels",1);
            p.Cervix = BLCtrl.getString(ds.Tables[0].Rows[0], "Cervix","");
            p.VaginalWalls = BLCtrl.getBool(ds.Tables[0].Rows[0], "VaginalWalls",false);
            p.VaginalWallsT = BLCtrl.getString(ds.Tables[0].Rows[0], "VaginalWallsT","");
            p.Pap = BLCtrl.getBool(ds.Tables[0].Rows[0], "Pap",false);
            p.PapT =BLCtrl.getString( ds.Tables[0].Rows[0],"PapT","");
            return p;
        }

        //public int AddOrUpdatePhysicalExam1(string id, bool apearsWell, string apearsWellT, bool pupilsEqual, string pupilsEqualT, bool tmNormal, string tmNormalT, bool oropharynx, string oropharynxT, bool atraumatic, string atraumaticT, bool heentMucosa, string heentMucosaT, bool supple, string suppleT, bool thyromegaly, string thyromegalyT, bool heartsoundsRegular, string heartsoundsRegularT, bool murmur, string murmurT, bool goodAir, string goodAirT, bool clearToAuscultation, string clearToAuscultationT, bool symmetricalBreast, string symmetricalBreastT, bool palpable, string palpableT, bool skinChanges, string skinChangesT, bool nipple, string nippleT, bool axillary, string axillaryT, bool soft, string softT, bool tender, string tenderT, string aBDdescription, bool bowelSounds, string bowelSoundsT, bool renalArtery, string renalArteryT, bool masses, string massesT, bool organomegaly, string organomegalyT, bool skinAbnormalities, string skinAbnormalitiesT, bool significantScoliosis, string significantScoliosisT, bool kyphosis, string kyphosisT, bool edema, string edemaT, bool eXTRash, string eXTRashT, bool varicosities, string varicositiesT, bool pppx4, string pppx4T, bool pedalEdema, string pedalEdemaT, bool toes, string toesT, bool pattelar, string pattelarT, bool gait, string gaitT, bool speech, string speechT, bool female, string femaleT, int pelvicMucosa, int kegels, string cervix, bool vaginalWalls, string vaginalWallsT, bool pap, string papT, int v)
        //{
        //    throw new NotImplementedException();
        //}

        public int AddOrUpdatePhysicalExam1(string id,           
         bool ApearsWell ,
         string ApearsWellT ,
         bool PupilsEqual ,
         string PupilsEqualT ,
         bool TmNormal ,
         string TmNormalT ,
         bool Oropharynx ,
         string OropharynxT ,
         bool Atraumatic ,
         string AtraumaticT 
            ,bool HeentMucosa ,
         string HeentMucosaT ,
         bool Supple ,
         string SuppleT ,
         bool thyromegaly ,
         string thyromegalyT ,
            bool HeartsoundsRegular ,
            string HeartsoundsRegularT ,
            bool Murmur ,
         string MurmurT ,
         bool GoodAir ,
         string GoodAirT ,
         bool ClearToAuscultation ,
         string ClearToAuscultationT ,
         bool SymmetricalBreast ,
         string SymmetricalBreastT ,
         bool Palpable ,
         string PalpableT ,
         bool SkinChanges 
            ,string SkinChangesT ,
         bool Nipple ,
         string NippleT ,
         bool Axillary ,
         string AxillaryT ,
         bool Soft 
            ,string SoftT 
            ,bool Tender
            ,string TenderT ,
         string ABDdescription
            ,bool BowelSounds 
            ,string BowelSoundsT 
            ,bool RenalArtery 
            ,string RenalArteryT ,
         bool Masses
            ,string MassesT 
            ,bool Organomegaly ,
         string OrganomegalyT 
            ,bool SkinAbnormalities
            ,string SkinAbnormalitiesT ,
         bool SignificantScoliosis
            ,string SignificantScoliosisT 
            ,bool Kyphosis
            ,string KyphosisT 
            ,bool Edema 
            ,string EdemaT ,
         bool EXTRash 
            ,string EXTRashT 
            ,bool Varicosities 
            ,string VaricositiesT 
            ,bool Pppx4
            ,string Pppx4T 
            ,bool PedalEdema
            ,string PedalEdemaT ,
         bool Toes 
            ,string ToesT 
            ,bool Pattelar
            ,string PattelarT 
            ,bool Gait 
            ,string GaitT 
            ,bool Speech 
            ,string SpeechT ,
         bool Female
            ,string FemaleT 
            ,int PelvicMucosa 
            ,int Kegels 
            ,string Cervix 
            ,bool VaginalWalls
            ,string VaginalWallsT 
            ,bool Pap ,
         string PapT)             
        {
            DAPhyicalExam dm = new DAPhyicalExam();
            ListDictionary Params = new ListDictionary();
           
            Params.Add("@id",BLCtrl.sendString( id,""));
            Params.Add("@ApearsWell2", BLCtrl.sendBool(ApearsWell,false));
            Params.Add("@ApearsWellT2",BLCtrl.sendString( ApearsWellT,""));
            Params.Add("@PupilsEqual2", BLCtrl.sendBool(PupilsEqual, false));
            Params.Add("@PupilsEqualT2", BLCtrl.sendString(PupilsEqualT,""));
            Params.Add("@TmNormal2", BLCtrl.sendBool(TmNormal, false));
            Params.Add("@TmNormalT2", BLCtrl.sendString(TmNormalT, ""));
            Params.Add("@Oropharynx2", BLCtrl.sendBool(Oropharynx, false));
            Params.Add("@OropharynxT2", BLCtrl.sendString(OropharynxT, ""));
            Params.Add("@Atraumatic2", BLCtrl.sendBool(Atraumatic, false));
            Params.Add("@AtraumaticT2", BLCtrl.sendString(AtraumaticT, ""));
            Params.Add("@HeentMucosa2", BLCtrl.sendBool(HeentMucosa, false));
            Params.Add("@HeentMucosaT2", BLCtrl.sendString(HeentMucosaT, ""));
            Params.Add("@Supple2", BLCtrl.sendBool(Supple, false));
            Params.Add("@SuppleT2", BLCtrl.sendString(SuppleT, ""));
            Params.Add("@thyromegaly2", BLCtrl.sendBool(thyromegaly, false));
            Params.Add("@thyromegalyT2", BLCtrl.sendString(thyromegalyT, ""));
            Params.Add("@HeartsoundsRegular2", BLCtrl.sendBool(HeartsoundsRegular, false));
            Params.Add("@HeartsoundsRegularT2", BLCtrl.sendString(HeartsoundsRegularT, ""));
            Params.Add("@Murmur2", BLCtrl.sendBool(Murmur, false));
            Params.Add("@MurmurT2", BLCtrl.sendString(MurmurT, ""));
            Params.Add("@GoodAir2", BLCtrl.sendBool(GoodAir, false));
            Params.Add("@GoodAirT2", BLCtrl.sendString(GoodAirT, ""));
            Params.Add("@ClearToAuscultation2", BLCtrl.sendBool(ClearToAuscultation, false));
            Params.Add("@ClearToAuscultationT2", BLCtrl.sendString(ClearToAuscultationT, ""));
            Params.Add("@SymmetricalBreast2", BLCtrl.sendBool(SymmetricalBreast, false));
            Params.Add("@SymmetricalBreastT2", BLCtrl.sendString(SymmetricalBreastT, ""));
            Params.Add("@Palpable2", BLCtrl.sendBool(Palpable, false));
            Params.Add("@PalpableT2", BLCtrl.sendString(PalpableT, ""));
            Params.Add("@SkinChanges2", BLCtrl.sendBool(SkinChanges, false));
            Params.Add("@SkinChangesT2", BLCtrl.sendString(SkinChangesT, ""));
            Params.Add("@Nipple2", BLCtrl.sendBool(Nipple, false));
            Params.Add("@NippleT2", BLCtrl.sendString(NippleT, ""));
            Params.Add("@Axillary2", BLCtrl.sendBool(Axillary, false));
            Params.Add("@AxillaryT2", BLCtrl.sendString(AxillaryT, ""));
            Params.Add("@Soft2", BLCtrl.sendBool(Soft, false));
            Params.Add("@SoftT2", BLCtrl.sendString(SoftT, ""));
            Params.Add("@Tender2", BLCtrl.sendBool(Tender, false));
            Params.Add("@TenderT2", BLCtrl.sendString(TenderT, ""));
            Params.Add("@ABDdescription2", BLCtrl.sendString(ABDdescription, ""));
            Params.Add("@BowelSounds2", BLCtrl.sendBool(BowelSounds, false));
            Params.Add("@BowelSoundsT2", BLCtrl.sendString(BowelSoundsT, ""));
            Params.Add("@RenalArtery2", BLCtrl.sendBool(RenalArtery, false));
            Params.Add("@RenalArteryT2", BLCtrl.sendString(RenalArteryT, ""));
            Params.Add("@Masses2", BLCtrl.sendBool(Masses, false));
            Params.Add("@MassesT2", BLCtrl.sendString(MassesT, ""));
            Params.Add("@Organomegaly2", BLCtrl.sendBool(Organomegaly, false));
            Params.Add("@OrganomegalyT2", BLCtrl.sendString(OrganomegalyT, ""));
            Params.Add("@SkinAbnormalities2", BLCtrl.sendBool(SkinAbnormalities, false));
            Params.Add("@SkinAbnormalitiesT2", BLCtrl.sendString(SkinAbnormalitiesT, ""));
            Params.Add("@SignificantScoliosis2", BLCtrl.sendBool(SignificantScoliosis, false));
            Params.Add("@SignificantScoliosisT2", BLCtrl.sendString(SignificantScoliosisT, ""));
            Params.Add("@Kyphosis2", BLCtrl.sendBool(Kyphosis, false));
            Params.Add("@KyphosisT2", BLCtrl.sendString(KyphosisT, ""));
            Params.Add("@Edema2", BLCtrl.sendBool(Edema, false));
            Params.Add("@EdemaT2", BLCtrl.sendString(EdemaT, ""));
            Params.Add("@EXTRash2", BLCtrl.sendBool(EXTRash, false));
            Params.Add("@EXTRashT2", BLCtrl.sendString(EXTRashT, ""));
            Params.Add("@Varicosities2", BLCtrl.sendBool(Varicosities, false));
            Params.Add("@VaricositiesT2", BLCtrl.sendString(VaricositiesT, ""));
            Params.Add("@Pppx42", BLCtrl.sendBool(Pppx4, false));
            Params.Add("@Pppx4T2", BLCtrl.sendString(Pppx4T, ""));
            Params.Add("@PedalEdema2", BLCtrl.sendBool(PedalEdema, false));
            Params.Add("@PedalEdemaT2", BLCtrl.sendString(PedalEdemaT, ""));
            Params.Add("@Toes2", BLCtrl.sendBool(Toes, false));
            Params.Add("@ToesT2", BLCtrl.sendString(ToesT, ""));
            Params.Add("@Pattelar2", BLCtrl.sendBool(Pattelar, false));
            Params.Add("@PattelarT2", BLCtrl.sendString(PattelarT, ""));
            Params.Add("@Gait2", BLCtrl.sendBool(Gait, false));
            Params.Add("@GaitT2", BLCtrl.sendString(GaitT, ""));
            Params.Add("@Speech2", BLCtrl.sendBool(Speech, false));
            Params.Add("@SpeechT2", BLCtrl.sendString(SpeechT, ""));
            Params.Add("@Female2", BLCtrl.sendBool(Female, false));
            Params.Add("@FemaleT2", BLCtrl.sendString(FemaleT, ""));
            Params.Add("@PelvicMucosa2",BLCtrl.sendInt( PelvicMucosa,1));
            Params.Add("@Kegels2", BLCtrl.sendInt(Kegels,1));
            Params.Add("@Cervix2", BLCtrl.sendString(Cervix,""));
            Params.Add("@VaginalWalls2", BLCtrl.sendBool(VaginalWalls,false));
            Params.Add("@VaginalWallsT2", BLCtrl.sendString(VaginalWallsT,""));
            Params.Add("@Pap2", BLCtrl.sendBool(Pap,false));
            Params.Add("@PapT2", BLCtrl.sendString(PapT,""));
           
            int result = dm.AddOrUpdatePhysicalExam(Params);
            return result;
        }
    }
}
