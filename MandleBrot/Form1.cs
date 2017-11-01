using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace MandleBrot {
	public partial class Form1 : Form {
		private MandleBrotFactory mbf = new MandleBrotFactory();
		private JuliaSetFactory jsf = new JuliaSetFactory();
		private double offX = 0;
		private double offY = 0;
		private double scale = 4;
		private int maxIterations = 100;

		private bool useColor = false;

		private double realVal = -0.74543;
		private double imaginaryVal = 0.11301;

		private Bitmap bitmapMandle;
		private Bitmap[] bitmapMandleParts = new Bitmap[Environment.ProcessorCount];

		private bool auto = false;

		private bool useJulia = false;

		public Form1() {
			InitializeComponent();
			offXInput.Value = (decimal)offX;
			offYInput.Value = (decimal)offY;
			scaleInput.Value = (decimal)scale;
			realInput.Value = (decimal)realVal;
			imaginaryInput.Value = (decimal)imaginaryVal;

			bitmapMandle = new Bitmap(mandleBrotImageBox.Width, mandleBrotImageBox.Height);
			mandleBrotImageBox.Image = bitmapMandle;

			genImage();
		}

		private void genImagePart(object data) {
			//Function to draw part of the mandlebrot (thread)
			int part = (int)data;
			if (!useJulia)
				mbf.genMandlebrot(bitmapMandleParts[part], part, (double)offXInput.Value, (double)offYInput.Value, (double)scaleInput.Value, maxIterations, useColor);
			else
				jsf.genMandlebrot(bitmapMandleParts[part], part, (double)offXInput.Value, (double)offYInput.Value, (double)scaleInput.Value, maxIterations, realVal, imaginaryVal, useColor);
		}

		private void genImage() {
			//Multi-Threading was choosen because it will significantly improve speed

			//Create one thread per logical core
			int plcCount = Environment.ProcessorCount;
			//Create threads (same amount as logical cores)
			Thread[] mandleThreads = new Thread[plcCount];
			for (int i = 0; i < plcCount; i++) {
				bitmapMandleParts[i] = new Bitmap(mandleBrotImageBox.Width, mandleBrotImageBox.Height / plcCount);
				mandleThreads[i] = new Thread(genImagePart);
				//Use thread to caculate part of the fractal
				mandleThreads[i].Start(i);
			}
			//Create graphics from final bitmap to draw the parts to
			for (int j = 0; j < plcCount; j++) {
				//Join em cause you cant beat em
				mandleThreads[j].Join();
				//Reconstruct image
				for (int x = 0; x < bitmapMandle.Width; x++) {
					for (int y=0; y < bitmapMandleParts[j].Height; y++)
					bitmapMandle.SetPixel(x,y*plcCount+j, bitmapMandleParts[j].GetPixel(x,y));
				}
			}

			mandleBrotImageBox.Image = bitmapMandle; //Update ImageBox
		}


		//User interaction handlers
		private void scaleInput_ValueChanged(object sender, EventArgs e) {
			//Adjust offset movement speed to better allow for movement at higher zoom levels
			float offsetIncrementVal = (float)scaleInput.Value / 20;
			offXInput.Increment = (decimal)offsetIncrementVal;
			offYInput.Increment = (decimal)offsetIncrementVal;
			scaleInput.Increment = (decimal)scaleInput.Value / 4;

			if (auto)
				genImage();
		}

		private void maxIterationsInput_ValueChanged(object sender, EventArgs e) {
			maxIterations = (int)maxIterationsInput.Value;
			if (auto)
				genImage();
		}

		private void mandleBrotImageBox_Load(object sender, EventArgs e) {
			genImage();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e) {
			useJulia = juliaSetBoolInput.Checked;
			realInput.Enabled = useJulia;
			imaginaryInput.Enabled = useJulia;
			genImage();
		}

		private void realInput_ValueChanged(object sender, EventArgs e) {
			realVal = (double)realInput.Value;
			if (auto)
				genImage();
		}

		private void imaginaryInput_ValueChanged(object sender, EventArgs e) {
			imaginaryVal = (double)imaginaryInput.Value;
			if (auto)
				genImage();
		}

		private void button1_Click(object sender, EventArgs e) {
			genImage();
		}

		private void colorInput_CheckedChanged(object sender, EventArgs e) {
			useColor = !useColor;
			if (auto)
				genImage();
		}

		private void autoCheckbox_CheckedChanged(object sender, EventArgs e) {
			auto = autoCheckbox.Checked;
			button1.Enabled = !auto;
		}

		private void offXInput_ValueChanged(object sender, EventArgs e) {
			if (auto)
				genImage();
		}

		private void offYInput_ValueChanged(object sender, EventArgs e) {
			if (auto)
				genImage();
		}

		private void mandleBrotImageBox_Click(object sender, EventArgs e) {
			MouseEventArgs mea = (MouseEventArgs)e;
			Point pos = mea.Location;;
			//Scale ftom -1 to 1
			//Do it times 1/2 scale
			double x = (double)pos.X / (mandleBrotImageBox.Width / (double)scaleInput.Value) - (double)scaleInput.Value / 2 + (double)offXInput.Value;
			double y = (double)pos.Y / (mandleBrotImageBox.Height / (double)scaleInput.Value) - (double)scaleInput.Value / 2 - (double)offYInput.Value;
			offXInput.Value = (decimal)x;
			offYInput.Value = (decimal)-y;
			scaleInput.Value = (decimal)(scaleInput.Value / 2);
			genImage();
		}
	}
}
