using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MandleBrot {
	class MandleBrotFactory { //Lame joke (also no not actually a factory in the OO sense)
		private HSVtoColor hsv2col = new HSVtoColor();
		private int plcCount = Environment.ProcessorCount;


		//Scale is actual width/height
		public void genMandlebrot(Bitmap mandle, int part, double cenX, double cenY, double scale, int maxIterations, bool col) {
			int width = mandle.Width, height = mandle.Height;
			for (int x=0; x<width; x++) {
				for (int y=0; y<height; y++) {
					int iterations = getPositionVal((double)x/(width/scale)-scale/2+cenX, (double)(y*plcCount+part)/(height*plcCount/scale)-scale/2-cenY, maxIterations);
					double dval = (double)iterations / maxIterations;
					if (!col) dval = Math.Sin(dval * Math.PI * (double)0.5); //Exagerate low values and do the opposite for high numbers, gives smooth transitions.
					int val = (int)Math.Round(dval * (col == true ? 360*5 : 255)); //Scale to 0-360 (*5 to go though color space 5 times) for color (Hue) or to 0-255 for greyscale (R, G and B values)
					if (iterations != maxIterations) {
						if (col)
							mandle.SetPixel(x, y, hsv2col.getColorFromHSV(val, 0.9, 0.9));
						else
							mandle.SetPixel(x, y, Color.FromArgb(val, val, val));
					} else
						mandle.SetPixel(x, y, Color.FromArgb(0, 0, 0));
				}
			}
		}

		public int getPositionVal(double x, double y, int maxIterations) {
			int iterations = 1;
			double a = x, b = y;
			double powA, powB, olda;
			for (; iterations < maxIterations;	iterations++) {
				olda = a;
				powA = Math.Pow(a, 2);
				powB = Math.Pow(b, 2);
				a = powA - powB + x;
				b = 2 * olda * b + y;

				//Faster than doing sqrt every time (and this gives the same result anyways)
				if (powA + powB > 4) {
					break;
				}
			}
			return iterations;
		}
	}
}
