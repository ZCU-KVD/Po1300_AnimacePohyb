
namespace Po1300_AnimacePohyb.Pages
{
	public partial class Animace1
	{
		#region Udalosti formulare
		protected override void OnInitialized()
		{
			InicializaceHry();
		}

		protected override async Task OnAfterRenderAsync(bool firstRender)
		{
			if (firstRender)
			{
				// Spustí animaci
				await Task.Run(Postava.Presun);
				// Znovu vykreslí komponentu
				StateHasChanged();
			}
			await base.OnAfterRenderAsync(firstRender);
		}
		#endregion

		#region Atributy
		private Models.Postava Postava { get; set; }
		#endregion

		#region Metod
		private void InicializaceHry()
		{
			Postava = new Models.Postava("Maxipes","img/Pes.png",150);
			Postava.PridejPozici(pozX: 45, pozY: 300, meritkoVProcentech: 70, nepruhlednost: 100);
			Postava.PridejPozici(pozX: 450, pozY: 270, meritkoVProcentech: 20, nepruhlednost: 100);
			Postava.PridejPozici(pozX: 840, pozY: 340, meritkoVProcentech: 80, nepruhlednost: 100);
			Postava.PridejPozici(pozX: 110, pozY: 430, meritkoVProcentech: 100, nepruhlednost: 100);
		}
		#endregion
	}
}
