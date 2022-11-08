using System;
namespace тортики
{
    public class tortiki
    {
        public string[] name;
        public int[] cost;

        public tortiki()
        {
        }

        public tortiki(string[] korobkastr, int[] korobkaint)
        {
            name = korobkastr;
            cost = korobkaint;
        }
    }
}