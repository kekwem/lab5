
namespace lab5
{
    partial class Form1
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
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pathButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressCheckBox = new System.Windows.Forms.CheckBox();
            this.szyfrowanieCheckBox1 = new System.Windows.Forms.CheckBox();
            this.koniecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(47, 34);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(461, 22);
            this.pathTextBox.TabIndex = 0;
            // 
            // pathButton
            // 
            this.pathButton.Location = new System.Drawing.Point(587, 32);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(104, 23);
            this.pathButton.TabIndex = 1;
            this.pathButton.Text = "Przegladaj";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(47, 101);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(461, 315);
            this.contentTextBox.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszToolStripMenuItem,
            this.odczytajToolStripMenuItem,
            this.koniecToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // odczytajToolStripMenuItem
            // 
            this.odczytajToolStripMenuItem.Name = "odczytajToolStripMenuItem";
            this.odczytajToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.odczytajToolStripMenuItem.Text = "Odczytaj";
            this.odczytajToolStripMenuItem.Click += new System.EventHandler(this.odczytajToolStripMenuItem_Click);
            // 
            // compressCheckBox
            // 
            this.compressCheckBox.AutoSize = true;
            this.compressCheckBox.Location = new System.Drawing.Point(624, 184);
            this.compressCheckBox.Name = "compressCheckBox";
            this.compressCheckBox.Size = new System.Drawing.Size(97, 21);
            this.compressCheckBox.TabIndex = 4;
            this.compressCheckBox.Text = "Kompresja";
            this.compressCheckBox.UseVisualStyleBackColor = true;
            // 
            // szyfrowanieCheckBox1
            // 
            this.szyfrowanieCheckBox1.AutoSize = true;
            this.szyfrowanieCheckBox1.Location = new System.Drawing.Point(624, 263);
            this.szyfrowanieCheckBox1.Name = "szyfrowanieCheckBox1";
            this.szyfrowanieCheckBox1.Size = new System.Drawing.Size(106, 21);
            this.szyfrowanieCheckBox1.TabIndex = 5;
            this.szyfrowanieCheckBox1.Text = "Szyfrowanie";
            this.szyfrowanieCheckBox1.UseVisualStyleBackColor = true;
            // 
            // koniecToolStripMenuItem
            // 
            this.koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            this.koniecToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.koniecToolStripMenuItem.Text = "Koniec";
            this.koniecToolStripMenuItem.Click += new System.EventHandler(this.koniecToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.szyfrowanieCheckBox1);
            this.Controls.Add(this.compressCheckBox);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notatnik";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odczytajToolStripMenuItem;
        private System.Windows.Forms.CheckBox compressCheckBox;
        private System.Windows.Forms.CheckBox szyfrowanieCheckBox1;
        private System.Windows.Forms.ToolStripMenuItem koniecToolStripMenuItem;
    }
}

