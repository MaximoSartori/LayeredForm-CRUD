namespace Presentacion
{
    partial class FormMoneda
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dgv1 = new DataGridView();
            button1 = new Button();
            tb1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tb2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(55, 140);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(130, 23);
            button4.TabIndex = 26;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(55, 164);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(130, 23);
            button3.TabIndex = 25;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(55, 188);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(130, 23);
            button2.TabIndex = 24;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(234, 35);
            dgv1.Margin = new Padding(2);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidth = 62;
            dgv1.RowTemplate.Height = 33;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv1.Size = new Size(315, 201);
            dgv1.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(55, 116);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 22;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tb1
            // 
            tb1.Location = new Point(97, 37);
            tb1.Margin = new Padding(2);
            tb1.Name = "tb1";
            tb1.Size = new Size(106, 23);
            tb1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 68);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 19;
            label2.Text = "Codigo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 18;
            label1.Text = "Moneda";
            // 
            // tb2
            // 
            tb2.Location = new Point(97, 64);
            tb2.Margin = new Padding(2);
            tb2.Name = "tb2";
            tb2.Size = new Size(106, 23);
            tb2.TabIndex = 27;
            // 
            // FormMoneda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 270);
            Controls.Add(tb2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dgv1);
            Controls.Add(button1);
            Controls.Add(tb1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FormMoneda";
            Text = "FormMoneda";
            Load += FormMoneda_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private DataGridView dgv1;
        private Button button1;
        private TextBox tb1;
        private Label label2;
        private Label label1;
        private TextBox tb2;
    }
}