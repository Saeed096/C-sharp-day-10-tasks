using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal static class extensions
    {
        public static int reverse(this int num)
        {
            string old_num = num.ToString();    
            string new_num = "";
            int size = old_num.Length;
            for (int i = size-1; i >= 0; i--) 
            { 
              new_num += old_num[i];
            }
            return int.Parse(new_num);
        }


        public static int no_of_digit(this int num) 
        {
            string str_num = num.ToString();            
            return str_num.Length;
        } 

        public static string trim (this string str)
        {
            int size = str.Length;
            string new_str = "";

            for(int i = 0; i < size; i++) 
            {
                if (str[i] == ' ')
                    continue;
                else
                    new_str += str[i];  
            }
            return new_str;
        }


        public static int get_max (this IEnumerable<int> ints)
        {
            int temp = ints.First();
            foreach(int i in ints)
            {
                if(i > temp)
                {
                    temp = i;
                }
            }
            return temp;
        }


        public static T generic_get_max<T>(this IEnumerable<T> list) where T : IComparable<T>
        {
           T temp = list.First();
            foreach (T t in list)
            {
                if (t.CompareTo(temp) > 0)
                {
                    temp = t;
                }
            }
            return temp;
        }
    }
}
