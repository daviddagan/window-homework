using System;
namespace BE
{
	public class Flower
	{
		public string Name { get; set; }
		public int Id { get; set; }


		public Flower() { }

		public Flower(Flower copy)
		{
			Name = copy.Name;
			Id = copy.Id;
		}

		public override string ToString()
		{
			return "ID: " + this.Id + ", Name: " + this.Name + "/n";
		}
	}

}