using System;
using BE;
using System.Collections.Generic;

public interface IBL
{
	 void AddFlower(Flower flower);//function to add a speciality to the XML file by the DAL layer
	 void DeleteFlower(int flowerID);//function to delete a speciality to the XML file by the DAL layer
	 void UpdatingFlower(Flower flower);//function to update a speciality to the XML file by the DAL layer
     List <Flower> search(string name);
}
