using ClassLibraryAttribute;
using System.Text;

namespace ClassLibraryBuilder
{
    [ClassAttributeDescribe(Describe = "Класс, описывающий хлеб и его компоненты")]
    public class Bread
    {
        [ClassAttributeDescribe(Describe = "пшеничная мука")]
        public Flour WheatFlour { get; set; }

        [ClassAttributeDescribe(Describe = "ржаная мука")]
        public Flour RyeFlour { get; set; }

        [ClassAttributeDescribe(Describe = "соль")]
        public Salt Salt { get; set; }

        [ClassAttributeDescribe(Describe = "пищевые добавки")]
        public Additives Additives { get; set; }

        [ClassAttributeDescribe(Describe = "Главный метод, возвращает строку с описанием всех составляющих хлеба")]
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (WheatFlour != null)
            {
                sb.Append("Пшеничная мука " + WheatFlour.Sort + "\n");
            }
            if (RyeFlour != null)
            {
                sb.Append("Ржаная мука " + RyeFlour.Sort + " \n");
            }
            if (Salt != null)
            {
                sb.Append("Соль \n");
            }
            if (Additives != null)
            {
                sb.Append("Добавки: " + Additives.Name + " \n");
            }
            return sb.ToString();
        }
    }
}
