namespace SuperPaint
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFigureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figureWithTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figureWithPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.synhroniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.figureWithTextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editTextToolStripMenuItem,
            this.changeFigureToolStripMenuItem,
            this.pageToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // changeFigureToolStripMenuItem
            // 
            this.changeFigureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem1,
            this.widthToolStripMenuItem});
            this.changeFigureToolStripMenuItem.Name = "changeFigureToolStripMenuItem";
            this.changeFigureToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.changeFigureToolStripMenuItem.Text = "Edit";
            this.changeFigureToolStripMenuItem.Click += new System.EventHandler(this.changeFigureToolStripMenuItem_Click);
            // 
            // widthToolStripMenuItem
            // 
            this.widthToolStripMenuItem.Name = "widthToolStripMenuItem";
            this.widthToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.widthToolStripMenuItem.Text = "Width";
            // 
            // editTextToolStripMenuItem
            // 
            this.editTextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figureToolStripMenuItem1,
            this.figureWithTextToolStripMenuItem1});
            this.editTextToolStripMenuItem.Name = "editTextToolStripMenuItem";
            this.editTextToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.editTextToolStripMenuItem.Text = "Element Type";
            // 
            // pageToolStripMenuItem
            // 
            this.pageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.renameToolStripMenuItem});
            this.pageToolStripMenuItem.Name = "pageToolStripMenuItem";
            this.pageToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.pageToolStripMenuItem.Text = "Page";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pluginsToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.themesToolStripMenuItem,
            this.cloudToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // pluginsToolStripMenuItem
            // 
            this.pluginsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figureToolStripMenuItem,
            this.figureWithTextToolStripMenuItem,
            this.figureWithPictureToolStripMenuItem});
            this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.pluginsToolStripMenuItem.Text = "Plugins";
            // 
            // figureToolStripMenuItem
            // 
            this.figureToolStripMenuItem.Checked = true;
            this.figureToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.figureToolStripMenuItem.Name = "figureToolStripMenuItem";
            this.figureToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.figureToolStripMenuItem.Text = "Figure";
            // 
            // figureWithTextToolStripMenuItem
            // 
            this.figureWithTextToolStripMenuItem.Checked = true;
            this.figureWithTextToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.figureWithTextToolStripMenuItem.Name = "figureWithTextToolStripMenuItem";
            this.figureWithTextToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.figureWithTextToolStripMenuItem.Text = "Figure with text";
            // 
            // figureWithPictureToolStripMenuItem
            // 
            this.figureWithPictureToolStripMenuItem.Name = "figureWithPictureToolStripMenuItem";
            this.figureWithPictureToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.figureWithPictureToolStripMenuItem.Text = "Figure with picture";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rusToolStripMenuItem,
            this.engToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // rusToolStripMenuItem
            // 
            this.rusToolStripMenuItem.Name = "rusToolStripMenuItem";
            this.rusToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.rusToolStripMenuItem.Text = "Rus";
            // 
            // engToolStripMenuItem
            // 
            this.engToolStripMenuItem.Checked = true;
            this.engToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.engToolStripMenuItem.Name = "engToolStripMenuItem";
            this.engToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.engToolStripMenuItem.Text = "Eng";
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.hallowToolStripMenuItem});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.themesToolStripMenuItem.Text = "Themes";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            // 
            // hallowToolStripMenuItem
            // 
            this.hallowToolStripMenuItem.Name = "hallowToolStripMenuItem";
            this.hallowToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.hallowToolStripMenuItem.Text = "Hallow";
            // 
            // cloudToolStripMenuItem
            // 
            this.cloudToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signInToolStripMenuItem,
            this.synhroniToolStripMenuItem});
            this.cloudToolStripMenuItem.Name = "cloudToolStripMenuItem";
            this.cloudToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cloudToolStripMenuItem.Text = "Cloud";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionToolStripMenuItem
            // 
            this.instructionToolStripMenuItem.Name = "instructionToolStripMenuItem";
            this.instructionToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.instructionToolStripMenuItem.Text = "Instruction";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutToolStripMenuItem.Text = "About autors";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            // 
            // signInToolStripMenuItem
            // 
            this.signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            this.signInToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.signInToolStripMenuItem.Text = "Sign in";
            // 
            // synhroniToolStripMenuItem
            // 
            this.synhroniToolStripMenuItem.Name = "synhroniToolStripMenuItem";
            this.synhroniToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.synhroniToolStripMenuItem.Text = "Synchronize";
            // 
            // figureToolStripMenuItem1
            // 
            this.figureToolStripMenuItem1.Name = "figureToolStripMenuItem1";
            this.figureToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.figureToolStripMenuItem1.Text = "Figure";
            // 
            // figureWithTextToolStripMenuItem1
            // 
            this.figureWithTextToolStripMenuItem1.Name = "figureWithTextToolStripMenuItem1";
            this.figureWithTextToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.figureWithTextToolStripMenuItem1.Text = "Figure with Text";
            // 
            // colorToolStripMenuItem1
            // 
            this.colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
            this.colorToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.colorToolStripMenuItem1.Text = "Color";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(721, 26);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFigureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pluginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figureWithTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figureWithPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem synhroniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figureToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem figureWithTextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem1;
    }
}
