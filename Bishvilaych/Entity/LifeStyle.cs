using System;


public class LifeStyle
{

    //life style nutrition
    public int UpdateCode { get; set; }
    public float Height { get; set; }// מספרים ונקודה
    public float Wieght { get; set; }// מספרים ונקודה
    public int BMI { get; set; }// מספרים 
    public string BloodPressure { get; set; }// מספרים ונקודה
    public int pulse { get; set; }// מספרים 
    public bool NotEat { get; set; }
    public string NotEatT { get; set; }
    public int Meals { get; set; }// מספרים 
    public int Fruits { get; set; }// מספרים 
    public int Vegetables { get; set; }// מספרים 
    public bool Dairy { get; set; }
    public int Water { get; set; }// מספרים 
    public bool Diet { get; set; }
    public string DietT { get; set; }
    public float SleepingHours { get; set; }// מספרים ונקודה
    public bool Activity { get; set; }

    //life style doctor
    public bool Acohol { get; set; }// bool
    public string AcoholT { get; set; }//חופשי required
    public bool Smoking { get; set; }//bool
    public bool Smoke { get; set; }//bool
    public bool PassiveSmoking { get; set; }//bool
    public string PassiveSmokingT { get; set; }//חופשי required
    public bool Drugs { get; set; }//bool
    public string DrugsT { get; set; }//חופשי required
    public bool PastDrugs { get; set; }//bool
    public string PastDrugsT { get; set; }//חופשי required
    public bool Trauma { get; set; }//bool
    public string TraumaT { get; set; }//חופשי required
    public bool DisordersEating { get; set; }//bool
    public string DisordersEatingT { get; set; }//חופשי required
    public bool PastDisordersEating { get; set; }//bool
    public string PastDisordersEatingT { get; set; }//חופשי required


    public bool Anxiety { get; set; }//bool
    public string AnxietyT { get; set; }//חופשי required
    public bool Bi_polar { get; set; }//bool
    public string Bi_polarT { get; set; }//חופשי required
    public bool Depression { get; set; }//bool
    public string DepressionT { get; set; }//חופשי required
    public bool OtherMentallssue { get; set; }//bool
    public string OtherMentallssueT { get; set; }//חופשי required


    public bool Relation { get; set; }//bool
    public string RelationT { get; set; }//חופשי required
    public bool Ab { get; set; }//bool
    public string AbT { get; set; }//חופשי required
    public string St { get; set; }// חופשי
}
