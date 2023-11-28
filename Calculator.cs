using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_SQA
{
    public class Calculator
    {
        public Calculator() {
                
        }
        public int add_integers(int integer1, int integer2)
        {
            int result = integer1 + integer2;
            return result;
        }

        public double add_doubles(double double1, double double2)
        {
            double result = double1 + double2;
            return result;
        }

        public float add_floats(float float1, float float2)
        {
            float result = float1 + float2;
            return result;
        }

        public int subtract_integers(int integer1, int integer2)
        {
            int result = integer1 - integer2;
            return result;
        }

        public double subtract_doubles(double double1, double double2)
        {
            double result = double1 - double2;
            return result;
        }

        public float subtract_floats(float float1, float float2)
        {
            float result = float1 - float2;
            return result;
        }

        public int multiply_integers(int integer1, int integer2)
        {
            int result = integer1 * integer2;
            return result;
        }

        public double multiply_doubles(double double1, double double2)
        {
            double result = double1 * double2;
            return result;
        }

        public float multiply_floats(float float1, float float2)
        {
            float result = float1 * float2;
            return result;
        }

        public int divide_integers(int integer1, int integer2)
        {
            int result = integer1 / integer2;
            return result;
        }

        public double divide_doubles(double double1, double double2)
        {
            double result = double1 / double2;
            return result;
        }

        public float divide_floats(float float1, float float2)
        {
            float result = float1 / float2;
            return result;
        }

        public int divide_by_zero(int int1, int int2)
        {
            if (int2 == 0)
            {
                throw new DivideByZeroException("Can not divide by zero.");
            }

            int result = int1 / int2;

            return result;
        }

        public double divide_by_zero(double double1, double double2)
        {
            if(double2 == 0)
            {
                throw new DivideByZeroException("Can not divide by zero.");
            }

            double result = double1 / double2;

            return result;
        }
    }
}
