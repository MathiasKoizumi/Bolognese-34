using System.Drawing;

namespace WindowsFormsApplication1
{
	internal class Jonga
	{
		private int p;

		private Form1 form1;

		public Jonga(int p, Form1 form1)
		{
			this.p = p;
			this.form1 = form1;
			form1.Explosionshow(20, new Rectangle(form1.junkie.Next(form1.ClientSize.Width), form1.junkie.Next(form1.ClientSize.Height), form1.junkie.Next(form1.ClientSize.Width), form1.junkie.Next(form1.ClientSize.Height)));
		}

		internal int getNumbing(int p)
		{
			return p + 1000;
		}
	}
}
