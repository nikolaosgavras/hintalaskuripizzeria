namespace koe3
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            pizzaMaara = new NumericUpDown();
            label3 = new Label();
            juustoMaara = new NumericUpDown();
            kinkkuMaara = new NumericUpDown();
            label4 = new Label();
            oliiviMaara = new NumericUpDown();
            label5 = new Label();
            btnOK = new Button();
            label7 = new Label();
            checkbox05 = new CheckBox();
            checkbox15 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pizzaMaara).BeginInit();
            ((System.ComponentModel.ISupportInitialize)juustoMaara).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kinkkuMaara).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oliiviMaara).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 0;
            label1.Text = "Monta pizzaa?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 107);
            label2.Name = "label2";
            label2.Size = new Size(119, 30);
            label2.TabIndex = 2;
            label2.Text = "Lisätäytteet";
            // 
            // pizzaMaara
            // 
            pizzaMaara.Location = new Point(62, 58);
            pizzaMaara.Name = "pizzaMaara";
            pizzaMaara.Size = new Size(68, 23);
            pizzaMaara.TabIndex = 3;
            pizzaMaara.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 150);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 4;
            label3.Text = "Lisäjuusto (1€)";
            // 
            // juustoMaara
            // 
            juustoMaara.Location = new Point(40, 174);
            juustoMaara.Name = "juustoMaara";
            juustoMaara.Size = new Size(43, 23);
            juustoMaara.TabIndex = 5;
            // 
            // kinkkuMaara
            // 
            kinkkuMaara.Location = new Point(155, 174);
            kinkkuMaara.Name = "kinkkuMaara";
            kinkkuMaara.Size = new Size(43, 23);
            kinkkuMaara.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(127, 150);
            label4.Name = "label4";
            label4.Size = new Size(110, 21);
            label4.TabIndex = 6;
            label4.Text = "Kinkku (1,50€)";
            // 
            // oliiviMaara
            // 
            oliiviMaara.Location = new Point(274, 174);
            oliiviMaara.Name = "oliiviMaara";
            oliiviMaara.Size = new Size(43, 23);
            oliiviMaara.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(243, 150);
            label5.Name = "label5";
            label5.Size = new Size(104, 21);
            label5.TabIndex = 8;
            label5.Text = "Oliivit (0,50€)";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(144, 242);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(222, 21);
            label7.Name = "label7";
            label7.Size = new Size(81, 30);
            label7.TabIndex = 13;
            label7.Text = "Juomat";
            // 
            // checkbox05
            // 
            checkbox05.AutoSize = true;
            checkbox05.Location = new Point(222, 69);
            checkbox05.Name = "checkbox05";
            checkbox05.Size = new Size(79, 19);
            checkbox05.TabIndex = 17;
            checkbox05.Text = "0,5L (2,5€)";
            checkbox05.UseVisualStyleBackColor = true;
            checkbox05.CheckedChanged += checkbox05_CheckedChanged;
            // 
            // checkbox15
            // 
            checkbox15.AutoSize = true;
            checkbox15.Location = new Point(222, 94);
            checkbox15.Name = "checkbox15";
            checkbox15.Size = new Size(70, 19);
            checkbox15.TabIndex = 18;
            checkbox15.Text = "1,5L (4€)";
            checkbox15.UseVisualStyleBackColor = true;
            checkbox15.CheckedChanged += checkbox15_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 285);
            Controls.Add(checkbox15);
            Controls.Add(checkbox05);
            Controls.Add(label7);
            Controls.Add(btnOK);
            Controls.Add(oliiviMaara);
            Controls.Add(label5);
            Controls.Add(kinkkuMaara);
            Controls.Add(label4);
            Controls.Add(juustoMaara);
            Controls.Add(label3);
            Controls.Add(pizzaMaara);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Valitse haluamasi valinnat";
            ((System.ComponentModel.ISupportInitialize)pizzaMaara).EndInit();
            ((System.ComponentModel.ISupportInitialize)juustoMaara).EndInit();
            ((System.ComponentModel.ISupportInitialize)kinkkuMaara).EndInit();
            ((System.ComponentModel.ISupportInitialize)oliiviMaara).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown pizzaMaara;
        private Label label3;
        private NumericUpDown juustoMaara;
        private NumericUpDown kinkkuMaara;
        private Label label4;
        private NumericUpDown oliiviMaara;
        private Label label5;
        private Button btnOK;
        private Label label7;
        private CheckBox checkbox05;
        private CheckBox checkbox15;
    }
}