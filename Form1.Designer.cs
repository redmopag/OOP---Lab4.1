namespace Project
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
            this.pictureBoxDrawFigure = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawFigure)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDrawFigure
            // 
            this.pictureBoxDrawFigure.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxDrawFigure.Name = "pictureBoxDrawFigure";
            this.pictureBoxDrawFigure.Size = new System.Drawing.Size(514, 426);
            this.pictureBoxDrawFigure.TabIndex = 0;
            this.pictureBoxDrawFigure.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxDrawFigure);
            this.Name = "FormMain";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawFigure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDrawFigure;
    }
}

