using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MandleBrot {
	class HSVtoColor {
		public Color getColorFromHSV(int h, double s, double v) {
			//Method of translation used can be found here: http://www.rapidtables.com/convert/color/hsv-to-rgb.htm
			h = h % 360;

			int R, G, B;
			double tR = 0.0, tG = 0.0, tB=0.0, C, X, m;

			C = v * s;
			X = C * (1 - Math.Abs(((double)h / 60) % 2 - 1));
			m = v - C;

			if (h < 60) {
				tR = C;
				tG = X;
			}else if (h < 120) {
				tR = X;
				tG = C;
			}else if (h < 180) {
				tG = C;
				tB = X;
			}else if (h < 240) {
				tG = X;
				tB = C;
			}else if (h < 300) {
				tR = X;
				tB = C;
			} else {
				tR = C;
				tB = X;
			}

			R = (int)((tR + m) * 255);
			G = (int)((tG + m) * 255);
			B = (int)((tB + m) * 255);

			return Color.FromArgb(R, G, B);
		}
	}
}
