namespace SuperPaint.UserControls
{
    partial class Panel
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolBoxFigures1 = new SuperPaint.UserControls.ToolBoxFigures();
            this.toolBar1 = new SuperPaint.UserControls.ToolBar();
            this.menu1 = new SuperPaint.Menu();
            this.tabsControlWithButtons1 = new SuperPaint.UserControls.TabsControlWithButtons();
            this.drawField1 = new SuperPaint.UserControls.DrawField();
            this.SuspendLayout();
            // 
            // toolBoxFigures1
            // 
            this.toolBoxFigures1.Location = new System.Drawing.Point(3, 59);
            this.toolBoxFigures1.Name = "toolBoxFigures1";
            this.toolBoxFigures1.Size = new System.Drawing.Size(205, 301);
            this.toolBoxFigures1.TabIndex = 7;
            // 
            // toolBar1
            // 
            this.toolBar1.Location = new System.Drawing.Point(3, 27);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(933, 26);
            this.toolBar1.TabIndex = 6;
            // 
            // menu1
            // 
            this.menu1.Location = new System.Drawing.Point(3, 4);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(933, 26);
            this.menu1.TabIndex = 5;
            // 
            // tabsControlWithButtons1
            // 
            this.tabsControlWithButtons1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabsControlWithButtons1.Location = new System.Drawing.Point(182, 59);
            this.tabsControlWithButtons1.Name = "tabsControlWithButtons1";
            this.tabsControlWithButtons1.Size = new System.Drawing.Size(653, 468);
            this.tabsControlWithButtons1.TabIndex = 8;
            // 
            // drawField1
            // 
            this.drawField1.Action = null;
            this.drawField1.Location = new System.Drawing.Point(202, 117);
            this.drawField1.Name = "drawField1";
            this.drawField1.Size = new System.Drawing.Size(612, 392);
            this.drawField1.TabIndex = 9;
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.drawField1);
            this.Controls.Add(this.tabsControlWithButtons1);
            this.Controls.Add(this.toolBoxFigures1);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.menu1);
            this.Name = "Panel";
            this.Size = new System.Drawing.Size(940, 554);
            this.Load += new System.EventHandler(this.Panel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ToolBoxFigures toolBoxFigures1;
        private ToolBar toolBar1;
        private Menu menu1;
        private TabsControlWithButtons tabsControlWithButtons1;
        private DrawField drawField1;
    }
}
