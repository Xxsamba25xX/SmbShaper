using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SmbImager.UTILS
{
	public static class Extensions
	{
		public static Point Get(this Point me, Cardinals cardinal)
		{
			switch (cardinal)
			{
				case Cardinals.N:
					return new Point(me.X, me.Y - 1);
					break;
				case Cardinals.NE:
					return new Point(me.X + 1, me.Y - 1);
					break;
				case Cardinals.E:
					return new Point(me.X + 1, me.Y);
					break;
				case Cardinals.SE:
					return new Point(me.X + 1, me.Y + 1);
					break;
				case Cardinals.S:
					return new Point(me.X, me.Y + 1);
					break;
				case Cardinals.SO:
					return new Point(me.X - 1, me.Y + 1);
					break;
				case Cardinals.O:
					return new Point(me.X - 1, me.Y);
					break;
				case Cardinals.NO:
					return new Point(me.X - 1, me.Y - 1);
					break;
				default:
					return me;
					break;
			}
		}
	}
}
