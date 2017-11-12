using System;
namespace BE
{
	public class Flower
	{
		public string Name { get; set; }
		public int Id { get; set; }
		public string growthArea { get; set; }
		public string description { get; set; }
		public string Color { get; set; }



		public Flower() { }

		public Flower(Flower copy)
		{
			Name = copy.Name;
			Id = copy.Id;
			growthArea = copy.growthArea;
			description = copy.description;
			Color = copy.Color;
		}

		public override string ToString()
		{
			return "ID: " + this.Id + ", Name: " + this.Name +
				   ", growthArea: " + this.growthArea +
				   ", description: " + this.description +
				   ", Color: " + this.Color + "/n";
		}
	}

}