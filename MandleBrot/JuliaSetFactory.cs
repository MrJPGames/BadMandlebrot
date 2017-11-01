using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MandleBrot {
	class JuliaSetFactory { //Same lame joke (also still not actually a factory in the OO sense)
		private HSVtoColor hsv2col = new HSVtoColor(); //Converter object (HSV -> Color object)
		private int plcCount = Environment.ProcessorCount;

		//Scale is actual width/height
		public void genMandlebrot(Bitmap mandle, int part, double cenX, double cenY, double scale, int maxIterations, double c1, double c2, bool col) {
			int width = mandle.Width, height = mandle.Height;
			for (int x = 0; x < width; x++) {
				for (int y = 0; y < height; y++) {
					int iterations = getPositionVal((double)x / (width / scale) - scale / 2 + cenX, (double)(y*plcCount+part) / (height*plcCount / scale) - scale / 2 - cenY, c1, c2, maxIterations);
					double dval = (double)iterations / maxIterations;
					if (!col) dval = Math.Sin(dval * Math.PI * (double)0.5); //Exagerate low values and do the opposite for high numbers, gives smooth transitions.
					int val = (int)Math.Round(dval * (col == true ? 360*5 : 255)); //Scale to 0-360 for color (Hue) or to 0-255 for greyscale (R, G and B values)
					if (iterations != maxIterations)
						if (col)
							mandle.SetPixel(x, y, hsv2col.getColorFromHSV(val, 0.9, 0.9));
						else
							mandle.SetPixel(x, y, Color.FromArgb(val, val, val));
					else
						mandle.SetPixel(x, y, Color.FromArgb(0, 0, 0));
				}
			}
		}

		public int getPositionVal(double x, double y, double c1, double c2, int maxIterations) {
			int iterations = 1;
			double a = x;
			double b = y;
			for (; iterations < maxIterations; iterations++) {
				//Do function
				double olda = a;
				a = a * a - b * b + c1;
				b = 2 * olda * b + c2;

				//Faster than doing sqrt every time (and this gives the same result anyways)
				if (Math.Pow(a, 2) + Math.Pow(b, 2) > 4) {
					break;
				}

			}
			return iterations;
		}
	}
}
