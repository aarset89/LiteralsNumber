using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class DataManagerClass
    {
        private string literals = "abcdefghijklmnopqrstuvwxyz";


        //TODO - 

        public DataOut IntToLocationNumeral(int input)
        {

            DataOut output = new DataOut() { Result = Models.Common.Result.error };
            try
            {

                string response = GetLocationNumeralfromInt(input);

                output.Output = response;
                output.Result = Models.Common.Result.success;

            }
            catch (Exception e)
            {
                output.Message = e.Message;
            }
            return output;
        }

        public DataOut LocationNumeralToInt(string input)
        {
            DataOut output = new DataOut() { Result = Models.Common.Result.error };
            try
            {

                int response = GetIntegerFromLiteral(input);

                output.Output = response.ToString();
                output.Result = Models.Common.Result.success;

            }
            catch (Exception e)
            {
                output.Message = e.Message;
            }
            return output;
        }

        public DataOut LocationNumeralToAbreviated(string input)
        {

            DataOut output = new DataOut() { Result = Models.Common.Result.error };
            try
            {

                int preResponse = GetIntegerFromLiteral(input);
                string response = GetLocationNumeralfromInt(preResponse);

                output.Output = response;
                output.Result = Models.Common.Result.success;

            }
            catch (Exception e)
            {
                output.Message = e.Message;
            }
            return output;
        }

        private string GetLocationNumeralfromInt(int input)
        {
            string bin = Convert.ToString(input, 2);

            string result = "";
            string[] arr = new string[(bin.Length / literals.Length) + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                string newBin = "";

                var tempArr = bin.Take((bin.Length > literals.Length) ? literals.Length : bin.Length).ToArray();

                Array.Reverse(tempArr);
                tempArr.ToList().ForEach(delegate (char a) { newBin += a; });
                arr[i] = newBin;

                bin = bin.Substring(newBin.Length);
            }

            foreach (string newbin in arr)
            {
                int control = 0;

                while (control < newbin.Length)
                {
                    if (newbin[control] == '1')
                    {
                        result += literals[control];
                    }

                    control++;
                }
            }


            return result;
        }

        private int GetIntegerFromLiteral(string input)
        {

            int result = 0;

            foreach (char charInput in input)
            {
                var literalIndex = literals.IndexOf(charInput);
                result += (int)Math.Pow(2, literalIndex);
            }

            return result;
        }

    }
}
