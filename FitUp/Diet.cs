using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Diet:BaseEntity
    {
        private Food iDFood;
        private Members iDMember;
        private DateTime mealTime;

        public Food IDFood { get => iDFood; set => iDFood = value; }
        public Members IDMember { get => iDMember; set => iDMember = value; }
        public DateTime MealTime { get => mealTime; set => mealTime = value; }
    }
}
