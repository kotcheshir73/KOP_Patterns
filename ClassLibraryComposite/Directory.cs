using ClassLibraryAttribute;

using System.Collections.Generic;
using System.Text;

namespace ClassLibraryComposite
{
    [ClassAttributeDescribe(Describe = "Класс, описывающий папку файловой системы (Composite)")]
    public class Directory : Component
    {
        [ClassAttributeDescribe(Describe = "Файлы и папки, входящие в эту папку")]
        private List<Component> components = new List<Component>();

        public Directory(string name)
            : base(name)
        {
        }

        public override bool CheckNewName(string newName)
        {
            if(name == newName)
            {
                return false;
            }
            foreach (var comp in components)
            {
                if(!comp.CheckNewName(newName))
                {
                    return false;
                }
            }
            return true;
        }

        public override void Add(Component component, string parentName)
        {
            if (name == parentName)
            {
                components.Add(component);
            }
            else
            {
                foreach(var comp in components)
                {
                    comp.Add(component, parentName);
                }
            }
        }

        public override void Remove(string removeName)
        {
            if(components.Exists(elem => elem.Name == removeName))
            {
                components.RemoveAll(elem => elem.Name == removeName);
            }
            else
            {
                foreach (var comp in components)
                {
                    comp.Remove(removeName);
                }
            }
        }

        public override string Print(int level)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < level; ++i)
            {
                str.Append("    ");
            }
            str.Append("Узел " + name + "\n");
            for (int i = 0; i < components.Count; i++)
            {
                str.Append(components[i].Print(level + 1));
            }
            return str.ToString();
        }
    }
}
