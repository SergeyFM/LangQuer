namespace LangQuerWF {
    partial class FormMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            menuStripMain = new MenuStrip();
            dataToolStripMenuItem = new ToolStripMenuItem();
            loadFilesToolStripMenuItem = new ToolStripMenuItem();
            newEmptyProjectToolStripMenuItem = new ToolStripMenuItem();
            saveProjectToolStripMenuItem = new ToolStripMenuItem();
            appToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            wordsToolStripMenuItem = new ToolStripMenuItem();
            currentStatsToolStripMenuItem = new ToolStripMenuItem();
            importKnownWordsToolStripMenuItem = new ToolStripMenuItem();
            manageDictionariesToolStripMenuItem = new ToolStripMenuItem();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new ToolStripItem[] { dataToolStripMenuItem, wordsToolStripMenuItem, appToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(800, 24);
            menuStripMain.TabIndex = 1;
            menuStripMain.Text = "Main menu";
            // 
            // dataToolStripMenuItem
            // 
            dataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadFilesToolStripMenuItem, newEmptyProjectToolStripMenuItem, saveProjectToolStripMenuItem });
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(56, 20);
            dataToolStripMenuItem.Text = "Project";
            // 
            // loadFilesToolStripMenuItem
            // 
            loadFilesToolStripMenuItem.Name = "loadFilesToolStripMenuItem";
            loadFilesToolStripMenuItem.Size = new Size(149, 22);
            loadFilesToolStripMenuItem.Text = "Load project...";
            loadFilesToolStripMenuItem.Click += loadFilesToolStripMenuItem_Click;
            // 
            // newEmptyProjectToolStripMenuItem
            // 
            newEmptyProjectToolStripMenuItem.Name = "newEmptyProjectToolStripMenuItem";
            newEmptyProjectToolStripMenuItem.Size = new Size(149, 22);
            newEmptyProjectToolStripMenuItem.Text = "Load folder...";
            // 
            // saveProjectToolStripMenuItem
            // 
            saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            saveProjectToolStripMenuItem.Size = new Size(149, 22);
            saveProjectToolStripMenuItem.Text = "Save project...";
            // 
            // appToolStripMenuItem
            // 
            appToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, aboutToolStripMenuItem, exitToolStripMenuItem });
            appToolStripMenuItem.Name = "appToolStripMenuItem";
            appToolStripMenuItem.Size = new Size(41, 20);
            appToolStripMenuItem.Text = "App";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(180, 22);
            settingsToolStripMenuItem.Text = "Settings...";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About...";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // wordsToolStripMenuItem
            // 
            wordsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currentStatsToolStripMenuItem, importKnownWordsToolStripMenuItem, manageDictionariesToolStripMenuItem });
            wordsToolStripMenuItem.Name = "wordsToolStripMenuItem";
            wordsToolStripMenuItem.Size = new Size(73, 20);
            wordsToolStripMenuItem.Text = "Dictionary";
            // 
            // currentStatsToolStripMenuItem
            // 
            currentStatsToolStripMenuItem.Name = "currentStatsToolStripMenuItem";
            currentStatsToolStripMenuItem.Size = new Size(193, 22);
            currentStatsToolStripMenuItem.Text = "Current stats...";
            // 
            // importKnownWordsToolStripMenuItem
            // 
            importKnownWordsToolStripMenuItem.Name = "importKnownWordsToolStripMenuItem";
            importKnownWordsToolStripMenuItem.Size = new Size(193, 22);
            importKnownWordsToolStripMenuItem.Text = "Import known words...";
            // 
            // manageDictionariesToolStripMenuItem
            // 
            manageDictionariesToolStripMenuItem.Name = "manageDictionariesToolStripMenuItem";
            manageDictionariesToolStripMenuItem.Size = new Size(193, 22);
            manageDictionariesToolStripMenuItem.Text = "Manage dictionaries...";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStripMain);
            IsMdiContainer = true;
            MainMenuStrip = menuStripMain;
            Name = "FormMain";
            Text = "LangQuer";
            WindowState = FormWindowState.Maximized;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem loadFilesToolStripMenuItem;
        private ToolStripMenuItem saveProjectToolStripMenuItem;
        private ToolStripMenuItem newEmptyProjectToolStripMenuItem;
        private ToolStripMenuItem appToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem wordsToolStripMenuItem;
        private ToolStripMenuItem currentStatsToolStripMenuItem;
        private ToolStripMenuItem importKnownWordsToolStripMenuItem;
        private ToolStripMenuItem manageDictionariesToolStripMenuItem;
    }
}