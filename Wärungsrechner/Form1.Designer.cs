namespace Wärungsrechner
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
            title = new TextBox();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            pictureBox2 = new PictureBox();
            input_money = new TextBox();
            output_money = new TextBox();
            submit_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.BackColor = SystemColors.InactiveCaption;
            title.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title.ForeColor = SystemColors.ActiveCaptionText;
            title.Location = new Point(272, 28);
            title.Name = "title";
            title.Size = new Size(244, 39);
            title.TabIndex = 0;
            title.Text = "Währungsrechner";
            title.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(192, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 72);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "CHF - Euro", "CHF - Dollar", "Euro - CHF", "Euro - Dollar", "Dollar - CHF", "Dollar - Euro" });
            comboBox1.Location = new Point(272, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(244, 23);
            comboBox1.TabIndex = 2;
            comboBox1.UseWaitCursor = true;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveBorder;
            pictureBox2.Location = new Point(192, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(410, 261);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // input_money
            // 
            input_money.Location = new Point(272, 251);
            input_money.Name = "input_money";
            input_money.PlaceholderText = "Your Currency";
            input_money.Size = new Size(244, 23);
            input_money.TabIndex = 4;
            input_money.TextAlign = HorizontalAlignment.Center;
            input_money.TextChanged += input_money_TextChanged;
            // 
            // output_money
            // 
            output_money.Location = new Point(272, 309);
            output_money.Name = "output_money";
            output_money.PlaceholderText = "selected Currency";
            output_money.Size = new Size(244, 23);
            output_money.TabIndex = 5;
            output_money.TextAlign = HorizontalAlignment.Center;
            output_money.TextChanged += output_money_TextChanged;
            // 
            // submit_button
            // 
            submit_button.BackColor = Color.LawnGreen;
            submit_button.ForeColor = Color.Black;
            submit_button.Location = new Point(354, 280);
            submit_button.Name = "submit_button";
            submit_button.Size = new Size(75, 23);
            submit_button.TabIndex = 6;
            submit_button.Text = "submit";
            submit_button.UseVisualStyleBackColor = false;
            submit_button.Click += submit_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 450);
            Controls.Add(submit_button);
            Controls.Add(output_money);
            Controls.Add(input_money);
            Controls.Add(comboBox1);
            Controls.Add(title);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox title;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private PictureBox pictureBox2;
        private TextBox input_money;
        private TextBox output_money;
        private Button submit_button;
    }
}
