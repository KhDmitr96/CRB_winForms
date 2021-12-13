namespace CRB_winForms
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
            this.receiveDateLbl = new System.Windows.Forms.Label();
            this.receiveDateTb = new System.Windows.Forms.TextBox();
            this.receiveDataGridView = new System.Windows.Forms.DataGridView();
            this.receiveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.receiveDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // receiveDateLbl
            // 
            this.receiveDateLbl.AutoSize = true;
            this.receiveDateLbl.Location = new System.Drawing.Point(12, 15);
            this.receiveDateLbl.Name = "receiveDateLbl";
            this.receiveDateLbl.Size = new System.Drawing.Size(119, 13);
            this.receiveDateLbl.TabIndex = 0;
            this.receiveDateLbl.Text = "Запрашиваемая дата:";
            // 
            // receiveDateTb
            // 
            this.receiveDateTb.Location = new System.Drawing.Point(137, 12);
            this.receiveDateTb.MaxLength = 10;
            this.receiveDateTb.Name = "receiveDateTb";
            this.receiveDateTb.Size = new System.Drawing.Size(100, 20);
            this.receiveDateTb.TabIndex = 1;
            // 
            // receiveDataGridView
            // 
            this.receiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiveDataGridView.Location = new System.Drawing.Point(12, 38);
            this.receiveDataGridView.Name = "receiveDataGridView";
            this.receiveDataGridView.Size = new System.Drawing.Size(419, 400);
            this.receiveDataGridView.TabIndex = 3;
            // 
            // receiveBtn
            // 
            this.receiveBtn.Location = new System.Drawing.Point(243, 10);
            this.receiveBtn.Name = "receiveBtn";
            this.receiveBtn.Size = new System.Drawing.Size(75, 23);
            this.receiveBtn.TabIndex = 2;
            this.receiveBtn.Text = "Получить";
            this.receiveBtn.UseVisualStyleBackColor = true;
            this.receiveBtn.Click += new System.EventHandler(this.receiveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.receiveBtn);
            this.Controls.Add(this.receiveDataGridView);
            this.Controls.Add(this.receiveDateTb);
            this.Controls.Add(this.receiveDateLbl);
            this.Name = "Form1";
            this.Text = "Получение курса валют на выбранную дату";
            ((System.ComponentModel.ISupportInitialize)(this.receiveDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label receiveDateLbl;
        private System.Windows.Forms.TextBox receiveDateTb;
        private System.Windows.Forms.Button receiveBtn;
        private System.Windows.Forms.DataGridView receiveDataGridView;
    }
}

