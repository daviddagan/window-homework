using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BE;

namespace DAL
{
    class DAL_XML : IDAL
    {
        XElement FlowerRoot;
        string FlowerPath = @"FlowerXML.xml";

        private void LoadFlowerFile()
        {
            try
            {
                FlowerRoot = XElement.Load(FlowerPath);
            }
            catch
            {
                throw new Exception("Flower File upload has a problem");
            }
        }
        public void AddFlower(Flower flower)
        {
            LoadFlowerFile();
            if (GetFlower(flower.ID) != null)
            {
                throw new Exception("Employee with the same ID already exist");
            }
            FlowerRoot.Add(ConvertFlowerToXElement(flower));
            FlowerRoot.Save(FlowerPath);
        }
        public Flower GetFlower(int FlowerID)
        {
            LoadFlowerFile();
            XElement element = null;
            try
            {
                element = (from item in FlowerRoot.Elements()
                           where item.Element("ID").Value == FlowerID.ToString()
                           select item).First();
            }
            catch (Exception)
            {
                return null;
            }
            return ConvertXElementToFlower(element);
        }
        private Flower ConvertXElementToFlower(XElement element)
        {
            Flower flower = new Flower();

            flower.ID = Convert.ToInt32(element.Element("ID").Value);
            flower.Name = element.Element("Name").Value;
            flower.description = element.Element("description").Value;
            flower.growthArea = element.Element("growthArea").Value;
            flower.Color = element.Element("Color").Value;

            return flower;
        }
        private XElement ConvertFlowerToXElement(Flower flower)
        {
            XElement FlowerElement = new XElement("Flower",

                new XElement("ID", flower.ID),
                new XElement("Name", flower.Name),
                new XElement("description", flower.description),
                new XElement("growthArea", flower.growthArea),
                new XElement("Color", flower.Color)
                );

            return FlowerElement;
        }
        public void DeleteFlower(int FlowerID)
        {
            LoadFlowerFile();
            XElement FlowerRemoveElement =
                                (from item in FlowerRoot.Elements()
                                 where Convert.ToInt32(item.Element("ID").Value) == FlowerID
                                 select item)
                                .FirstOrDefault();
            if (FlowerRemoveElement == null)
                throw new Exception("Employee with the same ID not found");

            FlowerRemoveElement.Remove();
            FlowerRoot.Save(FlowerPath);
        }

        public void UpdateFlower(Flower flower)
        {
            LoadFlowerFile();
            XElement FlowerUpdateElement =
                                (from item in FlowerRoot.Elements()
                                 where Convert.ToInt32(item.Element("ID").Value) == flower.ID
                                 select item)
                                .FirstOrDefault();
            if (FlowerUpdateElement == null)
                throw new Exception("Employee with the same ID not found");

            FlowerUpdateElement.ReplaceWith(ConvertFlowerToXElement(flower));

            FlowerRoot.Save(FlowerPath);
            }
    }
}
