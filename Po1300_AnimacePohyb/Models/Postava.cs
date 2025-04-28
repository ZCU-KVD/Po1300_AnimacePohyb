namespace Po1300_AnimacePohyb.Models
{
	public class Postava
	{
		public Postava(string jmeno, string obrazek, int width)
		{
			Jmeno = jmeno;
			Obrazek = obrazek;
			Width = width;
		}
		#region Atributy
		public string Jmeno { get;  }
		public string Obrazek { get; }
		private int Width { get; }
		private bool smerVpred = true; 
		private bool HlavaVpravo = true; 
		private List<Souradnice> SouradniceSeznam { get; } = new List<Souradnice>();

		public int AktualniPozice { get; private set; } = -1;

		public string Style 
		{
			get
			{
				if (AktualniPozice < 0)
				{
					return $"width:{Width}px;";
				}
				else
				{ 
					var pozice = SouradniceSeznam[AktualniPozice];
					return $"{pozice.Style} width:{Width * pozice.MeritkoVProcentech / 100}px;";
				}
			}
		}

		public string TransformRotateY => HlavaVpravo ? "transform: rotateY(0deg);" : "transform: rotateY(180deg);";
		#endregion

		#region Metody
		public void PridejPozici(int pozX, int pozY, byte meritkoVProcentech, byte nepruhlednost)
		{
			var souradnice = new Souradnice(pozX,pozY,meritkoVProcentech,nepruhlednost);
			SouradniceSeznam.Add(souradnice);
		}

		public void Presun()
		{
			if (smerVpred)
			{
				if(AktualniPozice == SouradniceSeznam.Count - 1)
				{
					smerVpred = false;
				}
			}
			else
			{
				if (AktualniPozice == 0)
				{
					smerVpred = true;
				}
			}
			var predchoziPozice = AktualniPozice;

			AktualniPozice += smerVpred? 1 : -1 ;
			if (predchoziPozice >=0)
				HlavaVpravo = SouradniceSeznam[AktualniPozice].PozX > SouradniceSeznam[predchoziPozice].PozX;

		}
		#endregion
	}
}
