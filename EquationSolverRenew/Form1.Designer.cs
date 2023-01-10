namespace EquationSolverRenew
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
            this.Calculate = new System.Windows.Forms.Button();
            this.LabelX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.X1PlaceHolder = new System.Windows.Forms.TextBox();
            this.X2PlaceHolder = new System.Windows.Forms.TextBox();
            this.Y1PlaceHolder = new System.Windows.Forms.TextBox();
            this.Y2PlaceHolder = new System.Windows.Forms.TextBox();
            this.Answer1PlaceHolder = new System.Windows.Forms.TextBox();
            this.Answer2PlaceHolder = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.Label();
            this.reponsebox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculate.Location = new System.Drawing.Point(590, 81);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(156, 53);
            this.Calculate.TabIndex = 7;
            this.Calculate.Text = "Calculer";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelX.Location = new System.Drawing.Point(158, 40);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(72, 46);
            this.LabelX.TabIndex = 1;
            this.LabelX.Text = "X +";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(158, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "X +";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(357, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(357, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y =";
            // 
            // X1PlaceHolder
            // 
            this.X1PlaceHolder.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.X1PlaceHolder.Location = new System.Drawing.Point(22, 42);
            this.X1PlaceHolder.Name = "X1PlaceHolder";
            this.X1PlaceHolder.Size = new System.Drawing.Size(125, 52);
            this.X1PlaceHolder.TabIndex = 1;
            this.X1PlaceHolder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // X2PlaceHolder
            // 
            this.X2PlaceHolder.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.X2PlaceHolder.Location = new System.Drawing.Point(22, 114);
            this.X2PlaceHolder.Name = "X2PlaceHolder";
            this.X2PlaceHolder.Size = new System.Drawing.Size(125, 52);
            this.X2PlaceHolder.TabIndex = 4;
            this.X2PlaceHolder.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Y1PlaceHolder
            // 
            this.Y1PlaceHolder.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Y1PlaceHolder.Location = new System.Drawing.Point(226, 42);
            this.Y1PlaceHolder.Name = "Y1PlaceHolder";
            this.Y1PlaceHolder.Size = new System.Drawing.Size(125, 52);
            this.Y1PlaceHolder.TabIndex = 2;
            this.Y1PlaceHolder.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Y2PlaceHolder
            // 
            this.Y2PlaceHolder.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Y2PlaceHolder.Location = new System.Drawing.Point(226, 117);
            this.Y2PlaceHolder.Name = "Y2PlaceHolder";
            this.Y2PlaceHolder.Size = new System.Drawing.Size(125, 52);
            this.Y2PlaceHolder.TabIndex = 5;
            this.Y2PlaceHolder.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Answer1PlaceHolder
            // 
            this.Answer1PlaceHolder.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Answer1PlaceHolder.Location = new System.Drawing.Point(434, 42);
            this.Answer1PlaceHolder.Name = "Answer1PlaceHolder";
            this.Answer1PlaceHolder.Size = new System.Drawing.Size(125, 52);
            this.Answer1PlaceHolder.TabIndex = 3;
            this.Answer1PlaceHolder.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Answer2PlaceHolder
            // 
            this.Answer2PlaceHolder.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Answer2PlaceHolder.Location = new System.Drawing.Point(434, 117);
            this.Answer2PlaceHolder.Name = "Answer2PlaceHolder";
            this.Answer2PlaceHolder.Size = new System.Drawing.Size(125, 52);
            this.Answer2PlaceHolder.TabIndex = 6;
            this.Answer2PlaceHolder.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answer.Location = new System.Drawing.Point(22, 245);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(0, 46);
            this.answer.TabIndex = 8;
            // 
            // reponsebox
            // 
            this.reponsebox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reponsebox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.reponsebox.Location = new System.Drawing.Point(22, 190);
            this.reponsebox.Name = "reponsebox";
            this.reponsebox.ReadOnly = true;
            this.reponsebox.Size = new System.Drawing.Size(724, 52);
            this.reponsebox.TabIndex = 9;
            this.reponsebox.Text = "Réponse";
            this.reponsebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(22, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Github";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(582, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Documentation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(311, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 36);
            this.button3.TabIndex = 13;
            this.button3.Text = "Informations";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 306);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reponsebox);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.Answer2PlaceHolder);
            this.Controls.Add(this.Answer1PlaceHolder);
            this.Controls.Add(this.Y2PlaceHolder);
            this.Controls.Add(this.Y1PlaceHolder);
            this.Controls.Add(this.X2PlaceHolder);
            this.Controls.Add(this.X1PlaceHolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.Calculate);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "EquationSolver - Yann Berlemont";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Calculate;
        private Label LabelX;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox X1PlaceHolder;
        private TextBox X2PlaceHolder;
        private TextBox Y1PlaceHolder;
        private TextBox Y2PlaceHolder;
        private TextBox Answer1PlaceHolder;
        private TextBox Answer2PlaceHolder;
        private Label answer;
        private TextBox reponsebox;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}