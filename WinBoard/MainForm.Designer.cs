namespace WinBoard
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mmGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mmGameNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mmGameOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mmGameSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.mmMove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pnlWorkArea = new System.Windows.Forms.Panel();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmGame,
            this.mmPosition,
            this.mmMove});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mmGame
            // 
            this.mmGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmGameNew,
            this.mmGameOpen,
            this.mmGameSave,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.mmExit});
            this.mmGame.Name = "mmGame";
            this.mmGame.Size = new System.Drawing.Size(46, 20);
            this.mmGame.Text = "Игра";
            // 
            // mmGameNew
            // 
            this.mmGameNew.Name = "mmGameNew";
            this.mmGameNew.Size = new System.Drawing.Size(152, 22);
            this.mmGameNew.Text = "Новая";
            // 
            // mmGameOpen
            // 
            this.mmGameOpen.Name = "mmGameOpen";
            this.mmGameOpen.Size = new System.Drawing.Size(152, 22);
            this.mmGameOpen.Text = "Открыть...";
            // 
            // mmGameSave
            // 
            this.mmGameSave.Name = "mmGameSave";
            this.mmGameSave.Size = new System.Drawing.Size(152, 22);
            this.mmGameSave.Text = "Сохранить...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mmExit
            // 
            this.mmExit.Name = "mmExit";
            this.mmExit.Size = new System.Drawing.Size(152, 22);
            this.mmExit.Text = "Выход";
            // 
            // mmPosition
            // 
            this.mmPosition.Name = "mmPosition";
            this.mmPosition.Size = new System.Drawing.Size(67, 20);
            this.mmPosition.Text = "Позиция";
            // 
            // mmMove
            // 
            this.mmMove.Name = "mmMove";
            this.mmMove.Size = new System.Drawing.Size(39, 20);
            this.mmMove.Text = "Ход";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pnlWorkArea
            // 
            this.pnlWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWorkArea.Location = new System.Drawing.Point(0, 49);
            this.pnlWorkArea.Name = "pnlWorkArea";
            this.pnlWorkArea.Size = new System.Drawing.Size(284, 191);
            this.pnlWorkArea.TabIndex = 3;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "База данных";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pnlWorkArea);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "WinBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel pnlWorkArea;
        private System.Windows.Forms.ToolStripMenuItem mmGame;
        private System.Windows.Forms.ToolStripMenuItem mmGameNew;
        private System.Windows.Forms.ToolStripMenuItem mmGameOpen;
        private System.Windows.Forms.ToolStripMenuItem mmGameSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mmExit;
        private System.Windows.Forms.ToolStripMenuItem mmPosition;
        private System.Windows.Forms.ToolStripMenuItem mmMove;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

