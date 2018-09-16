using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SmbImager.UTILS
{
    public static class Extensions
    {
        public static Point Get(this Point me, Cardinal cardinal)
        {
            switch (cardinal)
            {
                case Cardinal.N:
                    return new Point(me.X, me.Y - 1);
                    break;
                case Cardinal.NE:
                    return new Point(me.X + 1, me.Y - 1);
                    break;
                case Cardinal.E:
                    return new Point(me.X + 1, me.Y);
                    break;
                case Cardinal.SE:
                    return new Point(me.X + 1, me.Y + 1);
                    break;
                case Cardinal.S:
                    return new Point(me.X, me.Y + 1);
                    break;
                case Cardinal.SO:
                    return new Point(me.X - 1, me.Y + 1);
                    break;
                case Cardinal.O:
                    return new Point(me.X - 1, me.Y);
                    break;
                case Cardinal.NO:
                    return new Point(me.X - 1, me.Y - 1);
                    break;
                default:
                    return me;
                    break;
            }
        }

        public static Cardinal GetCardinal(this Point me, Point other)
        {
            for (int i = 0; i < 8; i++)
            {
                if (other == me.Get((Cardinal)i)) return (Cardinal)i;
            }
            throw new Exception("Se intentó obtener un cardinal inexistente");
        }
    }
}
