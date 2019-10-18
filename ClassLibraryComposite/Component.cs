using ClassLibraryAttribute;

using System.Text;

namespace ClassLibraryComposite
{
    [ClassAttributeDescribe(Describe = "Класс, описывающий элемент файловой системы (папку или файл)")]
    public abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }

        public virtual bool CheckNewName(string newName)
        {
            return name != newName;
        }

        public virtual void Add(Component component, string parentName) { }

        public virtual void Remove(string removeName) { }

        public virtual string Print(int level)
        {
            StringBuilder str = new StringBuilder();
            for(int i = 0; i < level; ++i)
            {
                str.Append("    ");
            }
            str.Append(name);
            return str.ToString();
        }
    }
}
