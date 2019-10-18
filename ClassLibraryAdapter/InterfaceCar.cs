using ClassLibraryAttribute;

namespace ClassLibraryAdapter
{
    [ClassAttributeDescribe(Describe = "Интерфейс, предоставляющий функционал, имитиурющий перевозку людей из пункта А в пункт В.")]
    public interface InterfaceCar
    {
        string Move();
    }
}
