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
            this.checkBoxMultiSelection = new System.Windows.Forms.CheckBox();
            this.checkBoxCtrl = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawFigure)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDrawFigure
            // 
            this.pictureBoxDrawFigure.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxDrawFigure.Name = "pictureBoxDrawFigure";
            this.pictureBoxDrawFigure.Size = new System.Drawing.Size(644, 524);
            this.pictureBoxDrawFigure.TabIndex = 0;
            this.pictureBoxDrawFigure.TabStop = false;
            this.pictureBoxDrawFigure.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxDrawFigure_Paint);
            this.pictureBoxDrawFigure.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawFigure_MouseDown);
            // 
            // checkBoxMultiSelection
            // 
            this.checkBoxMultiSelection.AutoSize = true;
            this.checkBoxMultiSelection.Location = new System.Drawing.Point(662, 38);
            this.checkBoxMultiSelection.Name = "checkBoxMultiSelection";
            this.checkBoxMultiSelection.Size = new System.Drawing.Size(114, 20);
            this.checkBoxMultiSelection.TabIndex = 2;
            this.checkBoxMultiSelection.Text = "Multi-selection";
            this.checkBoxMultiSelection.UseVisualStyleBackColor = true;
            // 
            // checkBoxCtrl
            // 
            this.checkBoxCtrl.AutoSize = true;
            this.checkBoxCtrl.Location = new System.Drawing.Point(662, 12);
            this.checkBoxCtrl.Name = "checkBoxCtrl";
            this.checkBoxCtrl.Size = new System.Drawing.Size(48, 20);
            this.checkBoxCtrl.TabIndex = 1;
            this.checkBoxCtrl.Text = "Ctrl";
            this.checkBoxCtrl.UseVisualStyleBackColor = true;
            this.checkBoxCtrl.CheckedChanged += new System.EventHandler(this.checkBoxCtrl_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 548);
            this.Controls.Add(this.checkBoxMultiSelection);
            this.Controls.Add(this.checkBoxCtrl);
            this.Controls.Add(this.pictureBoxDrawFigure);
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Text = "Main";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawFigure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDrawFigure;
        private System.Windows.Forms.CheckBox checkBoxMultiSelection;
        private System.Windows.Forms.CheckBox checkBoxCtrl;
    }
}

