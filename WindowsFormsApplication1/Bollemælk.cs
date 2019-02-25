namespace WindowsFormsApplication1
{
	internal class Bollemælk
	{
		private Form1 form1;

		public Bollemælk(Form1 form)
		{
			form1 = form;
		}

		internal Juklas effectShow()
		{
			form1.burnRubber(850.0, 300f, 80);
			new Bongo(form1).viBønner(new Vanskning());
			return new Juklas(form1);
		}

		internal void TrinityJoyBomb(int p, int p_2, int p_3)
		{
			for (int i = 0; i < 1; i++)
			{
				new Spaceship1(form1);
				new Lingo(p, new Børnetid(new Afmagt(200.0, 5000f, form1), form1), 400, form1);
			}
		}
	}
}
