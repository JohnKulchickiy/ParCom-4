namespace lab_4
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
            this.btn_FreeThread = new System.Windows.Forms.Button();
            this.txt_debug = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_FreeThread
            // 
            this.btn_FreeThread.Location = new System.Drawing.Point(13, 13);
            this.btn_FreeThread.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_FreeThread.Name = "btn_FreeThread";
            this.btn_FreeThread.Size = new System.Drawing.Size(756, 32);
            this.btn_FreeThread.TabIndex = 0;
            this.btn_FreeThread.Text = "Выпустить потоки на волю!";
            this.btn_FreeThread.UseVisualStyleBackColor = true;
            this.btn_FreeThread.Click += new System.EventHandler(this.btn_FreeThread_Click);
            // 
            // txt_debug
            // 
            this.txt_debug.Location = new System.Drawing.Point(13, 53);
            this.txt_debug.Multiline = true;
            this.txt_debug.Name = "txt_debug";
            this.txt_debug.Size = new System.Drawing.Size(756, 338);
            this.txt_debug.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.txt_debug);
            this.Controls.Add(this.btn_FreeThread);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_FreeThread;
        private System.Windows.Forms.TextBox txt_debug;
    }
}

