
namespace FluppyBird
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
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.pipeButtom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeButtom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::FluppyBird.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(362, -3);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(100, 178);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.Image = global::FluppyBird.Properties.Resources.bird;
            this.Bird.Location = new System.Drawing.Point(39, 242);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(80, 67);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 1;
            this.Bird.TabStop = false;
            // 
            // pipeButtom
            // 
            this.pipeButtom.Image = global::FluppyBird.Properties.Resources.pipe;
            this.pipeButtom.Location = new System.Drawing.Point(325, 330);
            this.pipeButtom.Name = "pipeButtom";
            this.pipeButtom.Size = new System.Drawing.Size(100, 186);
            this.pipeButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeButtom.TabIndex = 2;
            this.pipeButtom.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::FluppyBird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-2, 509);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(464, 104);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.Location = new System.Drawing.Point(22, 27);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(138, 36);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.newTimer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(454, 608);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeButtom);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.pipeTop);
            this.Name = "Form1";
            this.Text = "Flappy Bird GAME";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeButtom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox pipeButtom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

