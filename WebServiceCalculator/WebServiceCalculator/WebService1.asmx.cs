using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceCalculator
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public double Add(double[] numbers)
        {
            numbers = numbers ?? (new double[0]);
            double sum = 0;

            foreach(var n in numbers)
            {
                sum += n;
            }

            return sum;
        }

        [WebMethod]
        public double Subtract(double[] numbers)
        {
            numbers = numbers ?? (new double[0]);

            double difference = numbers.FirstOrDefault<double>();

            for (int i = 1; i < numbers.Length; ++i) 
            {
                difference -= numbers[i];
            }

            return difference;
        }

        [WebMethod]
        public double Multiply(double[] numbers)
        {
            numbers = numbers ?? (new double[0]);
            double product = 1;

            foreach (var n in numbers)
            {
                product *= n;
            }

            return product;
        }

        [WebMethod]
        public double Divide(double[] numbers)
        {
            numbers = numbers ?? (new double[0]);

            double quotient = numbers.FirstOrDefault<double>();

            if (quotient != 0)
            {
                for (int i = 1; i < numbers.Length; ++i)
                {           
                    quotient = (numbers[i] == 0) ? double.NaN : quotient / numbers[i];
                }
            }

            return quotient;
        }
    }
}
