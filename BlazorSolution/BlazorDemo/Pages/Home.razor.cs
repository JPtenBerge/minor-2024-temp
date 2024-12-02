using BlazorDemo.Entities;

namespace BlazorDemo.Pages
{
	public partial class Home
	{
		public Plaats NewPlaats { get; set; } = new() {};

		public List<Plaats> Plaatsen { get; set; } =
		[
			new()
			{
				Id = 4,
				Name = "Utrecht",
				Rating = 10,
				PhotoUrl =
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQtrSNO3h43RFc0zGNjvvvB7FKYM3AhPGkfJg&s"
			},
			new()
			{
				Id = 8,
				Name = "Arnhem",
				Rating = 11,
				PhotoUrl =
					"https://www.holland.com/upload_mm/9/2/0/83998_fullimage_jansplaats%20arnhem%20met%20gezellige%20terrasjes%20%C2%A9%20%C2%A9%20photography%20jurjen%20drenth_1150x663.jpg"
			},
			new()
			{
				Id = 15,
				Name = "Bodegraven",
				Rating = 2,
				PhotoUrl =
					"https://assets.plaece.nl/thumb/ofmdi-CzmtQpNHMOCXNYzoXPgUMKzfggDSodcgqiuGQ/resizing_type:fit/width:640/height:0/gravity:sm/enlarge:0/aHR0cHM6Ly9hc3NldHMucGxhZWNlLm5sL2t1bWEtZ3JvZW5laGFydC91cGxvYWRzL21lZGlhLzVmMjdkYmViMzg2ZjIvZm9ydC13aWVyaWNrZXJzY2hhbnMuanBn.jpg"
			}
		];

		public void AddPlaats()
		{
			Plaatsen.Add(NewPlaats);
			NewPlaats = new();
		}

		public void VerhoogRating(Plaats plaats)
		{
			plaats.Rating += 2;
		}
	}
}