
namespace imageView
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_ilk = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_random = new System.Windows.Forms.Button();
            this.btn_slayt = new System.Windows.Forms.Button();
            this.ileri = new System.Windows.Forms.Button();
            this.btn_son = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(236, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 342);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 426);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_ilk
            // 
            this.btn_ilk.Location = new System.Drawing.Point(268, 377);
            this.btn_ilk.Name = "btn_ilk";
            this.btn_ilk.Size = new System.Drawing.Size(76, 23);
            this.btn_ilk.TabIndex = 2;
            this.btn_ilk.Text = "<<";
            this.btn_ilk.UseVisualStyleBackColor = true;
            this.btn_ilk.Click += new System.EventHandler(this.btn_ilk_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(350, 377);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(76, 23);
            this.btn_geri.TabIndex = 2;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_random
            // 
            this.btn_random.Location = new System.Drawing.Point(432, 377);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(76, 23);
            this.btn_random.TabIndex = 2;
            this.btn_random.Text = "Random";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // btn_slayt
            // 
            this.btn_slayt.Location = new System.Drawing.Point(514, 377);
            this.btn_slayt.Name = "btn_slayt";
            this.btn_slayt.Size = new System.Drawing.Size(76, 23);
            this.btn_slayt.TabIndex = 2;
            this.btn_slayt.Text = "Slayt";
            this.btn_slayt.UseVisualStyleBackColor = true;
            this.btn_slayt.Click += new System.EventHandler(this.btn_slayt_Click);
            // 
            // ileri
            // 
            this.ileri.Location = new System.Drawing.Point(596, 377);
            this.ileri.Name = "ileri";
            this.ileri.Size = new System.Drawing.Size(76, 23);
            this.ileri.TabIndex = 2;
            this.ileri.Text = ">";
            this.ileri.UseVisualStyleBackColor = true;
            this.ileri.Click += new System.EventHandler(this.ileri_Click);
            // 
            // btn_son
            // 
            this.btn_son.Location = new System.Drawing.Point(678, 377);
            this.btn_son.Name = "btn_son";
            this.btn_son.Size = new System.Drawing.Size(76, 23);
            this.btn_son.TabIndex = 2;
            this.btn_son.Text = ">>";
            this.btn_son.UseVisualStyleBackColor = true;
            this.btn_son.Click += new System.EventHandler(this.btn_son_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_son);
            this.Controls.Add(this.ileri);
            this.Controls.Add(this.btn_slayt);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_ilk);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_ilk;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.Button btn_slayt;
        private System.Windows.Forms.Button ileri;
        private System.Windows.Forms.Button btn_son;
    }
}

