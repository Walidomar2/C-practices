using System;

namespace App
{
    public class IP
    {
        private int[] _segments = new int[4];

        public int this [int index]
        {
            get
            {
                return _segments[index];
            }
            set
            {
                _segments[index] = value;
            }
        }

        public IP(string address)
        {
            var segs = address.Split(".");

            for(var i=0;i<segs.Length;i++)
            {
                _segments[i] = int.Parse(segs[i]);
            }
        }

        public IP(int segment1, int segment2, int segment3, int segment4)
        {
            _segments[0] = segment1;
            _segments[1] = segment2;
            _segments[2] = segment3;
            _segments[3] = segment4;
        }

        public string IPAddress => string.Join(".", _segments);
    }
}
