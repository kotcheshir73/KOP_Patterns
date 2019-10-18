using ClassLibraryAttribute;
namespace ClassLibraryBuilder
{
    [ClassAttributeDescribe(Describe = "Cтроитель для ржаного хлеба")]
    public class WheatBreadBuilder : BreadBuilder
    {
        public override void SetWheatFlour()
        {
            this.Bread.WheatFlour = new Flour { Sort = "высший сорт" };
        }

        [ClassAttributeDescribe(Describe = "не используется")]
        public override void SetRyeFlour()
        {
            // не используется
        }

        public override void SetSalt()
        {
            this.Bread.Salt = new Salt();
        }

        public override void SetAdditives()
        {
            this.Bread.Additives = new Additives { Name = "улучшитель хлебопекарный" };
        }
    }
}
