using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinTallLibrary
{
    public class BinTall
    {
        string binaryString;
        int decimalNum;

        public BinTall(string binaryString)
        {
            this.binaryString = binaryString;
            this.decimalNum = Convert.ToInt32(binaryString);
        }

        public BinTall(int decimalNum)
        {
            this.decimalNum = decimalNum;
            this.binaryString = Convert.ToString(decimalNum, 2);
        }

        bool IsBinary(string binaryString)
        {
            foreach (var item in binaryString)
            {
                if (item != '0' && item != '1')
                {
                    return false;
                }
            }
            return true;
        }

        public int GetInt()
        {
            return Convert.ToInt32(this.binaryString,2);
        }

        public string GetString()
        {
            return Convert.ToString(this.decimalNum,2);
        }

        public static BinTall operator +(BinTall num1, BinTall num2)
        {
            int sum = num1.GetInt() + num2.GetInt();
            return new BinTall(sum);
        }


        public static BinTall operator -(BinTall num1, BinTall num2)
        {
            int sum = num1.GetInt() - num2.GetInt();
            return new BinTall(sum);
        }



        public static BinTall operator *(BinTall num1, BinTall num2)
        {
            int sum = num1.GetInt() * num2.GetInt();
            return new BinTall(sum);
        }



        public override string ToString()
        {
            return ($"Decimal value: {this.GetInt()}\nBinary value: {this.GetString()}");
        }

    }
}
