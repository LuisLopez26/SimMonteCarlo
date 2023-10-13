namespace SimMonteCarlo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 84);
            label1.Name = "label1";
            label1.Size = new Size(125, 41);
            label1.TabIndex = 0;
            label1.Text = "Paneles:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 182);
            label2.Name = "label2";
            label2.Size = new Size(207, 41);
            label2.TabIndex = 1;
            label2.Text = "Límite inferior:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(841, 78);
            label3.Name = "label3";
            label3.Size = new Size(198, 41);
            label3.TabIndex = 2;
            label3.Text = "Experimentos";
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(841, 176);
            label4.Name = "label4";
            label4.Size = new Size(222, 41);
            label4.TabIndex = 3;
            label4.Text = "Límite superior:";
            
            // 
            // textBox1
            // 
            textBox1.Location = new Point(474, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 47);
            textBox1.TabIndex = 4;
            
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1106, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 47);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(474, 176);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 47);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1106, 182);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 47);
            textBox4.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(218, 390);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.RowTemplate.Height = 49;
            dataGridView1.Size = new Size(1138, 479);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(696, 281);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 9;
            button1.Text = "Ejecutar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1667, 960);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DataGridView dataGridView1;
        private Button button1;
    }
}