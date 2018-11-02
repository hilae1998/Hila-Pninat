--ORTAL ALON
--הוספה או עדכון של בדיקה רפואית עפ"י תאריך ות"ז של פציינט 
alter procedure AddOrUpdatePhysicalExam1
( @id varchar(10),
 @ApearsWell2 bit,@ApearsWellT2 nvarchar(200),@PupilsEqual2 bit,@PupilsEqualT2 nvarchar(200),
 @TmNormal2 bit,@TmNormalT2 nvarchar(200),
 @Oropharynx2 bit,@OropharynxT2 nvarchar(200),@Atraumatic2 bit,@AtraumaticT2 nvarchar(200),
 @HeentMucosa2 bit,@HeentMucosaT2 nvarchar(200),@Supple2 bit,@SuppleT2 nvarchar(200),
 @thyromegaly2 bit,@thyromegalyT2 nvarchar(200),@HeartsoundsRegular2 bit, @HeartsoundsRegularT2 nvarchar(200),
 @Murmur2 bit,@MurmurT2 nvarchar(200),@GoodAir2 bit, @GoodAirT2 nvarchar(200),
 @ClearToAuscultation2 bit,@ClearToAuscultationT2 nvarchar(200),
 @SymmetricalBreast2 bit,@SymmetricalBreastT2 nvarchar(200),
 @Palpable2 bit,@PalpableT2 nvarchar(200),
 @SkinChanges2 bit,@SkinChangesT2 nvarchar(200),@Nipple2 bit,@NippleT2 nvarchar(200),
 @Axillary2 bit,@AxillaryT2 nvarchar(200),@Soft2 bit,@SoftT2 nvarchar(200),
 @Tender2 bit,@TenderT2 nvarchar(200) ,@ABDdescription2 nvarchar(200),
 @BowelSounds2 bit,@BowelSoundsT2 nvarchar(200),@RenalArtery2 bit,@RenalArteryT2 nvarchar(200),
 @Masses2 bit,@MassesT2 nvarchar(200),@Organomegaly2 bit,@OrganomegalyT2 nvarchar(200),
 @SkinAbnormalities2 bit ,@SkinAbnormalitiesT2 nvarchar(200),
 @SignificantScoliosis2 bit,@SignificantScoliosisT2 nvarchar(200),
 @Kyphosis2 bit,@KyphosisT2 nvarchar(200),@Edema2 bit,@EdemaT2 nvarchar(200),
 @EXTRash2 bit,@EXTRashT2 nvarchar(200),@Varicosities2 bit,@VaricositiesT2 nvarchar(200),
 @Pppx42 bit,@Pppx4T2 nvarchar(200),@PedalEdema2 bit,@PedalEdemaT2 nvarchar(200),
 @Toes2 bit,@ToesT2 nvarchar(200),@Pattelar2 bit,@PattelarT2 nvarchar(200),
 @Gait2 bit,@GaitT2 nvarchar(200),@Speech2 bit,@SpeechT2 nvarchar(200),
 @Female2 nvarchar(200),@FemaleT2 nvarchar(200),@PelvicMucosa2 int,@Kegels2 int,
 @Cervix2 nvarchar(200),@VaginalWalls2 bit,@VaginalWallsT2 nvarchar(200),@Pap2 bit,@PapT2 nvarchar(200),@Myout int out)
 as
begin
declare @date datetime
set @date=getdate()

if exists(
	select *
	from [dbo].[PhysicalExam] join [dbo].[Updatings]
	on [dbo].[PhysicalExam].[UpdateCode]=[dbo].[Updatings].[Code]
	join [dbo].[Patiants]
	on [dbo].[Updatings].[PatiantCode]=[dbo].[Patiants].[Code]
	where [dbo].[Updatings].[UpdateDate]=@date and [dbo].[Patiants].[Id]=@id)
	
update [dbo].[PhysicalExam]
set [ApearsWell]=@ApearsWell2,
[ApearsWellT]=@ApearsWellT2,
[PupilsEqual]=@PupilsEqual2,
[PupilsEqualT]=@PupilsEqualT2,
[TmNormal]=@TmNormal2,
[TmNormalT]=@TmNormalT2,
[Oropharynx]=@Oropharynx2,
[OropharynxT]=@OropharynxT2,
[Atraumatic]=@Atraumatic2,
[AtraumaticT]=@AtraumaticT2,
[HeentMucosa]=@HeentMucosa2,
[HeentMucosaT]=@HeentMucosaT2,
[Supple]=@Supple2,
[SuppleT]=@SuppleT2,
[thyromegaly]=@thyromegaly2,
[thyromegalyT]=@thyromegalyT2,
[HeartsoundsRegular]=@HeartsoundsRegular2,
[HeartsoundsRegularT]=@HeartsoundsRegularT2,
[Murmur]=@Murmur2,
[MurmurT]=@MurmurT2,
[GoodAir]=@GoodAir2,
[GoodAirT]=@GoodAirT2,
[ClearToAuscultation]=@ClearToAuscultation2,
[ClearToAuscultationT]=@ClearToAuscultationT2,
[SymmetricalBreast]=@SymmetricalBreast2,
[SymmetricalBreastT]=@SymmetricalBreastT2,
[Palpable]=@Palpable2,
[PalpableT]=@PalpableT2,
[SkinChanges]=@SkinChanges2,
[SkinChangesT]=@SkinChangesT2,
[Nipple]=@Nipple2,
[NippleT]=@NippleT2,
[Axillary]=@Axillary2,
[AxillaryT]=@AxillaryT2,
[Soft]=@Soft2,
[SoftT]=@SoftT2,
[Tender]=@Tender2,
[TenderT]=@TenderT2,
[ABDdescription]=@ABDdescription2,
[BowelSounds]=@BowelSounds2,
[BowelSoundsT]=@BowelSoundsT2,
[RenalArtery]=@RenalArtery2,
[RenalArteryT]=@RenalArteryT2,
[Masses]=@Masses2,
[MassesT]=@MassesT2,
[Organomegaly]=@Organomegaly2,
[OrganomegalyT]=@OrganomegalyT2,
[SkinAbnormalities]=@SkinAbnormalities2,
[SkinAbnormalitiesT]=@SkinAbnormalitiesT2,
[SignificantScoliosis]=@SignificantScoliosis2,
[SignificantScoliosisT]=@SignificantScoliosisT2,
[Kyphosis]=@Kyphosis2,
[KyphosisT]=@KyphosisT2,
[Edema]=@Edema2,
[EdemaT]=@EdemaT2,
[EXTRash]=@EXTRash2,
[EXTRashT]=@EXTRashT2,
[Varicosities]=@Varicosities2,
[VaricositiesT]=@VaricositiesT2,
[Pppx4]=@Pppx42,
[Pppx4T]=@Pppx4T2,
[PedalEdema]=@PedalEdema2,
[PedalEdemaT]=@PedalEdemaT2,
[Toes]=@Toes2,
[ToesT]=@ToesT2,
[Pattelar]=@Pattelar2,
[PattelarT]=@PattelarT2,
[Gait]=@Gait2,
[Speech]=@Speech2,
[SpeechT]=@SpeechT2,
[Female]=@Female2,
[FemaleT]=@FemaleT2,
[PelvicMucosa]=@PelvicMucosa2,
[Kegels]=@Kegels2,
[Cervix]=@Cervix2,
[VaginalWalls]=@VaginalWalls2,
[VaginalWallsT]=@VaginalWallsT2,
[Pap]=@Pap2,
[PapT]=@PapT2


else
begin
insert into [dbo].[PhysicalExam]([ApearsWell],[ApearsWellT],[PupilsEqual],[PupilsEqualT],
[TmNormal],[TmNormalT],[Oropharynx],[OropharynxT],[Atraumatic],[AtraumaticT],[HeentMucosa],
[HeentMucosaT],[Supple],[SuppleT],[thyromegaly],[thyromegalyT],[HeartsoundsRegular],
[HeartsoundsRegularT],[Murmur],[MurmurT],[GoodAir],[GoodAirT],[ClearToAuscultation],
[ClearToAuscultationT],[SymmetricalBreast],[SymmetricalBreastT],[Palpable],[PalpableT],
[SkinChanges],[SkinChangesT],[Nipple],[NippleT],[Axillary],[AxillaryT],[Soft],[SoftT],[Tender],[TenderT],
[ABDdescription],[BowelSounds],[BowelSoundsT],[RenalArtery],[RenalArteryT],[Masses],
[MassesT],[Organomegaly],[OrganomegalyT],[SkinAbnormalities],[SkinAbnormalitiesT],
[SignificantScoliosis],[SignificantScoliosisT],[Kyphosis],[KyphosisT],[Edema],[EdemaT],
[EXTRash],[EXTRashT],[Varicosities],[VaricositiesT],[Pppx4],[Pppx4T],[PedalEdema],
[PedalEdemaT],[Toes],[ToesT],[Pattelar],[PattelarT],[Gait],[GaitT],[Speech],[SpeechT],[Female],
[FemaleT],[PelvicMucosa],[Kegels],[Cervix],[VaginalWalls],[VaginalWallsT],[Pap],[PapT])

values (@ApearsWell2 ,@ApearsWellT2 ,@PupilsEqual2,@PupilsEqualT2,@TmNormal2 ,@TmNormalT2 ,@Oropharynx2 ,@OropharynxT2 ,@Atraumatic2 ,@AtraumaticT2 ,
@HeentMucosa2, @HeentMucosaT2 , @Supple2 ,@SuppleT2 ,@thyromegaly2 ,@thyromegalyT2,@HeartsoundsRegular2 ,
 @HeartsoundsRegularT2 ,@Murmur2 ,@MurmurT2 ,@GoodAir2 , @GoodAirT2 , @ClearToAuscultation2 ,@ClearToAuscultationT2 ,
 @SymmetricalBreast2 ,@SymmetricalBreastT2 ,
 @Palpable2 ,@PalpableT2 ,@SkinChanges2 ,@SkinChangesT2 ,@Nipple2 ,@NippleT2 ,@Axillary2 ,@AxillaryT2 ,@Soft2 ,@SoftT2 ,
 @Tender2 ,@TenderT2  ,
 @ABDdescription2 ,@BowelSounds2 ,@BowelSoundsT2 ,@RenalArtery2 ,@RenalArteryT2 ,@Masses2 ,@MassesT2 ,@Organomegaly2 ,
 @OrganomegalyT2 ,@SkinAbnormalities2  ,
 @SkinAbnormalitiesT2 ,@SignificantScoliosis2 ,@SignificantScoliosisT2 ,@Kyphosis2 ,@KyphosisT2 ,@Edema2 ,@EdemaT2 ,
 @EXTRash2 ,@EXTRashT2 ,@Varicosities2 ,
 @VaricositiesT2 ,@Pppx42 ,@Pppx4T2 ,@PedalEdema2 ,@PedalEdemaT2 ,@Toes2 ,@ToesT2 ,@Pattelar2 ,@PattelarT2 ,@Gait2 ,
 @GaitT2 ,@Speech2 ,
 @SpeechT2 ,@Female2 ,@FemaleT2 ,@PelvicMucosa2 ,@Kegels2 ,@Cervix2 , @VaginalWalls2 ,@VaginalWallsT2 ,@Pap2 ,@PapT2 )
end
set @Myout=0--הפורצדורה עברה בהצלחה
end 










