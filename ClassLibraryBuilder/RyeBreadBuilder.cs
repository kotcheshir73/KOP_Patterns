using ClassLibraryAttribute;

namespace ClassLibraryBuilder
{
    [ClassAttributeDescribe(Describe = "Cтроитель для ржаного хлеба")]
    public class RyeBreadBuilder : BreadBuilder
    {
        [ClassAttributeDescribe(Describe = "не используется")]
        public override void SetWheatFlour()
        {
            // не используется
        }

        public override void SetRyeFlour()
        {
            this.Bread.RyeFlour = new Flour { Sort = "1 сорт" };
        }

        public override void SetSalt()
        {
            this.Bread.Salt = new Salt();
        }

        [ClassAttributeDescribe(Describe = "не используется")]
        public override void SetAdditives()
        {
            // не используется
        }
    }
}
