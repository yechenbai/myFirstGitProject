using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class fushu
    {
        public double sb;
        public double xb;
        public fushu(double sb, double xb)
        {
            this.sb = sb;
            this.xb = xb;
        }
        public static fushu operator +(fushu a, fushu b)
        {
            return new fushu(a.sb + b.sb, a.xb + b.xb);
        }
        public static fushu operator -(fushu a, fushu b)
        {
            return new fushu(a.sb - b.sb, a.xb - b.xb);
        }
        public static fushu operator *(fushu a, fushu b)
        {
            return new fushu(a.sb * b.sb + a.sb * b.xb, a.xb * b.sb + a.xb * b.xb);
        }
        public static fushu operator /(fushu a, fushu b)
        {
            return new fushu((a.sb * b.sb + a.xb * b.xb) / (b.sb * b.xb), (a.xb * b.sb - a.sb * b.xb) / (b.sb * b.xb));
        }
        public override string ToString()
        {
            return (String.Format("{0}+{1}i", sb, xb));
        }
    }
}
