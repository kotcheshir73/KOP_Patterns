namespace WindowsFormsApplicationPatterns
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPrototype = new System.Windows.Forms.Button();
            this.buttonBuilder = new System.Windows.Forms.Button();
            this.buttonSingleton = new System.Windows.Forms.Button();
            this.buttonAbstractFactory = new System.Windows.Forms.Button();
            this.buttonFactoryMethod = new System.Windows.Forms.Button();
            this.buttonVisitor = new System.Windows.Forms.Button();
            this.buttonMemento = new System.Windows.Forms.Button();
            this.buttonMediator = new System.Windows.Forms.Button();
            this.buttonInterpreter = new System.Windows.Forms.Button();
            this.buttonChainOfResponsibility = new System.Windows.Forms.Button();
            this.buttonState = new System.Windows.Forms.Button();
            this.buttonIterator = new System.Windows.Forms.Button();
            this.buttonTemplateMethod = new System.Windows.Forms.Button();
            this.buttonCommand = new System.Windows.Forms.Button();
            this.buttonObserver = new System.Windows.Forms.Button();
            this.buttonStrategy = new System.Windows.Forms.Button();
            this.buttonProxy = new System.Windows.Forms.Button();
            this.buttonFlyweight = new System.Windows.Forms.Button();
            this.buttonFacade = new System.Windows.Forms.Button();
            this.buttonDecorator = new System.Windows.Forms.Button();
            this.buttonComposite = new System.Windows.Forms.Button();
            this.buttonBridge = new System.Windows.Forms.Button();
            this.buttonAdapter = new System.Windows.Forms.Button();
            this.groupBoxGeneric = new System.Windows.Forms.GroupBox();
            this.groupBoxBehavior = new System.Windows.Forms.GroupBox();
            this.groupBoxStruct = new System.Windows.Forms.GroupBox();
            this.groupBoxSOLID = new System.Windows.Forms.GroupBox();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.groupBoxGeneric.SuspendLayout();
            this.groupBoxBehavior.SuspendLayout();
            this.groupBoxStruct.SuspendLayout();
            this.groupBoxSOLID.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPrototype
            // 
            this.buttonPrototype.Location = new System.Drawing.Point(20, 180);
            this.buttonPrototype.Name = "buttonPrototype";
            this.buttonPrototype.Size = new System.Drawing.Size(150, 30);
            this.buttonPrototype.TabIndex = 3;
            this.buttonPrototype.Text = "Prototype";
            this.buttonPrototype.UseVisualStyleBackColor = true;
            this.buttonPrototype.Click += new System.EventHandler(this.buttonPrototype_Click);
            // 
            // buttonBuilder
            // 
            this.buttonBuilder.Location = new System.Drawing.Point(20, 80);
            this.buttonBuilder.Name = "buttonBuilder";
            this.buttonBuilder.Size = new System.Drawing.Size(150, 30);
            this.buttonBuilder.TabIndex = 1;
            this.buttonBuilder.Text = "Builder";
            this.buttonBuilder.UseVisualStyleBackColor = true;
            this.buttonBuilder.Click += new System.EventHandler(this.buttonBuilder_Click);
            // 
            // buttonSingleton
            // 
            this.buttonSingleton.Location = new System.Drawing.Point(20, 230);
            this.buttonSingleton.Name = "buttonSingleton";
            this.buttonSingleton.Size = new System.Drawing.Size(150, 30);
            this.buttonSingleton.TabIndex = 4;
            this.buttonSingleton.Text = "Singleton";
            this.buttonSingleton.UseVisualStyleBackColor = true;
            this.buttonSingleton.Click += new System.EventHandler(this.buttonSingleton_Click);
            // 
            // buttonAbstractFactory
            // 
            this.buttonAbstractFactory.Location = new System.Drawing.Point(20, 30);
            this.buttonAbstractFactory.Name = "buttonAbstractFactory";
            this.buttonAbstractFactory.Size = new System.Drawing.Size(150, 30);
            this.buttonAbstractFactory.TabIndex = 0;
            this.buttonAbstractFactory.Text = "Abstract Factory";
            this.buttonAbstractFactory.UseVisualStyleBackColor = true;
            this.buttonAbstractFactory.Click += new System.EventHandler(this.buttonAbstractFactory_Click);
            // 
            // buttonFactoryMethod
            // 
            this.buttonFactoryMethod.Location = new System.Drawing.Point(20, 130);
            this.buttonFactoryMethod.Name = "buttonFactoryMethod";
            this.buttonFactoryMethod.Size = new System.Drawing.Size(150, 30);
            this.buttonFactoryMethod.TabIndex = 2;
            this.buttonFactoryMethod.Text = "Factory Method";
            this.buttonFactoryMethod.UseVisualStyleBackColor = true;
            this.buttonFactoryMethod.Click += new System.EventHandler(this.buttonFactoryMethod_Click);
            // 
            // buttonVisitor
            // 
            this.buttonVisitor.Location = new System.Drawing.Point(20, 530);
            this.buttonVisitor.Name = "buttonVisitor";
            this.buttonVisitor.Size = new System.Drawing.Size(150, 30);
            this.buttonVisitor.TabIndex = 10;
            this.buttonVisitor.Text = "Visitor";
            this.buttonVisitor.UseVisualStyleBackColor = true;
            this.buttonVisitor.Click += new System.EventHandler(this.buttonVisitor_Click);
            // 
            // buttonMemento
            // 
            this.buttonMemento.Location = new System.Drawing.Point(20, 280);
            this.buttonMemento.Name = "buttonMemento";
            this.buttonMemento.Size = new System.Drawing.Size(150, 30);
            this.buttonMemento.TabIndex = 5;
            this.buttonMemento.Text = "Memento";
            this.buttonMemento.UseVisualStyleBackColor = true;
            this.buttonMemento.Click += new System.EventHandler(this.buttonMemento_Click);
            // 
            // buttonMediator
            // 
            this.buttonMediator.Location = new System.Drawing.Point(20, 230);
            this.buttonMediator.Name = "buttonMediator";
            this.buttonMediator.Size = new System.Drawing.Size(150, 30);
            this.buttonMediator.TabIndex = 4;
            this.buttonMediator.Text = "Mediator";
            this.buttonMediator.UseVisualStyleBackColor = true;
            this.buttonMediator.Click += new System.EventHandler(this.buttonMediator_Click);
            // 
            // buttonInterpreter
            // 
            this.buttonInterpreter.Location = new System.Drawing.Point(20, 130);
            this.buttonInterpreter.Name = "buttonInterpreter";
            this.buttonInterpreter.Size = new System.Drawing.Size(150, 30);
            this.buttonInterpreter.TabIndex = 2;
            this.buttonInterpreter.Text = "Interpreter";
            this.buttonInterpreter.UseVisualStyleBackColor = true;
            this.buttonInterpreter.Click += new System.EventHandler(this.buttonInterpreter_Click);
            // 
            // buttonChainOfResponsibility
            // 
            this.buttonChainOfResponsibility.Location = new System.Drawing.Point(20, 30);
            this.buttonChainOfResponsibility.Name = "buttonChainOfResponsibility";
            this.buttonChainOfResponsibility.Size = new System.Drawing.Size(150, 30);
            this.buttonChainOfResponsibility.TabIndex = 0;
            this.buttonChainOfResponsibility.Text = "Chain Of Responsibility";
            this.buttonChainOfResponsibility.UseVisualStyleBackColor = true;
            this.buttonChainOfResponsibility.Click += new System.EventHandler(this.buttonChainOfResponsibility_Click);
            // 
            // buttonState
            // 
            this.buttonState.Location = new System.Drawing.Point(20, 380);
            this.buttonState.Name = "buttonState";
            this.buttonState.Size = new System.Drawing.Size(150, 30);
            this.buttonState.TabIndex = 7;
            this.buttonState.Text = "State";
            this.buttonState.UseVisualStyleBackColor = true;
            this.buttonState.Click += new System.EventHandler(this.buttonState_Click);
            // 
            // buttonIterator
            // 
            this.buttonIterator.Location = new System.Drawing.Point(20, 180);
            this.buttonIterator.Name = "buttonIterator";
            this.buttonIterator.Size = new System.Drawing.Size(150, 30);
            this.buttonIterator.TabIndex = 3;
            this.buttonIterator.Text = "Iterator";
            this.buttonIterator.UseVisualStyleBackColor = true;
            this.buttonIterator.Click += new System.EventHandler(this.buttonIterator_Click);
            // 
            // buttonTemplateMethod
            // 
            this.buttonTemplateMethod.Location = new System.Drawing.Point(20, 480);
            this.buttonTemplateMethod.Name = "buttonTemplateMethod";
            this.buttonTemplateMethod.Size = new System.Drawing.Size(150, 30);
            this.buttonTemplateMethod.TabIndex = 9;
            this.buttonTemplateMethod.Text = "Template Method";
            this.buttonTemplateMethod.UseVisualStyleBackColor = true;
            this.buttonTemplateMethod.Click += new System.EventHandler(this.buttonTemplateMethod_Click);
            // 
            // buttonCommand
            // 
            this.buttonCommand.Location = new System.Drawing.Point(20, 80);
            this.buttonCommand.Name = "buttonCommand";
            this.buttonCommand.Size = new System.Drawing.Size(150, 30);
            this.buttonCommand.TabIndex = 1;
            this.buttonCommand.Text = "Command";
            this.buttonCommand.UseVisualStyleBackColor = true;
            this.buttonCommand.Click += new System.EventHandler(this.buttonCommand_Click);
            // 
            // buttonObserver
            // 
            this.buttonObserver.Location = new System.Drawing.Point(20, 330);
            this.buttonObserver.Name = "buttonObserver";
            this.buttonObserver.Size = new System.Drawing.Size(150, 30);
            this.buttonObserver.TabIndex = 6;
            this.buttonObserver.Text = "Observer";
            this.buttonObserver.UseVisualStyleBackColor = true;
            this.buttonObserver.Click += new System.EventHandler(this.buttonObserver_Click);
            // 
            // buttonStrategy
            // 
            this.buttonStrategy.Location = new System.Drawing.Point(20, 430);
            this.buttonStrategy.Name = "buttonStrategy";
            this.buttonStrategy.Size = new System.Drawing.Size(150, 30);
            this.buttonStrategy.TabIndex = 8;
            this.buttonStrategy.Text = "Strategy";
            this.buttonStrategy.UseVisualStyleBackColor = true;
            this.buttonStrategy.Click += new System.EventHandler(this.buttonStrategy_Click);
            // 
            // buttonProxy
            // 
            this.buttonProxy.Location = new System.Drawing.Point(20, 330);
            this.buttonProxy.Name = "buttonProxy";
            this.buttonProxy.Size = new System.Drawing.Size(150, 30);
            this.buttonProxy.TabIndex = 6;
            this.buttonProxy.Text = "Proxy";
            this.buttonProxy.UseVisualStyleBackColor = true;
            this.buttonProxy.Click += new System.EventHandler(this.buttonProxy_Click);
            // 
            // buttonFlyweight
            // 
            this.buttonFlyweight.Location = new System.Drawing.Point(20, 280);
            this.buttonFlyweight.Name = "buttonFlyweight";
            this.buttonFlyweight.Size = new System.Drawing.Size(150, 30);
            this.buttonFlyweight.TabIndex = 5;
            this.buttonFlyweight.Text = "Flyweight";
            this.buttonFlyweight.UseVisualStyleBackColor = true;
            this.buttonFlyweight.Click += new System.EventHandler(this.buttonFlyweight_Click);
            // 
            // buttonFacade
            // 
            this.buttonFacade.Location = new System.Drawing.Point(20, 230);
            this.buttonFacade.Name = "buttonFacade";
            this.buttonFacade.Size = new System.Drawing.Size(150, 30);
            this.buttonFacade.TabIndex = 4;
            this.buttonFacade.Text = "Facade";
            this.buttonFacade.UseVisualStyleBackColor = true;
            this.buttonFacade.Click += new System.EventHandler(this.buttonFacade_Click);
            // 
            // buttonDecorator
            // 
            this.buttonDecorator.Location = new System.Drawing.Point(20, 180);
            this.buttonDecorator.Name = "buttonDecorator";
            this.buttonDecorator.Size = new System.Drawing.Size(150, 30);
            this.buttonDecorator.TabIndex = 3;
            this.buttonDecorator.Text = "Decorator";
            this.buttonDecorator.UseVisualStyleBackColor = true;
            this.buttonDecorator.Click += new System.EventHandler(this.buttonDecorator_Click);
            // 
            // buttonComposite
            // 
            this.buttonComposite.Location = new System.Drawing.Point(20, 130);
            this.buttonComposite.Name = "buttonComposite";
            this.buttonComposite.Size = new System.Drawing.Size(150, 30);
            this.buttonComposite.TabIndex = 2;
            this.buttonComposite.Text = "Composite";
            this.buttonComposite.UseVisualStyleBackColor = true;
            this.buttonComposite.Click += new System.EventHandler(this.buttonComposite_Click);
            // 
            // buttonBridge
            // 
            this.buttonBridge.Location = new System.Drawing.Point(20, 80);
            this.buttonBridge.Name = "buttonBridge";
            this.buttonBridge.Size = new System.Drawing.Size(150, 30);
            this.buttonBridge.TabIndex = 1;
            this.buttonBridge.Text = "Bridge";
            this.buttonBridge.UseVisualStyleBackColor = true;
            this.buttonBridge.Click += new System.EventHandler(this.buttonBridge_Click);
            // 
            // buttonAdapter
            // 
            this.buttonAdapter.Location = new System.Drawing.Point(20, 30);
            this.buttonAdapter.Name = "buttonAdapter";
            this.buttonAdapter.Size = new System.Drawing.Size(150, 30);
            this.buttonAdapter.TabIndex = 0;
            this.buttonAdapter.Text = "Adapter";
            this.buttonAdapter.UseVisualStyleBackColor = true;
            this.buttonAdapter.Click += new System.EventHandler(this.buttonAdapter_Click);
            // 
            // groupBoxGeneric
            // 
            this.groupBoxGeneric.Controls.Add(this.buttonPrototype);
            this.groupBoxGeneric.Controls.Add(this.buttonAbstractFactory);
            this.groupBoxGeneric.Controls.Add(this.buttonBuilder);
            this.groupBoxGeneric.Controls.Add(this.buttonFactoryMethod);
            this.groupBoxGeneric.Controls.Add(this.buttonSingleton);
            this.groupBoxGeneric.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxGeneric.Location = new System.Drawing.Point(0, 0);
            this.groupBoxGeneric.Name = "groupBoxGeneric";
            this.groupBoxGeneric.Size = new System.Drawing.Size(190, 573);
            this.groupBoxGeneric.TabIndex = 0;
            this.groupBoxGeneric.TabStop = false;
            this.groupBoxGeneric.Text = "Порождающие паттерны";
            // 
            // groupBoxBehavior
            // 
            this.groupBoxBehavior.Controls.Add(this.buttonVisitor);
            this.groupBoxBehavior.Controls.Add(this.buttonChainOfResponsibility);
            this.groupBoxBehavior.Controls.Add(this.buttonTemplateMethod);
            this.groupBoxBehavior.Controls.Add(this.buttonMemento);
            this.groupBoxBehavior.Controls.Add(this.buttonStrategy);
            this.groupBoxBehavior.Controls.Add(this.buttonObserver);
            this.groupBoxBehavior.Controls.Add(this.buttonMediator);
            this.groupBoxBehavior.Controls.Add(this.buttonCommand);
            this.groupBoxBehavior.Controls.Add(this.buttonInterpreter);
            this.groupBoxBehavior.Controls.Add(this.buttonIterator);
            this.groupBoxBehavior.Controls.Add(this.buttonState);
            this.groupBoxBehavior.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxBehavior.Location = new System.Drawing.Point(190, 0);
            this.groupBoxBehavior.Name = "groupBoxBehavior";
            this.groupBoxBehavior.Size = new System.Drawing.Size(190, 573);
            this.groupBoxBehavior.TabIndex = 1;
            this.groupBoxBehavior.TabStop = false;
            this.groupBoxBehavior.Text = "Паттерны поведения";
            // 
            // groupBoxStruct
            // 
            this.groupBoxStruct.Controls.Add(this.buttonProxy);
            this.groupBoxStruct.Controls.Add(this.buttonAdapter);
            this.groupBoxStruct.Controls.Add(this.buttonFlyweight);
            this.groupBoxStruct.Controls.Add(this.buttonBridge);
            this.groupBoxStruct.Controls.Add(this.buttonFacade);
            this.groupBoxStruct.Controls.Add(this.buttonComposite);
            this.groupBoxStruct.Controls.Add(this.buttonDecorator);
            this.groupBoxStruct.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxStruct.Location = new System.Drawing.Point(380, 0);
            this.groupBoxStruct.Name = "groupBoxStruct";
            this.groupBoxStruct.Size = new System.Drawing.Size(190, 573);
            this.groupBoxStruct.TabIndex = 2;
            this.groupBoxStruct.TabStop = false;
            this.groupBoxStruct.Text = "Структурные паттерны";
            // 
            // groupBoxSOLID
            // 
            this.groupBoxSOLID.Controls.Add(this.buttonD);
            this.groupBoxSOLID.Controls.Add(this.buttonI);
            this.groupBoxSOLID.Controls.Add(this.buttonL);
            this.groupBoxSOLID.Controls.Add(this.buttonO);
            this.groupBoxSOLID.Controls.Add(this.buttonS);
            this.groupBoxSOLID.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxSOLID.Location = new System.Drawing.Point(570, 0);
            this.groupBoxSOLID.Name = "groupBoxSOLID";
            this.groupBoxSOLID.Size = new System.Drawing.Size(190, 573);
            this.groupBoxSOLID.TabIndex = 3;
            this.groupBoxSOLID.TabStop = false;
            this.groupBoxSOLID.Text = "SOLID";
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(20, 230);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(150, 30);
            this.buttonD.TabIndex = 4;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonI
            // 
            this.buttonI.Location = new System.Drawing.Point(20, 180);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(150, 30);
            this.buttonI.TabIndex = 3;
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = true;
            this.buttonI.Click += new System.EventHandler(this.buttonI_Click);
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(20, 130);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(150, 30);
            this.buttonL.TabIndex = 2;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            // 
            // buttonO
            // 
            this.buttonO.Location = new System.Drawing.Point(20, 80);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(150, 30);
            this.buttonO.TabIndex = 1;
            this.buttonO.Text = "O";
            this.buttonO.UseVisualStyleBackColor = true;
            this.buttonO.Click += new System.EventHandler(this.buttonO_Click);
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(20, 30);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(150, 30);
            this.buttonS.TabIndex = 0;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 573);
            this.Controls.Add(this.groupBoxSOLID);
            this.Controls.Add(this.groupBoxStruct);
            this.Controls.Add(this.groupBoxBehavior);
            this.Controls.Add(this.groupBoxGeneric);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pattrens";
            this.groupBoxGeneric.ResumeLayout(false);
            this.groupBoxBehavior.ResumeLayout(false);
            this.groupBoxStruct.ResumeLayout(false);
            this.groupBoxSOLID.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdapter;
        private System.Windows.Forms.Button buttonBridge;
        private System.Windows.Forms.Button buttonComposite;
        private System.Windows.Forms.Button buttonDecorator;
        private System.Windows.Forms.Button buttonFacade;
        private System.Windows.Forms.Button buttonProxy;
        private System.Windows.Forms.Button buttonFlyweight;
        private System.Windows.Forms.Button buttonFactoryMethod;
        private System.Windows.Forms.Button buttonAbstractFactory;
        private System.Windows.Forms.Button buttonSingleton;
        private System.Windows.Forms.Button buttonPrototype;
        private System.Windows.Forms.Button buttonBuilder;
        private System.Windows.Forms.Button buttonStrategy;
        private System.Windows.Forms.Button buttonObserver;
        private System.Windows.Forms.Button buttonCommand;
        private System.Windows.Forms.Button buttonTemplateMethod;
        private System.Windows.Forms.Button buttonIterator;
        private System.Windows.Forms.Button buttonState;
        private System.Windows.Forms.Button buttonChainOfResponsibility;
        private System.Windows.Forms.Button buttonInterpreter;
        private System.Windows.Forms.Button buttonMediator;
        private System.Windows.Forms.Button buttonMemento;
        private System.Windows.Forms.Button buttonVisitor;
        private System.Windows.Forms.GroupBox groupBoxGeneric;
        private System.Windows.Forms.GroupBox groupBoxBehavior;
        private System.Windows.Forms.GroupBox groupBoxStruct;
        private System.Windows.Forms.GroupBox groupBoxSOLID;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonD;
    }
}

