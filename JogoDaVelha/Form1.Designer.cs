namespace JogoDaVelha
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnA1 = new Button();
            btnA2 = new Button();
            btnA3 = new Button();
            btnB1 = new Button();
            btnB2 = new Button();
            btnB3 = new Button();
            btnC1 = new Button();
            btnC2 = new Button();
            btnC3 = new Button();
            btnFechar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblHora = new Label();
            lblJogadorInfo = new Label();
            btnReiniciar = new Button();
            SuspendLayout();
            // 
            // btnA1
            // 
            btnA1.BackColor = Color.LimeGreen;
            btnA1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnA1.ForeColor = Color.Blue;
            btnA1.Location = new Point(78, 126);
            btnA1.Name = "btnA1";
            btnA1.Size = new Size(90, 123);
            btnA1.TabIndex = 0;
            btnA1.Text = "X";
            btnA1.UseVisualStyleBackColor = false;
            btnA1.Click += btnA1_Click;
            // 
            // btnA2
            // 
            btnA2.BackColor = Color.LimeGreen;
            btnA2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnA2.ForeColor = Color.Blue;
            btnA2.Location = new Point(241, 126);
            btnA2.Name = "btnA2";
            btnA2.Size = new Size(90, 123);
            btnA2.TabIndex = 1;
            btnA2.Text = "X";
            btnA2.UseVisualStyleBackColor = false;
            btnA2.Click += btnA2_Click;
            // 
            // btnA3
            // 
            btnA3.BackColor = Color.LimeGreen;
            btnA3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnA3.ForeColor = Color.Blue;
            btnA3.Location = new Point(383, 126);
            btnA3.Name = "btnA3";
            btnA3.Size = new Size(90, 123);
            btnA3.TabIndex = 2;
            btnA3.Text = "X";
            btnA3.UseVisualStyleBackColor = false;
            btnA3.Click += btnA3_Click;
            // 
            // btnB1
            // 
            btnB1.BackColor = Color.LimeGreen;
            btnB1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnB1.ForeColor = Color.Blue;
            btnB1.Location = new Point(78, 293);
            btnB1.Name = "btnB1";
            btnB1.Size = new Size(90, 123);
            btnB1.TabIndex = 3;
            btnB1.Text = "X";
            btnB1.UseVisualStyleBackColor = false;
            btnB1.Click += btnB1_Click;
            // 
            // btnB2
            // 
            btnB2.BackColor = Color.LimeGreen;
            btnB2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnB2.ForeColor = Color.Blue;
            btnB2.Location = new Point(241, 293);
            btnB2.Name = "btnB2";
            btnB2.Size = new Size(90, 123);
            btnB2.TabIndex = 4;
            btnB2.Text = "X";
            btnB2.UseVisualStyleBackColor = false;
            btnB2.Click += btnB2_Click;
            // 
            // btnB3
            // 
            btnB3.BackColor = Color.LimeGreen;
            btnB3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnB3.ForeColor = Color.Blue;
            btnB3.Location = new Point(383, 293);
            btnB3.Name = "btnB3";
            btnB3.Size = new Size(90, 123);
            btnB3.TabIndex = 5;
            btnB3.Text = "X";
            btnB3.UseVisualStyleBackColor = false;
            btnB3.Click += btnB3_Click;
            // 
            // btnC1
            // 
            btnC1.BackColor = Color.LimeGreen;
            btnC1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnC1.ForeColor = Color.Blue;
            btnC1.Location = new Point(78, 443);
            btnC1.Name = "btnC1";
            btnC1.Size = new Size(90, 123);
            btnC1.TabIndex = 6;
            btnC1.Text = "X";
            btnC1.UseVisualStyleBackColor = false;
            btnC1.Click += btnC1_Click;
            // 
            // btnC2
            // 
            btnC2.BackColor = Color.LimeGreen;
            btnC2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnC2.ForeColor = Color.Blue;
            btnC2.Location = new Point(241, 443);
            btnC2.Name = "btnC2";
            btnC2.Size = new Size(90, 123);
            btnC2.TabIndex = 7;
            btnC2.Text = "X";
            btnC2.UseVisualStyleBackColor = false;
            btnC2.Click += btnC2_Click;
            // 
            // btnC3
            // 
            btnC3.BackColor = Color.LimeGreen;
            btnC3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnC3.ForeColor = Color.Blue;
            btnC3.Location = new Point(383, 443);
            btnC3.Name = "btnC3";
            btnC3.Size = new Size(90, 123);
            btnC3.TabIndex = 8;
            btnC3.Text = "X";
            btnC3.UseVisualStyleBackColor = false;
            btnC3.Click += btnC3_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.DarkRed;
            btnFechar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(525, 1);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(30, 32);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Black;
            lblHora.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = Color.White;
            lblHora.Location = new Point(3, 580);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(112, 32);
            lblHora.TabIndex = 10;
            lblHora.Text = "00:00:00";
            // 
            // lblJogadorInfo
            // 
            lblJogadorInfo.AutoSize = true;
            lblJogadorInfo.BackColor = Color.Blue;
            lblJogadorInfo.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJogadorInfo.ForeColor = Color.AliceBlue;
            lblJogadorInfo.Location = new Point(12, 31);
            lblJogadorInfo.Name = "lblJogadorInfo";
            lblJogadorInfo.Size = new Size(63, 24);
            lblJogadorInfo.TabIndex = 11;
            lblJogadorInfo.Text = "label1";
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.DarkRed;
            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.Location = new Point(469, 580);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(75, 31);
            btnReiniciar.TabIndex = 12;
            btnReiniciar.Text = "REINICIAR";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(556, 649);
            Controls.Add(btnReiniciar);
            Controls.Add(lblJogadorInfo);
            Controls.Add(lblHora);
            Controls.Add(btnFechar);
            Controls.Add(btnC3);
            Controls.Add(btnC2);
            Controls.Add(btnC1);
            Controls.Add(btnB3);
            Controls.Add(btnB2);
            Controls.Add(btnB1);
            Controls.Add(btnA3);
            Controls.Add(btnA2);
            Controls.Add(btnA1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnA1;
        private Button btnA2;
        private Button btnA3;
        private Button btnB1;
        private Button btnB2;
        private Button btnB3;
        private Button btnC1;
        private Button btnC2;
        private Button btnC3;
        private Button btnFechar;
        private System.Windows.Forms.Timer timer1;
        private Label lblHora;
        private Label lblJogadorInfo;
        private Button btnReiniciar;
    }
}
