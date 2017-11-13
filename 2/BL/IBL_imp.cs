using System;
using BE;
using DAL;
using System.Collections.Generic;

public class IBL_imp : IBL
{
    IDAL dal = DAL_Factory.getDAL();
    public void AddFlower(Flower flower)
    {
        dal.AddFlower(flower);
    }

    public void DeleteFlower(int flowerID)
    {
        dal.DeleteFlower(flowerID);
    }

    public void UpdatingFlower(Flower flower)
    {
        dal.UpdateFlower(flower);
    }
    public List<Flower> search(string name)
    {
        List<Flower> listFlowers = dal.search(name);
        if (listFlowers == null)
            throw new Exception("The name" + name + "not found in the memory");
        return listFlowers;
    }
}
