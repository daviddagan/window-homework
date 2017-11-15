using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BE
{
	public class Flower
	{
		public string Name { get; set; }
        public int ID { get; set; }
        public string growthArea { get; set; }
        public string description { get; set; }
        public string Color { get; set; }
		BitmapImage Image { get; set; }


		public Flower(string n, int i, string g, string d, string c , BitmapImage Im)
        {
            Name = n;
            ID = i;
            growthArea = g;
            description = d;
            Color = c;
			Image = Im; 


		}
        public Flower() { }

        public Flower(Flower copy)
		{
			Name = copy.Name;
			ID = copy.ID;
			growthArea = copy.growthArea;
			description = copy.description;
			Color = copy.Color;
			Image = copy.Image;
		}

		public override string ToString()
		{
			return "ID: " + this.ID + ", Name: " + this.Name +
				   ", growthArea: " + this.growthArea +
				   ", description: " + this.description +
				   ", Color: " + this.Color + "/n";
		}
	}

}