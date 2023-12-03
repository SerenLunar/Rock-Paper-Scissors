namespace Rock_paper_Scissors
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxRock1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPaper1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxScissors1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxRock2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPaper2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxScissors2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelScore1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelScore2 = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.pictureBoxOk1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxOk2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelPl1 = new System.Windows.Forms.Label();
            this.labelPl2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScissors1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaper2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScissors2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOk1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOk2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.Location = new System.Drawing.Point(269, 459);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "OKey";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSalmon;
            this.button2.Location = new System.Drawing.Point(941, 459);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 37);
            this.button2.TabIndex = 0;
            this.button2.Text = "OKey";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Coral;
            this.button3.Enabled = false;
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(639, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 628);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(274, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSalmon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(946, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player 2";
            // 
            // pictureBoxRock1
            // 
            this.pictureBoxRock1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRock1.Image")));
            this.pictureBoxRock1.Location = new System.Drawing.Point(131, 289);
            this.pictureBoxRock1.Name = "pictureBoxRock1";
            this.pictureBoxRock1.Size = new System.Drawing.Size(99, 93);
            this.pictureBoxRock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRock1.TabIndex = 3;
            this.pictureBoxRock1.TabStop = false;
            this.pictureBoxRock1.Click += new System.EventHandler(this.pictureBoxRock1_Click);
            // 
            // pictureBoxPaper1
            // 
            this.pictureBoxPaper1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPaper1.Image")));
            this.pictureBoxPaper1.Location = new System.Drawing.Point(267, 288);
            this.pictureBoxPaper1.Name = "pictureBoxPaper1";
            this.pictureBoxPaper1.Size = new System.Drawing.Size(99, 93);
            this.pictureBoxPaper1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPaper1.TabIndex = 3;
            this.pictureBoxPaper1.TabStop = false;
            this.pictureBoxPaper1.Click += new System.EventHandler(this.pictureBoxPaper1_Click);
            // 
            // pictureBoxScissors1
            // 
            this.pictureBoxScissors1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxScissors1.Image")));
            this.pictureBoxScissors1.Location = new System.Drawing.Point(399, 289);
            this.pictureBoxScissors1.Name = "pictureBoxScissors1";
            this.pictureBoxScissors1.Size = new System.Drawing.Size(99, 93);
            this.pictureBoxScissors1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxScissors1.TabIndex = 3;
            this.pictureBoxScissors1.TabStop = false;
            this.pictureBoxScissors1.Click += new System.EventHandler(this.pictureBoxScissors1_Click);
            // 
            // pictureBoxRock2
            // 
            this.pictureBoxRock2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRock2.Image")));
            this.pictureBoxRock2.Location = new System.Drawing.Point(804, 289);
            this.pictureBoxRock2.Name = "pictureBoxRock2";
            this.pictureBoxRock2.Size = new System.Drawing.Size(99, 93);
            this.pictureBoxRock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRock2.TabIndex = 3;
            this.pictureBoxRock2.TabStop = false;
            this.pictureBoxRock2.Click += new System.EventHandler(this.pictureBoxRock2_Click);
            // 
            // pictureBoxPaper2
            // 
            this.pictureBoxPaper2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPaper2.Image")));
            this.pictureBoxPaper2.Location = new System.Drawing.Point(940, 289);
            this.pictureBoxPaper2.Name = "pictureBoxPaper2";
            this.pictureBoxPaper2.Size = new System.Drawing.Size(99, 93);
            this.pictureBoxPaper2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPaper2.TabIndex = 3;
            this.pictureBoxPaper2.TabStop = false;
            this.pictureBoxPaper2.Click += new System.EventHandler(this.pictureBoxPaper2_Click);
            // 
            // pictureBoxScissors2
            // 
            this.pictureBoxScissors2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxScissors2.Image")));
            this.pictureBoxScissors2.Location = new System.Drawing.Point(1072, 289);
            this.pictureBoxScissors2.Name = "pictureBoxScissors2";
            this.pictureBoxScissors2.Size = new System.Drawing.Size(99, 93);
            this.pictureBoxScissors2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxScissors2.TabIndex = 3;
            this.pictureBoxScissors2.TabStop = false;
            this.pictureBoxScissors2.Click += new System.EventHandler(this.pictureBoxScissors2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(40, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Score: ";
            // 
            // labelScore1
            // 
            this.labelScore1.AutoSize = true;
            this.labelScore1.Location = new System.Drawing.Point(103, 54);
            this.labelScore1.Name = "labelScore1";
            this.labelScore1.Size = new System.Drawing.Size(14, 13);
            this.labelScore1.TabIndex = 5;
            this.labelScore1.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Location = new System.Drawing.Point(1129, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Score: ";
            // 
            // labelScore2
            // 
            this.labelScore2.AutoSize = true;
            this.labelScore2.Location = new System.Drawing.Point(1192, 54);
            this.labelScore2.Name = "labelScore2";
            this.labelScore2.Size = new System.Drawing.Size(14, 13);
            this.labelScore2.TabIndex = 5;
            this.labelScore2.Text = "0";
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.Color.MistyRose;
            this.buttonGo.Location = new System.Drawing.Point(596, 305);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(108, 76);
            this.buttonGo.TabIndex = 7;
            this.buttonGo.Text = "Gooo";
            this.buttonGo.UseVisualStyleBackColor = false;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // pictureBoxOk1
            // 
            this.pictureBoxOk1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOk1.Image")));
            this.pictureBoxOk1.Location = new System.Drawing.Point(219, 234);
            this.pictureBoxOk1.Name = "pictureBoxOk1";
            this.pictureBoxOk1.Size = new System.Drawing.Size(210, 210);
            this.pictureBoxOk1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOk1.TabIndex = 8;
            this.pictureBoxOk1.TabStop = false;
            this.pictureBoxOk1.Visible = false;
            // 
            // pictureBoxOk2
            // 
            this.pictureBoxOk2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOk2.Image")));
            this.pictureBoxOk2.Location = new System.Drawing.Point(889, 234);
            this.pictureBoxOk2.Name = "pictureBoxOk2";
            this.pictureBoxOk2.Size = new System.Drawing.Size(210, 210);
            this.pictureBoxOk2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOk2.TabIndex = 8;
            this.pictureBoxOk2.TabStop = false;
            this.pictureBoxOk2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelPl1
            // 
            this.labelPl1.AutoSize = true;
            this.labelPl1.BackColor = System.Drawing.Color.Coral;
            this.labelPl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPl1.Location = new System.Drawing.Point(528, 54);
            this.labelPl1.Name = "labelPl1";
            this.labelPl1.Size = new System.Drawing.Size(21, 24);
            this.labelPl1.TabIndex = 9;
            this.labelPl1.Text = "0";
            // 
            // labelPl2
            // 
            this.labelPl2.AutoSize = true;
            this.labelPl2.BackColor = System.Drawing.Color.Coral;
            this.labelPl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPl2.Location = new System.Drawing.Point(753, 54);
            this.labelPl2.Name = "labelPl2";
            this.labelPl2.Size = new System.Drawing.Size(21, 24);
            this.labelPl2.TabIndex = 9;
            this.labelPl2.Text = "0";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 623);
            this.Controls.Add(this.labelPl2);
            this.Controls.Add(this.labelPl1);
            this.Controls.Add(this.pictureBoxOk2);
            this.Controls.Add(this.pictureBoxOk1);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.labelScore2);
            this.Controls.Add(this.labelScore1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxScissors2);
            this.Controls.Add(this.pictureBoxScissors1);
            this.Controls.Add(this.pictureBoxPaper2);
            this.Controls.Add(this.pictureBoxRock2);
            this.Controls.Add(this.pictureBoxPaper1);
            this.Controls.Add(this.pictureBoxRock1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScissors1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaper2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScissors2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOk1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOk2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxRock1;
        private System.Windows.Forms.PictureBox pictureBoxPaper1;
        private System.Windows.Forms.PictureBox pictureBoxScissors1;
        private System.Windows.Forms.PictureBox pictureBoxRock2;
        private System.Windows.Forms.PictureBox pictureBoxPaper2;
        private System.Windows.Forms.PictureBox pictureBoxScissors2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelScore1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelScore2;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.PictureBox pictureBoxOk1;
        private System.Windows.Forms.PictureBox pictureBoxOk2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelPl1;
        private System.Windows.Forms.Label labelPl2;
        private System.Windows.Forms.Timer timer2;
    }
}

