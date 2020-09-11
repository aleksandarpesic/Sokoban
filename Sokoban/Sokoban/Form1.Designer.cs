namespace Sokoban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetujNivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vratiPotezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zavrsiOvdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_izadji = new System.Windows.Forms.Label();
            this.lbl_play = new System.Windows.Forms.Label();
            this.lbl_userManual = new System.Windows.Forms.Label();
            this.textBox_uputstvo = new System.Windows.Forms.TextBox();
            this.lbl_rez = new System.Windows.Forms.Label();
            this.lbl_nazad = new System.Windows.Forms.Label();
            this.textBox_zaUpisRez = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_reset = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.resetujNivoToolStripMenuItem,
            this.vratiPotezToolStripMenuItem,
            this.zavrsiOvdeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 27);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(126, 23);
            this.toolStripMenuItem1.Text = "Trenutni nivo: ";
            // 
            // resetujNivoToolStripMenuItem
            // 
            this.resetujNivoToolStripMenuItem.Name = "resetujNivoToolStripMenuItem";
            this.resetujNivoToolStripMenuItem.Size = new System.Drawing.Size(109, 23);
            this.resetujNivoToolStripMenuItem.Text = "Resetuj nivo";
            this.resetujNivoToolStripMenuItem.Click += new System.EventHandler(this.resetujNivoToolStripMenuItem_Click);
            // 
            // vratiPotezToolStripMenuItem
            // 
            this.vratiPotezToolStripMenuItem.Name = "vratiPotezToolStripMenuItem";
            this.vratiPotezToolStripMenuItem.Size = new System.Drawing.Size(101, 23);
            this.vratiPotezToolStripMenuItem.Text = "Vrati potez";
            this.vratiPotezToolStripMenuItem.Click += new System.EventHandler(this.vratiPotezToolStripMenuItem_Click);
            // 
            // zavrsiOvdeToolStripMenuItem
            // 
            this.zavrsiOvdeToolStripMenuItem.Name = "zavrsiOvdeToolStripMenuItem";
            this.zavrsiOvdeToolStripMenuItem.Size = new System.Drawing.Size(177, 23);
            this.zavrsiOvdeToolStripMenuItem.Text = "Zapamti i zavrsi ovde";
            this.zavrsiOvdeToolStripMenuItem.Click += new System.EventHandler(this.zavrsiOvdeToolStripMenuItem_Click);
            // 
            // lbl_izadji
            // 
            this.lbl_izadji.AutoSize = true;
            this.lbl_izadji.Font = new System.Drawing.Font("Rockwell", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_izadji.Location = new System.Drawing.Point(100, 281);
            this.lbl_izadji.Name = "lbl_izadji";
            this.lbl_izadji.Size = new System.Drawing.Size(110, 49);
            this.lbl_izadji.TabIndex = 0;
            this.lbl_izadji.Text = "Izađi";
            this.lbl_izadji.Click += new System.EventHandler(this.lab_izadji_Click);
            this.lbl_izadji.MouseLeave += new System.EventHandler(this.lab_izadji_MouseLeave);
            this.lbl_izadji.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lab_izadji_MouseMove);
            // 
            // lbl_play
            // 
            this.lbl_play.AutoSize = true;
            this.lbl_play.Font = new System.Drawing.Font("Rockwell", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_play.Location = new System.Drawing.Point(100, 65);
            this.lbl_play.Name = "lbl_play";
            this.lbl_play.Size = new System.Drawing.Size(115, 49);
            this.lbl_play.TabIndex = 1;
            this.lbl_play.Text = "Igraj";
            this.lbl_play.Click += new System.EventHandler(this.lbl_play_Click);
            this.lbl_play.MouseLeave += new System.EventHandler(this.lbl_play_MouseLeave);
            this.lbl_play.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_play_MouseMove);
            // 
            // lbl_userManual
            // 
            this.lbl_userManual.AutoSize = true;
            this.lbl_userManual.Font = new System.Drawing.Font("Rockwell", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userManual.Location = new System.Drawing.Point(100, 148);
            this.lbl_userManual.Name = "lbl_userManual";
            this.lbl_userManual.Size = new System.Drawing.Size(196, 49);
            this.lbl_userManual.TabIndex = 2;
            this.lbl_userManual.Text = "Uputstvo";
            this.lbl_userManual.Click += new System.EventHandler(this.lbl_userManual_Click);
            this.lbl_userManual.MouseLeave += new System.EventHandler(this.lbl_userManual_MouseLeave);
            this.lbl_userManual.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_userManual_MouseMove);
            // 
            // textBox_uputstvo
            // 
            this.textBox_uputstvo.Enabled = false;
            this.textBox_uputstvo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_uputstvo.Location = new System.Drawing.Point(464, 94);
            this.textBox_uputstvo.Multiline = true;
            this.textBox_uputstvo.Name = "textBox_uputstvo";
            this.textBox_uputstvo.Size = new System.Drawing.Size(189, 192);
            this.textBox_uputstvo.TabIndex = 3;
            this.textBox_uputstvo.Text = resources.GetString("textBox_uputstvo.Text");
            this.textBox_uputstvo.Visible = false;
            // 
            // lbl_rez
            // 
            this.lbl_rez.AutoSize = true;
            this.lbl_rez.Font = new System.Drawing.Font("Rockwell", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rez.Location = new System.Drawing.Point(107, 222);
            this.lbl_rez.Name = "lbl_rez";
            this.lbl_rez.Size = new System.Drawing.Size(189, 49);
            this.lbl_rez.TabIndex = 6;
            this.lbl_rez.Text = "Rezultati";
            this.lbl_rez.Click += new System.EventHandler(this.lbl_rez_Click);
            this.lbl_rez.MouseLeave += new System.EventHandler(this.lbl_rez_MouseLeave);
            this.lbl_rez.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_rez_MouseMove);
            // 
            // lbl_nazad
            // 
            this.lbl_nazad.AutoSize = true;
            this.lbl_nazad.Font = new System.Drawing.Font("Rockwell", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nazad.Location = new System.Drawing.Point(109, 365);
            this.lbl_nazad.Name = "lbl_nazad";
            this.lbl_nazad.Size = new System.Drawing.Size(145, 49);
            this.lbl_nazad.TabIndex = 7;
            this.lbl_nazad.Text = "Nazad";
            this.lbl_nazad.Visible = false;
            this.lbl_nazad.Click += new System.EventHandler(this.lbl_nazad_Click);
            this.lbl_nazad.MouseLeave += new System.EventHandler(this.lbl_nazad_MouseLeave);
            this.lbl_nazad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_nazad_MouseMove);
            // 
            // textBox_zaUpisRez
            // 
            this.textBox_zaUpisRez.Enabled = false;
            this.textBox_zaUpisRez.Location = new System.Drawing.Point(305, 80);
            this.textBox_zaUpisRez.Name = "textBox_zaUpisRez";
            this.textBox_zaUpisRez.Size = new System.Drawing.Size(122, 20);
            this.textBox_zaUpisRez.TabIndex = 3;
            this.textBox_zaUpisRez.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 403);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lbl_reset
            // 
            this.lbl_reset.AutoSize = true;
            this.lbl_reset.Font = new System.Drawing.Font("Rockwell", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reset.Location = new System.Drawing.Point(240, 283);
            this.lbl_reset.Name = "lbl_reset";
            this.lbl_reset.Size = new System.Drawing.Size(263, 49);
            this.lbl_reset.TabIndex = 10;
            this.lbl_reset.Text = "Resetuj nivo";
            this.lbl_reset.Click += new System.EventHandler(this.lbl_reset_Click);
            this.lbl_reset.MouseLeave += new System.EventHandler(this.lbl_reset_MouseLeave);
            this.lbl_reset.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_reset_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sokoban.Properties.Resources.Grey_Squares_Background;
            this.ClientSize = new System.Drawing.Size(799, 403);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_reset);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_nazad);
            this.Controls.Add(this.lbl_rez);
            this.Controls.Add(this.textBox_zaUpisRez);
            this.Controls.Add(this.textBox_uputstvo);
            this.Controls.Add(this.lbl_izadji);
            this.Controls.Add(this.lbl_userManual);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl_play);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetujNivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zavrsiOvdeToolStripMenuItem;
        private System.Windows.Forms.Label lbl_izadji;
        private System.Windows.Forms.Label lbl_play;
        private System.Windows.Forms.Label lbl_userManual;
        private System.Windows.Forms.TextBox textBox_uputstvo;
        private System.Windows.Forms.ToolStripItem TrenutniNivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lbl_rez;
        private System.Windows.Forms.Label lbl_nazad;
        private System.Windows.Forms.TextBox textBox_zaUpisRez;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem vratiPotezToolStripMenuItem;
        private System.Windows.Forms.Label lbl_reset;
    }
}

