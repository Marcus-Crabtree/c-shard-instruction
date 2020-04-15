using System;
using System.Collections.Generic;
using System.Text;

namespace CH07_Classes {
    class Product {
        public string Code { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product() {
            Code = "";
            Description = "";
            Price = 0.0;
        }
        public Product(string code, string desc, double price) {
            this.Code = code;
            this.Description = desc;
            this.Price = price;
        }

        public override string ToString() {
            return $"Product: code={Code}, description={Description}, price={Price}";
        }
    }
}
