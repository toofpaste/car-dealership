using System;
namespace Dealership
{
    class Car
    {
        private string Model;
        private int Price;
        private int Miles;

        public Car(string model, int price, int miles)
        {
            Model = model;
            Price = price;
            Miles = miles;
        }
        public bool CheckPrice(int price)
        {
            return (price > Price);
        }
        public string getModel()
        {
            return Model;
        }
        public int getPrice()
        {
            return Price;
        }
        public int getMile()
        {
            return Miles;
        }
        public void SetPrice(int price)
        {
            Price = price;
        }
    }
}
