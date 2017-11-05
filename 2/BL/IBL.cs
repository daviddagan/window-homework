using System;
using BE;

public interface IBL
{
	void AddFlower(Flower fl);//function to add a speciality to the XML file by the DAL layer
	void DeleteFlower(Flower fl);//function to delete a speciality to the XML file by the DAL layer
	void UpdatingFlower(Flower fl);//function to update a speciality to the XML file by the DAL layer
}
