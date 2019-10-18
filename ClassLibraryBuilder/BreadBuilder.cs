using ClassLibraryAttribute;

namespace ClassLibraryBuilder
{
    [ClassAttributeDescribe(Describe = "Абстрактный класс, задающий ингредиенты для изготовления хлеба")]
    public abstract class BreadBuilder
    {
        public Bread Bread { get; private set; }
        
        [ClassAttributeDescribe(Describe = "Задать объект хлеб")]
        public void CreateBread()
        {
            Bread = new Bread();
        }

        [ClassAttributeDescribe(Describe = "Задать объект для пшеничной муки")]
        public abstract void SetWheatFlour();

        [ClassAttributeDescribe(Describe = "Задать объект для ржаной муки")]
        public abstract void SetRyeFlour();

        [ClassAttributeDescribe(Describe = "Задать объект для соли")]
        public abstract void SetSalt();

        [ClassAttributeDescribe(Describe = "Задать объект для пищевых добавок")]
        public abstract void SetAdditives();
    }
}
