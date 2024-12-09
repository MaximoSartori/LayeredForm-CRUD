namespace Agron
{
    partial class FormBanco
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
            tb1 = new TextBox();
            label1 = new Label();
            cb1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cb2 = new ComboBox();
            label4 = new Label();
            tb2 = new TextBox();
            label5 = new Label();
            tb3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dgv1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // tb1
            // 
            tb1.Location = new Point(94, 52);
            tb1.Margin = new Padding(2);
            tb1.Name = "tb1";
            tb1.Size = new Size(200, 23);
            tb1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 55);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Banco";
            // 
            // cb1
            // 
            cb1.FormattingEnabled = true;
            cb1.Location = new Point(94, 91);
            cb1.Margin = new Padding(2);
            cb1.Name = "cb1";
            cb1.Size = new Size(200, 23);
            cb1.TabIndex = 2;
            cb1.SelectedIndexChanged += cb1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 97);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Moneda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 131);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "Tipo";
            // 
            // cb2
            // 
            cb2.FormattingEnabled = true;
            cb2.Items.AddRange(new object[] { "1", "2" });
            cb2.Location = new Point(94, 125);
            cb2.Margin = new Padding(2);
            cb2.Name = "cb2";
            cb2.Size = new Size(200, 23);
            cb2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 165);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 7;
            label4.Text = "Detalle";
            // 
            // tb2
            // 
            tb2.Location = new Point(94, 161);
            tb2.Margin = new Padding(2);
            tb2.Name = "tb2";
            tb2.Size = new Size(200, 23);
            tb2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 201);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 9;
            label5.Text = "Cbu";
            // 
            // tb3
            // 
            tb3.Location = new Point(94, 197);
            tb3.Margin = new Padding(2);
            tb3.Name = "tb3";
            tb3.Size = new Size(200, 23);
            tb3.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(94, 237);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(85, 28);
            button1.TabIndex = 10;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(208, 237);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(86, 28);
            button2.TabIndex = 11;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(341, 52);
            dgv1.Margin = new Padding(2);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidth = 62;
            dgv1.RowTemplate.Height = 33;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv1.Size = new Size(667, 253);
            dgv1.TabIndex = 12;
            dgv1.CellContentClick += dgv1_CellContentClick;
            // 
            // button3
            // 
            button3.Location = new Point(94, 277);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(85, 28);
            button3.TabIndex = 13;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(208, 277);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(86, 28);
            button4.TabIndex = 14;
            button4.Text = "Borrar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FormBanco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 364);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dgv1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(tb3);
            Controls.Add(label4);
            Controls.Add(tb2);
            Controls.Add(label3);
            Controls.Add(cb2);
            Controls.Add(label2);
            Controls.Add(cb1);
            Controls.Add(label1);
            Controls.Add(tb1);
            Margin = new Padding(2);
            Name = "FormBanco";
            Text = "FormBanco";
            Load += FormBanco_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DataGridView dgv1;
        private Button button3;
        private Button button4;
    }
}