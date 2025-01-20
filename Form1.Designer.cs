namespace Calculadora
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonEqual = new Button();
            buttonVirgul = new Button();
            buttonErase = new Button();
            textBox1 = new TextBox();
            resultado = new Label();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonMulti = new Button();
            buttonDiv = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Location = new Point(12, 121);
            button1.Name = "button1";
            button1.Size = new Size(76, 71);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Location = new Point(94, 121);
            button2.Name = "button2";
            button2.Size = new Size(76, 71);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Location = new Point(176, 121);
            button3.Name = "button3";
            button3.Size = new Size(76, 71);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Location = new Point(12, 198);
            button4.Name = "button4";
            button4.Size = new Size(76, 71);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.Location = new Point(94, 198);
            button5.Name = "button5";
            button5.Size = new Size(76, 71);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Location = new Point(176, 198);
            button6.Name = "button6";
            button6.Size = new Size(76, 71);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonFace;
            button7.Location = new Point(12, 275);
            button7.Name = "button7";
            button7.Size = new Size(76, 71);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonFace;
            button8.Location = new Point(94, 275);
            button8.Name = "button8";
            button8.Size = new Size(76, 71);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ButtonFace;
            button9.Location = new Point(176, 275);
            button9.Name = "button9";
            button9.Size = new Size(76, 71);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.BackColor = SystemColors.ButtonFace;
            button0.Location = new Point(94, 352);
            button0.Name = "button0";
            button0.Size = new Size(76, 71);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.BackColor = SystemColors.ButtonFace;
            buttonEqual.Location = new Point(176, 352);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(76, 71);
            buttonEqual.TabIndex = 11;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = false;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // buttonVirgul
            // 
            buttonVirgul.BackColor = SystemColors.ButtonFace;
            buttonVirgul.Location = new Point(12, 352);
            buttonVirgul.Name = "buttonVirgul";
            buttonVirgul.Size = new Size(76, 71);
            buttonVirgul.TabIndex = 12;
            buttonVirgul.Text = ",";
            buttonVirgul.UseVisualStyleBackColor = false;
            buttonVirgul.Click += buttonVirgul_Click;
            // 
            // buttonErase
            // 
            buttonErase.BackColor = SystemColors.ButtonFace;
            buttonErase.Location = new Point(12, 53);
            buttonErase.Name = "buttonErase";
            buttonErase.Size = new Size(240, 62);
            buttonErase.TabIndex = 13;
            buttonErase.Text = "limpa tudo";
            buttonErase.UseVisualStyleBackColor = false;
            buttonErase.Click += buttonErase_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 35);
            textBox1.TabIndex = 18;
            // 
            // resultado
            // 
            resultado.BackColor = SystemColors.ButtonHighlight;
            resultado.Location = new Point(220, 15);
            resultado.Name = "resultado";
            resultado.Size = new Size(100, 23);
            resultado.TabIndex = 24;
            resultado.TextAlign = ContentAlignment.TopRight;
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = SystemColors.ButtonFace;
            buttonPlus.Location = new Point(258, 53);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(62, 179);
            buttonPlus.TabIndex = 20;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = SystemColors.ButtonFace;
            buttonMinus.Location = new Point(258, 238);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(62, 185);
            buttonMinus.TabIndex = 21;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonMulti
            // 
            buttonMulti.BackColor = SystemColors.ButtonFace;
            buttonMulti.Location = new Point(12, 429);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(158, 71);
            buttonMulti.TabIndex = 22;
            buttonMulti.Text = "X";
            buttonMulti.UseVisualStyleBackColor = false;
            buttonMulti.Click += buttonMulti_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.BackColor = SystemColors.ButtonFace;
            buttonDiv.Location = new Point(176, 429);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(144, 71);
            buttonDiv.TabIndex = 23;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = false;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 505);
            Controls.Add(buttonDiv);
            Controls.Add(buttonMulti);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(resultado);
            Controls.Add(textBox1);
            Controls.Add(buttonErase);
            Controls.Add(buttonVirgul);
            Controls.Add(buttonEqual);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonEqual;
        private Button buttonVirgul;
        private Button buttonErase;
        private TextBox textBox1;
        private Label resultado;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMulti;
        private Button buttonDiv;
    }
}
