namespace josephus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            label1 = new Label();
            turIndex = new Label();
            label3 = new Label();
            winnerText = new Label();
            button1 = new Button();
            panel1 = new Panel();
            playerCount = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)playerCount).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 280);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(521, 334);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(96, 56);
            label1.TabIndex = 1;
            label1.Text = "TUR:";
            // 
            // turIndex
            // 
            turIndex.AutoSize = true;
            turIndex.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            turIndex.Location = new Point(114, 88);
            turIndex.Name = "turIndex";
            turIndex.Size = new Size(26, 42);
            turIndex.TabIndex = 1;
            turIndex.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(181, 56);
            label3.TabIndex = 1;
            label3.Text = "Kazanan:";
            // 
            // winnerText
            // 
            winnerText.AutoSize = true;
            winnerText.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            winnerText.Location = new Point(199, 144);
            winnerText.Name = "winnerText";
            winnerText.Size = new Size(26, 42);
            winnerText.TabIndex = 1;
            winnerText.Text = "1";
            winnerText.Visible = false;
            // 
            // button1
            // 
            button1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(12, 196);
            button1.Name = "button1";
            button1.Size = new Size(521, 54);
            button1.TabIndex = 2;
            button1.Text = "Oyunu Başlat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(539, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 609);
            panel1.TabIndex = 3;
            // 
            // playerCount
            // 
            playerCount.BorderStyle = BorderStyle.FixedSingle;
            playerCount.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            playerCount.Location = new Point(272, 147);
            playerCount.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            playerCount.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            playerCount.Name = "playerCount";
            playerCount.Size = new Size(261, 36);
            playerCount.TabIndex = 4;
            playerCount.TextAlign = HorizontalAlignment.Center;
            playerCount.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(272, 88);
            label2.Name = "label2";
            label2.Size = new Size(261, 56);
            label2.TabIndex = 1;
            label2.Text = "Oyuncu Sayısı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(137, 12);
            label4.Name = "label4";
            label4.Size = new Size(184, 56);
            label4.TabIndex = 1;
            label4.Text = "Josephus";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 633);
            Controls.Add(playerCount);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(winnerText);
            Controls.Add(turIndex);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Josephus";
            ((System.ComponentModel.ISupportInitialize)playerCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label turIndex;
        private Label label3;
        private Label winnerText;
        private Button button1;
        private Panel panel1;
        private NumericUpDown playerCount;
        private Label label2;
        private Label label4;
    }
}
