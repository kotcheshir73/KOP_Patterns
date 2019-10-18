using System;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        #region BehaviorPatterns

        private void buttonChainOfResponsibility_Click(object sender, EventArgs e)
        {
            (new FormChainOfResponsibility()).Show();
        }

        private void buttonCommand_Click(object sender, EventArgs e)
        {
            (new FormCommand()).Show();
        }

        private void buttonInterpreter_Click(object sender, EventArgs e)
        {
            (new FormInterpreter()).Show();
        }

        private void buttonIterator_Click(object sender, EventArgs e)
        {
            (new FormIterator()).Show();
        }

        private void buttonMediator_Click(object sender, EventArgs e)
        {
            (new FormMediator()).Show();
        }

        private void buttonMemento_Click(object sender, EventArgs e)
        {
            (new FormMemento()).Show();
        }

        private void buttonObserver_Click(object sender, EventArgs e)
        {
            (new FormObserver()).Show();
        }

        private void buttonState_Click(object sender, EventArgs e)
        {
            (new FormState()).Show();
        }

        private void buttonStrategy_Click(object sender, EventArgs e)
        {
            (new FormStrategy()).Show();
        }

        private void buttonTemplateMethod_Click(object sender, EventArgs e)
        {
            (new FormTemplateMethod()).Show();
        }

        private void buttonVisitor_Click(object sender, EventArgs e)
        {
            (new FormVisitor()).Show();
        }
        #endregion

        #region Generic patterns

        private void buttonAbstractFactory_Click(object sender, EventArgs e)
        {
            (new FormAbstractFactory()).Show();
        }

        private void buttonBuilder_Click(object sender, EventArgs e)
        {
            (new FormBuilder()).Show();
        }

        private void buttonFactoryMethod_Click(object sender, EventArgs e)
        {
            (new FormFactoryMethod()).Show();
        }

        private void buttonPrototype_Click(object sender, EventArgs e)
        {
            (new FormPrototype()).Show();
        }

        private void buttonSingleton_Click(object sender, EventArgs e)
        {
            (new FormSingleton()).Show();
        }

        #endregion

        #region Struct patterns

        private void buttonAdapter_Click(object sender, EventArgs e)
        {
            (new FormAdapter()).Show();
        }

        private void buttonBridge_Click(object sender, EventArgs e)
        {
            (new FormBridge()).Show();
        }

        private void buttonComposite_Click(object sender, EventArgs e)
        {
            (new FormComposite()).Show();
        }

        private void buttonDecorator_Click(object sender, EventArgs e)
        {
            (new FormDecorator()).Show();
        }

        private void buttonFacade_Click(object sender, EventArgs e)
        {
            (new FormFacade()).Show();
        }

        private void buttonFlyweight_Click(object sender, EventArgs e)
        {
            (new FormFlyweight()).Show();
        }

        private void buttonProxy_Click(object sender, EventArgs e)
        {
            (new FormProxy()).Show();
        }

        #endregion

        #region SOLID
        private void buttonS_Click(object sender, EventArgs e)
        {
            (new FormS()).Show();
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            (new FormO()).Show();
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            (new FormL()).Show();
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            (new FormI()).Show();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            (new FormD()).Show();
        }
        #endregion
    }
}
