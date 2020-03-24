using System;
using static Pocket_pets_2._0.Utility;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_pets_2._0
{
    class Items
    {
        private string name;
        private int amount;
        private string amounttype;
        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Amounttype { get => amounttype; set => amounttype = value; }
        public float Value;

        public List<Items> gold = new List<Items>(); 

        public Items(string _name, int _amount, string _amounttype)
        {
            Name = _name;
            Amount = _amount;
            Amounttype = _amounttype;
        }
        public void GetGold()
        {
            gold.Add(new Items("Piece" , random.Next(201),"Gold"));
        }
    }
}
