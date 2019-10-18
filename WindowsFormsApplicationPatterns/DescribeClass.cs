using ClassLibraryAttribute;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    class DescribeClass
    {
        SetTextInRichTextBox st;

        public void MakeDescribe(List<Type> types, RichTextBox rich)
        {
            st = new SetTextInRichTextBox();
            foreach(var t in types)
            {
                GetDescribeClass(t, rich);
            }
        }

        private void GetDescribeClass(Type type, RichTextBox rich)
        {
            //атриубты у класса
            var attrs = Attribute.GetCustomAttributes(type);
            foreach (var attr in attrs)
            {
                if (attr is ClassAttributeDescribe)
                {
                    st.InsertText(rich, false, false, string.Format("///    {0}\n", (attr as ClassAttributeDescribe).Describe));
                }
            }
            //название класса
            st.InsertText(rich, true, true, type.Name);
            //интерфейсы класса
            var interfaces = type.GetInterfaces();
            if (interfaces.Length > 0)
            {
                st.InsertText(rich, true, false, "\nИнтерфейсы:");
                foreach (var inter in interfaces)
                {
                    st.InsertText(rich, false, false, string.Format("\n--> {0}", inter.Name));
                    //DescribeClass(type.GetInterface(inter.Name), rich);
                }
            }
            //родительский класс
            var baseType = type.BaseType;
            if (baseType != null && baseType?.Name != "Object")
            {
                st.InsertText(rich, true, false, "\nРодительский класс:");
                if (baseType.IsAbstract)
                {
                    st.InsertText(rich, false, false, string.Format(" абстрактный класс {0}", baseType.Name));
                }
                else
                {
                    st.InsertText(rich, false, false, string.Format(" класс {0}", baseType.Name));
                }
            }
            //поля класса
            var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
            if (fields.Length > 0)
            {
                st.InsertText(rich, false, true, "\nПоля:");
                foreach (var field in fields)
                {
                    //атрибуты у поля
                    attrs = Attribute.GetCustomAttributes(field);
                    foreach (var attr in attrs)
                    {
                        if (attr is ClassAttributeDescribe)
                        {
                            st.InsertText(rich, false, false, string.Format("\n///    {0}", (attr as ClassAttributeDescribe).Describe));
                        }
                    }
                    //мдофик. доступа, тип данных, название поля
                    st.InsertText(rich, false, false, string.Format("\n--> {0} {1} {2}", ModificatorAccess(field), field.FieldType.Name, field.Name));
                }
            }
            //конструкторы
            var constructs = type.GetConstructors(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
            if (constructs.Length > 0)
            {
                st.InsertText(rich, false, true, "\nКонструкторы:");
                foreach (var construct in constructs)
                {
                    //атрибуты
                    attrs = Attribute.GetCustomAttributes(construct);
                    foreach (var attr in attrs)
                    {
                        if (attr is ClassAttributeDescribe)
                        {
                            st.InsertText(rich, false, false, string.Format("\n///    {0}", (attr as ClassAttributeDescribe).Describe));
                        }
                    }
                    //модиф. доступа и название
                    st.InsertText(rich, false, false, string.Format("\n--> {0} {1}(", ModificatorAccess(construct), construct.Name));
                    //передаваемые параметры
                    var paramsMethods = construct.GetParameters();
                    for (int i = 0; i < paramsMethods.Length; ++i)
                    {
                        //тип данных, название переменной
                        st.InsertText(rich, false, false, string.Format("{0} {1}", paramsMethods[i].ParameterType.Name, paramsMethods[i].Name));
                        if (i < paramsMethods.Length - 1)
                        {
                            st.InsertText(rich, false, false, ", ");
                        }
                    }
                    st.InsertText(rich, false, false, ")");
                }
            }
            //методы класса
            var methods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
            if (methods.Length > 0)
            {
                st.InsertText(rich, false, true, "\nМетоды:");
                foreach (var method in methods)
                {
                    if (method.DeclaringType.Name != "Object")
                    {//если метод не унаследован от Object
                        //атрибуты
                        attrs = Attribute.GetCustomAttributes(method);
                        foreach (var attr in attrs)
                        {
                            if (attr is ClassAttributeDescribe)
                            {
                                st.InsertText(rich, false, false, string.Format("\n///    {0}", (attr as ClassAttributeDescribe).Describe));
                            }
                        }
                        //модиф. доступа и название
                        st.InsertText(rich, false, false, string.Format("\n--> {0} {1} {2}(", ModificatorAccess(method), method.ReturnType.Name, method.Name));
                        //передаваемые параметры
                        var paramsMethods = method.GetParameters();
                        for (int i = 0; i < paramsMethods.Length; ++i)
                        {
                            //тип данных, название переменной
                            st.InsertText(rich, false, false, string.Format("{0} {1}", paramsMethods[i].ParameterType.Name, paramsMethods[i].Name));
                            if (i < paramsMethods.Length - 1)
                            {
                                st.InsertText(rich, false, false, ", ");
                            }
                        }
                        st.InsertText(rich, false, false, ")");
                    }
                }
            }
            st.InsertText(rich, false, false, "\n\n");
        }

        private string ModificatorAccess(FieldInfo field)
        {
            string modif = "";
            if (field.IsPrivate)
            {
                modif = "private";
            }
            else if (field.IsPublic)
            {
                modif = "public";
            }
            else if (field.IsFamily)
            {
                modif = "protected";
            }

            if (field.IsStatic)
            {
                modif += " static";
            }
            return modif;
        }

        private string ModificatorAccess(MethodInfo method)
        {
            string modif = "";
            if (method.IsPrivate)
            {
                modif = "private";
            }
            else if (method.IsPublic)
            {
                modif = "public";
            }
            else if (method.IsFamily)
            {
                modif = "protected";
            }

            if (method.IsStatic)
            {
                modif += " static";
            }
            return modif;
        }

        private string ModificatorAccess(ConstructorInfo method)
        {
            string modif = "";
            if (method.IsPrivate)
            {
                modif = "private";
            }
            else if (method.IsPublic)
            {
                modif = "public";
            }
            else if (method.IsFamily)
            {
                modif = "protected";
            }

            if (method.IsStatic)
            {
                modif += " static";
            }
            return modif;
        }
    }
}
