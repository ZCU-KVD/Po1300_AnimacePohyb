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
		private List<Souradnice> SouradniceSeznam { get; } = new List<Souradnice>();

		private int AktualniPozice { get; set; } = -1;

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
		#endregion

		#region Metody
		public void PridejPozici(int pozX, int pozY, byte meritkoVProcentech, byte nepruhlednost)
		{
			var souradnice = new Souradnice(pozX,pozY,meritkoVProcentech,nepruhlednost);
			SouradniceSeznam.Add(souradnice);
		}

		public void Presun()
		{
			AktualniPozice++;
		}
		#endregion
	}
}
