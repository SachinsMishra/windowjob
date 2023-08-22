// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
example();

static void example()
{
    List<UserModel> model = new List<UserModel>();
    string currentPath = System.IO.Directory.GetCurrentDirectory();
    currentPath = currentPath.Substring(0, currentPath.IndexOf("bin\\Debug\\net6.0"));
    using (StreamReader reader = new StreamReader(currentPath + "code.txt"))
    {
        string line;
        bool isFirstLine = true;
        while ((line = reader.ReadLine()) != null)
        {
            if (isFirstLine)
            {
                // Skip the header line
                isFirstLine = false;
                continue;
            }
            string[] fields = line.Split('|');
            UserModel model2 = new UserModel()
            {   
                BUSINESS_LINE = fields[0].Trim('"')
            };
            model.Add(model2);
        }
    }
}

public class UserModel
{
    public string BUSINESS_LINE { get; set; }
    public string MEMBER_ID { get; set; }
    public string FIRST_NAME { get; set; }
    public string LAST_NAME { get; set; }
    public string ZIP_CODE { get; set; }
    public string COUNTY_FIPS { get; set; }
    public string STATE_CODE { get; set; }
    public string GENDER { get; set; }
    public string DOB { get; set; }
    public string PHONE_NUMBER_CUSTOMER { get; set; }
    public string EMAIL_CUSTOMER { get; set; }
    public string PERSON_ID { get; set; }
    public string PREM_LANGUAGE_PREF { get; set; }
    public string PREM_HH_INCOME { get; set; }
    public string AGE_RANGE { get; set; }
    public string PREM_ETHNICITY { get; set; }
    public string VETERAN_IN_HH { get; set; }
    public string CHILDREN_IN_HH { get; set; }
    public string PHONE_NUMBER_UPDATED { get; set; }
    public string EMAIL_UPDATED { get; set; }
    public string SNS_HOUSING_INSTABILITY_FLAG { get; set; }
    public string SNS_HOUSING_INSTABILITY_PRED_PROB { get; set; }
    public string SNS_FOOD_INSECURITY_FLAG { get; set; }
    public string SNS_FOOD_INSECURITY_PRED_PROB { get; set; }
    public string SNS_TRANSPORTATION_NEEDS_FLAG { get; set; }
    public string SNS_TRANSPORTATION_NEEDS_PRED_PROB { get; set; }
    public string SNS_HEALTH_LITERACY_FLAG { get; set; }
    public string SNS_HEALTH_LITERACY_PRED_PROB { get; set; }
    public string SNS_FINANCIAL_INSECURITY_FLAG { get; set; }
    public string SNS_FINANCIAL_INSECURITY_PRED_PROB { get; set; }
    public string SNS_UNINSURED_FLAG { get; set; }
    public string SNS_UNINSURED_PRED_PROB { get; set; }
    public string SNS_UNEMPLOYED_FLAG { get; set; }
    public string SNS_UNEMPLOYED_PRED_PROB { get; set; }
    public string SNS_CHILDCARE_NEEDS_FLAG { get; set; }
    public string SNS_CHILDCARE_NEEDS_PRED_PROB { get; set; }
    public string SNS_HOUSING_QUALITY_FLAG { get; set; }
    public string SNS_HOUSING_QUALITY_PRED_PROB { get; set; }
    public string SNS_UTILITY_NEEDS_FLAG { get; set; }
    public string SNS_UTILITY_NEEDS_PRED_PROB { get; set; }
    public string SNS_LACK_OF_BROADBAND_FLAG { get; set; }
    public string SNS_LACK_OF_BROADBAND_PRED_PROB { get; set; }
    public string SNS_LONELINESS_FLAG { get; set; }
    public string SNS_LONELINESS_PRED_PROB { get; set; }
    public string SNS_SCORE { get; set; }
    public string UTILIZATION_ED_SUPERUSER_FLAG { get; set; }
    public string UTILIZATION_ED_SUPERUSER_PRED_PROB { get; set; }
    public string UTILIZATION_ED_AVOIDABLE_FLAG { get; set; }
    public string UTILIZATION_ED_AVOIDABLE_PRED_PROB { get; set; }
    public string UTILIZATION_ACUTE_RISING_RISK_FLAG { get; set; }
    public string UTILIZATION_ACUTE_RISING_RISK_PRED_PROB { get; set; }
    public string UTILIZATION_READMIT_FLAG { get; set; }
    public string UTILIZATION_READMIT_PRED_PROB { get; set; }
    public string UTILIZATION_TCOC { get; set; }
    public string UTILIZATION_TELEHEALTH_FLAG { get; set; }
    public string UTILIZATION_TELEHEALTH_PRED_PROB { get; set; }
    public string ENGAGE_EMAIL_FLAG { get; set; }
    public string ENGAGE_EMAIL_PRED_PROB { get; set; }
    public string ENGAGE_MAIL_FLAG { get; set; }
    public string ENGAGE_MAIL_PRED_PROB { get; set; }
    public string ENGAGE_TEXT_FLAG { get; set; }
    public string ENGAGE_TEXT_PRED_PROB { get; set; }
    public string ENGAGE_CALL_FLAG { get; set; }
    public string ENGAGE_CALL_PRED_PROB { get; set; }
    public string ENGAGE_CALL_DURING_DAY_FLAG { get; set; }
    public string ENGAGE_CALL_DURING_DAY_PRED_PROB { get; set; }
    public string NSP_NO_SHOW_FLAG { get; set; }
    public string NSP_NO_SHOW_PRED_PROB { get; set; }
    public string BARRIERS_TO_ENGAGE_CHILDCARE { get; set; }
    public string BARRIERS_TO_ENGAGE_TRANSPORTATION { get; set; }
    public string BARRIERS_TO_ENGAGE_LANGUAGE { get; set; }
    public string NSP_BENEFITS_FLAG { get; set; }
    public string NSP_FOOD_FLAG { get; set; }
    public string NSP_HOUSING_FLAG { get; set; }
    public string NSP_INCOME_FLAG { get; set; }
    public string NSP_INDFAMILY_FLAG { get; set; }
    public string NSP_UTILITIES_FLAG { get; set; }
    public string NSP_EMPLOYMENT_FLAG { get; set; }
    public string NSP_TRANSPORTATION_FLAG { get; set; }
    public string NSP_EDUCATION_FLAG { get; set; }
    public string NSP_LEGAL_FLAG { get; set; }
    public string NSP_SOCIAL_ENRICH_FLAG { get; set; }
    public string NSP_MONEY_MGMT_FLAG { get; set; }
    public string NSP_MENTAL_HEALTH_FLAG { get; set; }
    public string NSP_WELLNESS_FLAG {get;set;}
}

