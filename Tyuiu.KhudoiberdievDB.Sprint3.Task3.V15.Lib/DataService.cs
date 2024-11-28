﻿using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhudoiberdievDB.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {
            List<int> list = new List<int>();
            char prev = value[0];
            int count = 1;
            bool first = true;
            foreach (char chr in value)
            {
                if (first)
                {
                    first = false;
                    continue;
                }
                if (chr == item && prev == item)
                {
                    count++;
                    continue;
                }
                if (chr != item && prev == item)
                {
                    list.Add(count);
                    count = 1;
                }
                prev = chr;
            }
            return list.Where(i => i >= 1).Min();
        }

    }
}
