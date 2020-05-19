namespace Interfaz
{
    partial class Arkanoid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arkanoid));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ArkanoidTitle = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.Button();
            this.Instructions = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.ArkanoidTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ArkanoidTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Play, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Instructions, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Score, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Exit, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(943, 668);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ArkanoidTitle
            // 
            this.ArkanoidTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ArkanoidTitle.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("ArkanoidTitle.BackgroundImage")));
            this.ArkanoidTitle.Location = new System.Drawing.Point(220, 3);
            this.ArkanoidTitle.Name = "ArkanoidTitle";
            this.ArkanoidTitle.Size = new System.Drawing.Size(500, 182);
            this.ArkanoidTitle.TabIndex = 0;
            this.ArkanoidTitle.TabStop = false;
            // 
            // Play
            // 
            this.Play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Play.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("Play.BackgroundImage")));
            this.Play.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Play.Location = new System.Drawing.Point(409, 255);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(122, 64);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Instructions
            // 
            this.Instructions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Instructions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Instructions.BackColor = System.Drawing.Color.Transparent;
            this.Instructions.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("Instructions.BackgroundImage")));
            this.Instructions.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Instructions.Location = new System.Drawing.Point(409, 363);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(122, 64);
            this.Instructions.TabIndex = 2;
            this.Instructions.Text = "Instructions";
            this.Instructions.UseVisualStyleBackColor = false;
            this.Instructions.Click += new System.EventHandler(this.Instructions_Click);
            // 
            // Score
            // 
            this.Score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Score.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("Score.BackgroundImage")));
            this.Score.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Score.Location = new System.Drawing.Point(409, 471);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(122, 64);
            this.Score.TabIndex = 3;
            this.Score.Text = "Score";
            this.Score.UseVisualStyleBackColor = false;
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("Exit.BackgroundImage")));
            this.Exit.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Exit.Location = new System.Drawing.Point(409, 580);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(122, 64);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Arkanoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(943, 668);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "Arkanoid";
            this.Text = "Arkanoid";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.ArkanoidTitle)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox ArkanoidTitle;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Instructions;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Score;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}