namespace InsertionSort
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_Sort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_limit = new System.Windows.Forms.TextBox();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_Sorted = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_UnSorted = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Reverse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Reversed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Sort
            // 
            this.bt_Sort.Location = new System.Drawing.Point(156, 362);
            this.bt_Sort.Name = "bt_Sort";
            this.bt_Sort.Size = new System.Drawing.Size(109, 46);
            this.bt_Sort.TabIndex = 0;
            this.bt_Sort.Text = "Sırala";
            this.bt_Sort.UseVisualStyleBackColor = true;
            this.bt_Sort.Click += new System.EventHandler(this.bt_Sort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(482, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "SÜRE =";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(394, 386);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(147, 22);
            this.txt_num.TabIndex = 2;
            // 
            // txt_limit
            // 
            this.txt_limit.Location = new System.Drawing.Point(573, 386);
            this.txt_limit.Name = "txt_limit";
            this.txt_limit.Size = new System.Drawing.Size(150, 22);
            this.txt_limit.TabIndex = 3;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(570, 462);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(132, 17);
            this.lbl_Time.TabIndex = 4;
            this.lbl_Time.Text = "InsertionSort Süresi";
            // 
            // lbl_Sorted
            // 
            this.lbl_Sorted.AutoSize = true;
            this.lbl_Sorted.Location = new System.Drawing.Point(153, 151);
            this.lbl_Sorted.Name = "lbl_Sorted";
            this.lbl_Sorted.Size = new System.Drawing.Size(47, 17);
            this.lbl_Sorted.TabIndex = 5;
            this.lbl_Sorted.Text = "Dizi = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(153, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sıralanmış Dizi : ";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(156, 442);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(109, 50);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Temizle";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_UnSorted
            // 
            this.lbl_UnSorted.AutoSize = true;
            this.lbl_UnSorted.Location = new System.Drawing.Point(153, 69);
            this.lbl_UnSorted.Name = "lbl_UnSorted";
            this.lbl_UnSorted.Size = new System.Drawing.Size(47, 17);
            this.lbl_UnSorted.TabIndex = 8;
            this.lbl_UnSorted.Text = "Dizi = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(153, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Random Dizi : ";
            // 
            // btn_Reverse
            // 
            this.btn_Reverse.Location = new System.Drawing.Point(713, 510);
            this.btn_Reverse.Name = "btn_Reverse";
            this.btn_Reverse.Size = new System.Drawing.Size(102, 46);
            this.btn_Reverse.TabIndex = 0;
            this.btn_Reverse.Text = "Ters Çevir";
            this.btn_Reverse.UseVisualStyleBackColor = true;
            this.btn_Reverse.Click += new System.EventHandler(this.btn_Reverse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(390, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dizi Uzunluğu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(569, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Random Aralığı";
            // 
            // lbl_Reversed
            // 
            this.lbl_Reversed.AutoSize = true;
            this.lbl_Reversed.Location = new System.Drawing.Point(154, 232);
            this.lbl_Reversed.Name = "lbl_Reversed";
            this.lbl_Reversed.Size = new System.Drawing.Size(76, 17);
            this.lbl_Reversed.TabIndex = 12;
            this.lbl_Reversed.Text = "Ters Dizi =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 580);
            this.Controls.Add(this.lbl_Reversed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Reverse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_UnSorted);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Sorted);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.txt_limit);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Sort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Sort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.TextBox txt_limit;
        private System.Windows.Forms.Label lbl_Sorted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_UnSorted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Reverse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Reversed;
    }
}

