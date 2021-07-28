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
        private const string literals = "abcdefghijklmnopqrstuvwxyz";


        //TODO - 

        public DataOut IntToLocationNumeral(int input)
        {

            DataOut output = new DataOut() { result = Models.Common.Result.error };
            try
            {
                var i = Convert.ToString(input, 2);
                //i = i.ToArray().Aggregate((x, y) => x ^ y  ) ;
                string response = GetLocationNumeralfromInt(input);

                output.output = response;
                output.result = Models.Common.Result.success;

            }
            catch (Exception e)
            {
                output.message = e.Message;
            }
            return output;
        }

        public DataOut LocationNumeralToInt(string input)
        {
            DataOut output = new DataOut() { result = Models.Common.Result.error };
            try
            {

                long response = GetIntegerFromLiteral(input);

                output.output = response.ToString();
                output.result = Models.Common.Result.success;

            }
            catch (Exception e)
            {
                output.message = e.Message;
            }
            return output;
        }

        public DataOut LocationNumeralToAbreviated(string input)
        {

            DataOut output = new DataOut() { result = Models.Common.Result.error };
            try
            {

                long preResponse = GetIntegerFromLiteral(input);
                string response = GetLocationNumeralfromInt(preResponse);

                output.output = response;
                output.result = Models.Common.Result.success;

            }
            catch (Exception e)
            {
                output.message = e.Message;
            }
            return output;
        }

        private string GetLocationNumeralfromInt(long input)
        {
            string bin = Convert.ToString(input, 2); //Converts the number into binary

            string result = ""; //Set result value in ""
            string[] arr = new string[(bin.Length / literals.Length) + 1]; //In order to handle number > than 67108864, it is required to split the whole binary number into some sub arrays

            for (int i = 0; i < arr.Length; i++) //Iterate new array length only
            {
                string newBin = ""; //Set a flag where we will store new binary value no greather than 26 length 1 / 0

                var tempArr = bin.Take((bin.Length > literals.Length) ? literals.Length : bin.Length).ToArray(); //take only subarray from the start to the defined length (Check inside validation, this works when binary length is greather than 26)
                
                Array.Reverse(tempArr); // It is necessary to invert the subarray, in this way, we will take into account the correct values from literals constant
                tempArr.ToList().ForEach(delegate (char a) //Iterate the subarray, in this way, depends on the length of binary number, we set or not ones in the whole new bin variable.
                {
                    if (bin.Length > literals.Length)
                    {
                        newBin += '1'; //We set 1 in the whole bin only when bin length > literals length
                    }
                    else
                    {
                        newBin += a;
                    }
                });


                arr[i] = newBin; //Add the new binary number to an specific position of the array line 83
                bin = bin.Substring(bin.Length - newBin.Length); // set again the value of BIN variable, to take into account only the left values.
            }

            foreach (string newbin in arr) //Iterate the array line 83 where there are new Binaries values
            {
                int control = 0; //Flag to determine the value of the index of literals constant

                while (control < newbin.Length)
                {
                    if (newbin[control] == '1')
                    {
                        result += literals[control]; //Concatenate  new string result
                    }

                    control++;
                }
            }


            return result;
        }

        private long GetIntegerFromLiteral(string input)
        {

            long result = 0; // It is necessary to use Base64 integer to handle big numbers

            foreach (char charInput in input)
            {
                var literalIndex = literals.IndexOf(charInput);
                result += (long)Math.Pow(2, literalIndex);
            }

            return result;
        }

    }
}
