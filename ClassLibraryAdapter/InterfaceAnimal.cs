using ClassLibraryAttribute;

namespace ClassLibraryAdapter
{
    [ClassAttributeDescribe(Describe = "новый интерфейс, предоставляющий функционал, имитиурющий перевозку людей из пункта А в пункт В на животном.")]
    public interface InterfaceAnimal
    {
        string Go();
    }
}
