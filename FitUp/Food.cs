using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Food:BaseEntity
    {
        private string foodName;
        private int calories;
        private int proteins;
        private int carbohydrates;
        private string imageLink;

        public string FoodName { get => foodName; set => foodName = value; }
        public int Calories { get => calories; set => calories = value; }
        public int Proteins { get => proteins; set => proteins = value; }
        public int Carbohydrates { get => carbohydrates; set => carbohydrates = value; }
        public string ImageLink { get => imageLink; set => imageLink = value; }
    }
}
