﻿namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label5 = new System.Windows.Forms.Label();
            this.Name_display = new System.Windows.Forms.TextBox();
            this.Age_display = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Description_display = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Ranking = new System.Windows.Forms.DataGridView();
            this.Registration_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Thumbup_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_display = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ranking)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "名前";
            // 
            // Name_display
            // 
            this.Name_display.Location = new System.Drawing.Point(37, 102);
            this.Name_display.Name = "Name_display";
            this.Name_display.Size = new System.Drawing.Size(227, 20);
            this.Name_display.TabIndex = 10;
            // 
            // Age_display
            // 
            this.Age_display.Location = new System.Drawing.Point(318, 102);
            this.Age_display.Name = "Age_display";
            this.Age_display.Size = new System.Drawing.Size(57, 20);
            this.Age_display.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(297, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "年齢";
            // 
            // Description_display
            // 
            this.Description_display.Location = new System.Drawing.Point(37, 183);
            this.Description_display.Name = "Description_display";
            this.Description_display.Size = new System.Drawing.Size(398, 78);
            this.Description_display.TabIndex = 13;
            this.Description_display.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "自己紹介";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(628, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "新規登録・プロフィール更新";
            // 
            // dataGridView_Ranking
            // 
            this.dataGridView_Ranking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ranking.Location = new System.Drawing.Point(587, 183);
            this.dataGridView_Ranking.Name = "dataGridView_Ranking";
            this.dataGridView_Ranking.RowHeadersWidth = 51;
            this.dataGridView_Ranking.RowTemplate.Height = 21;
            this.dataGridView_Ranking.Size = new System.Drawing.Size(344, 276);
            this.dataGridView_Ranking.TabIndex = 17;
            // 
            // Registration_button
            // 
            this.Registration_button.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.touroku1;
            this.Registration_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Registration_button.Location = new System.Drawing.Point(682, 75);
            this.Registration_button.Name = "Registration_button";
            this.Registration_button.Size = new System.Drawing.Size(132, 99);
            this.Registration_button.TabIndex = 15;
            this.Registration_button.UseVisualStyleBackColor = true;
            this.Registration_button.Click += new System.EventHandler(this.Registration_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.reload1;
            this.Update_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Update_button.Location = new System.Drawing.Point(450, 344);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(115, 115);
            this.Update_button.TabIndex = 7;
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Thumbup_button
            // 
            this.Thumbup_button.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.good2;
            this.Thumbup_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Thumbup_button.Location = new System.Drawing.Point(450, 198);
            this.Thumbup_button.Name = "Thumbup_button";
            this.Thumbup_button.Size = new System.Drawing.Size(115, 113);
            this.Thumbup_button.TabIndex = 6;
            this.Thumbup_button.UseVisualStyleBackColor = true;
            this.Thumbup_button.Click += new System.EventHandler(this.Thumbup_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 42);
            this.label1.TabIndex = 19;
            this.label1.Text = "UserのID";
            // 
            // ID_display
            // 
            this.ID_display.AutoSize = true;
            this.ID_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_display.Location = new System.Drawing.Point(100, 422);
            this.ID_display.Name = "ID_display";
            this.ID_display.Size = new System.Drawing.Size(113, 37);
            this.ID_display.TabIndex = 20;
            this.ID_display.Text = "読込中";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(943, 496);
            this.Controls.Add(this.ID_display);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Ranking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Registration_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Description_display);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Age_display);
            this.Controls.Add(this.Name_display);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Thumbup_button);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ranking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Thumbup_button;
        private System.Windows.Forms.Button Update_button;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox Description_display;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Age_display;
        private System.Windows.Forms.TextBox Name_display;
        private System.Windows.Forms.Button Registration_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Ranking;
        private System.Windows.Forms.Label ID_display;
        private System.Windows.Forms.Label label1;
    }
}

