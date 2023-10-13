using System;

namespace Lib_7
{
    public static class MathString
    {
        /// <summary>
        /// ��������������� �������. ��������: count/2 - count*2
        /// </summary>
        /// <param name="count">����� �����</param>
        /// <returns>������</returns>
        public static int[] Array(int count)
        {
            Random rnd = new Random();
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = rnd.Next(count / 2, count * 2);
            }
            return array;
        }

        /// <summary>
        /// ���������� ����� ����� �������, ������� ������ count
        /// </summary>
        /// <param name="numbers">������</param>
        /// 
        /// 
        public static int Sum(this int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers.Length)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }


        public static int Pr(this int[] numbers)
        {
            int pr = 1;
            for (int i = 0; i < numbers.Length; i++)
            {

                pr = pr * numbers[i];

            }
            return pr;
        }
    }
}
