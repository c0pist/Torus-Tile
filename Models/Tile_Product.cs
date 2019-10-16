using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Torus_Tile.Models
{
    public class Tile_Product
    {

        public int id { get; set; }

        public string Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Price_Sqf { get; set; }
        
        public string imgUrl { get; set; }

        public Tile_Product() { }
        
        public Tile_Product(int id, string code, string name, double price, double price_sqf, string imgUrl)
        {
            this.id = id;
            this.Code = code;
            this.Name = name;
            this.Price = price;
            this.Price_Sqf = price_sqf;
            this.imgUrl = imgUrl;
        }
    }
}
