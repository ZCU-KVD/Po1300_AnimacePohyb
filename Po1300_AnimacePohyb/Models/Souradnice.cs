namespace Po1300_AnimacePohyb.Models
{
	public class Souradnice
	{
		public Souradnice(int pozX, int pozY, byte meritkoVProcentech, byte nepruhlednost)
		{
			PozX = pozX;
			PozY = pozY;
			MeritkoVProcentech = meritkoVProcentech;
			Nepruhlednost = nepruhlednost;
		}

		public int PozX { get; }
		public int PozY { get; }
		public byte MeritkoVProcentech { get; }
		public byte Nepruhlednost { get; }

		public string Style
		{
			get
			{
				return $"left: {PozX}px; top: {PozY}px; opacity: {Nepruhlednost / 100.0};";
			}
		}
	}
}
