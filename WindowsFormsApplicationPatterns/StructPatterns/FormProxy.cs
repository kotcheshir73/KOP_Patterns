using ClassLibraryProxy;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormProxy : Form
    {
        BookStoreProxy proxy;

        public FormProxy()
        {
            InitializeComponent();
        }

        private void FormProxy_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Паттерн Заместитель (Proxy) предоставляет объект-заместитель, который управляет доступом к другому объекту. То есть создается объект-суррогат, который может выступать в роли другого объекта и замещать его.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Заместитель используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда надо осуществлять взаимодействие по сети, а объект-проси должен имитировать поведения объекта в другом адресном пространстве. Использование прокси позволяет снизить накладные издержки при передачи данных через сеть. Подобная ситуация еще называется ");
            dp.InsertText(richTextBoxDescribe, true, false, "удалённый заместитель (remote proxies).");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда нужно управлять доступом к ресурсу, создание которого требует больших затрат. Реальный объект создается только тогда, когда он действительно может понадобится, а до этого все запросы к нему обрабатывает прокси-объект. Подобная ситуация еще называется ");
            dp.InsertText(richTextBoxDescribe, true, false, "виртуальный заместитель (virtual proxies).");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда необходимо разграничить доступ к вызываемому объекту в зависимости от прав вызывающего объекта. Подобная ситуация еще называется ");
            dp.InsertText(richTextBoxDescribe, true, false, "защищающий заместитель (protection proxies).");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда нужно вести подсчет ссылок на объект или обеспечить потокобезопасную работу с реальным объектом. Подобная ситуация еще называется ");
            dp.InsertText(richTextBoxDescribe, true, false, "\"умные ссылки\" (smart reference).");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Subject:");
            dp.InsertText(richTextBoxDescribe, false, false, " определяет общий интерфейс для Proxy и RealSubject. Поэтому Proxy может использоваться вместо RealSubject.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- RealSubject:");
            dp.InsertText(richTextBoxDescribe, false, false, " представляет реальный объект, для которого создается прокси.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Proxy:");
            dp.InsertText(richTextBoxDescribe, false, false, " заместитель реального объекта. Хранит ссылку на реальный объект, контролирует к нему доступ, может управлять его созданием и удалением. При необходимости Proxy переадресует запросы объекту RealSubject.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Client:");
            dp.InsertText(richTextBoxDescribe, false, false, " использует объект Proxy для доступа к объекту RealSubject");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(Page), typeof(PageContext), typeof(IBook), typeof(BookStore), typeof(BookStoreProxy) }, richTextBoxClass);
        }

        private void Example()
        {
            proxy = new BookStoreProxy();
        }

        private void buttonLoadPage_Click(object sender, EventArgs e)
        {
            if(textBoxNumber.Text != "")
            {
                DateTime start = DateTime.Now;
                var page = proxy.GetPage(Convert.ToInt32(textBoxNumber.Text));
                if(page != null)
                {
                    richTextBoxPage.AppendText(page.Text + "\n");
                    listBoxTime.Items.Add("Время загрузки страницы №" + page.Number + " = " + (DateTime.Now - start).TotalSeconds);
                }
                else
                {
                    richTextBoxPage.AppendText("Страница не найдена\n");
                }
            }
        }
    }
}
