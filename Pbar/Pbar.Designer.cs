namespace Pbar
{
    partial class Pbar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pbar));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelPercent = new System.Windows.Forms.Label();
            this.pictureProgressBar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProgressBar)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelPercent
            // 
            this.labelPercent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPercent.BackColor = System.Drawing.Color.Transparent;
            this.labelPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPercent.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPercent.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelPercent.Location = new System.Drawing.Point(42, 59);
            this.labelPercent.Margin = new System.Windows.Forms.Padding(0);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(67, 31);
            this.labelPercent.TabIndex = 24;
            this.labelPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureProgressBar
            // 
            this.pictureProgressBar.ErrorImage = null;
            this.pictureProgressBar.Image = ((System.Drawing.Image)(resources.GetObject("pictureProgressBar.Image")));
            this.pictureProgressBar.Location = new System.Drawing.Point(11, 11);
            this.pictureProgressBar.Name = "pictureProgressBar";
            this.pictureProgressBar.Size = new System.Drawing.Size(128, 128);
            this.pictureProgressBar.TabIndex = 25;
            this.pictureProgressBar.TabStop = false;
            // 
            // Pbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.pictureProgressBar);
            this.DoubleBuffered = true;
            this.Name = "Pbar";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProgressBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.PictureBox pictureProgressBar;
    }
}
