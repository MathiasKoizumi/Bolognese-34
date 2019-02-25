using System;
using System.Collections;

namespace WindowsFormsApplication1
{
	internal class Bongo
	{
		private ArrayList bongoClass;

		private int tihundrede;

		private int p;

		private Juklas komNær;

		private Tegneserie bif;

		private Movement møg;

		private Bollemælk bongi;

		private Form1 form1;

		public Bongo(Form1 form)
		{
			form1 = form;
			new Tegneserie(new JoyRomeo(form1), form1);
		}

		private void setPopulation(Jingo j)
		{
			bongoClass = populationControl(komNær, new Mood(form1), bif, new Token(), møg);
			j.getMom().getNumbers();
		}

		public ArrayList populationControl(Juklas j, Mood møg, Tegneserie k, Token q, Movement t)
		{
			møg.affectMood(4, j);
			while ((double)møg.getMood().GetBrightness() > 0.8)
			{
				møg.affectMood(4, j);
			}
			return new ArrayList();
		}

		internal void viBønner(Vanskning vanskning)
		{
			throw new NotImplementedException();
		}
	}
}
