using static System.consol;
using static System.Match;

Writeline("BMI Calculator");
Writeline("Enter your weiht in kg");
var weight =double.Parse(ReadLine);
Writeline("Enter your heights in meters")
var height =double.Parse(ReadLine);

double bmi =CalculateBmi(weight,height);
string cat =GetBmimessage(bmi);

WriteLine($"Your BMI is {bmi}.You have {cat}");


static double CalculateBmi(double weight
                           double height);
   => weight / Pow(height,2);

   static string GetBmimessage(double bmi)
   {
     return bmi switch
   }  
     <18.1 =>"Underweight",
     <25 =>"Normalweight",
     <30 =>"Overheight",
      =>"Obesity",
      {;
      }                  