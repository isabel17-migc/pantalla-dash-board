namespace pantalla_dash_board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            userControl21 = new UserControl2();
            usuario1 = new usuario();
            tarjetamodulos1 = new tarjetamodulos();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // userControl21
            // 
            userControl21.BackColor = Color.MistyRose;
            userControl21.BorderStyle = BorderStyle.Fixed3D;
            userControl21.Location = new Point(38, 185);
            userControl21.Name = "userControl21";
            userControl21.Size = new Size(243, 126);
            userControl21.TabIndex = 0;
            // 
            // usuario1
            // 
            usuario1.BackColor = Color.MistyRose;
            usuario1.BorderStyle = BorderStyle.Fixed3D;
            usuario1.Location = new Point(38, 340);
            usuario1.Name = "usuario1";
            usuario1.Size = new Size(243, 126);
            usuario1.TabIndex = 1;
            // 
            // tarjetamodulos1
            // 
            tarjetamodulos1.BackColor = Color.MistyRose;
            tarjetamodulos1.BorderStyle = BorderStyle.Fixed3D;
            tarjetamodulos1.Location = new Point(38, 33);
            tarjetamodulos1.Name = "tarjetamodulos1";
            tarjetamodulos1.Size = new Size(243, 127);
            tarjetamodulos1.TabIndex = 2;
            tarjetamodulos1.Load += tarjetamodulos1_Load;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(524, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(622, 517);
            Controls.Add(pictureBox1);
            Controls.Add(tarjetamodulos1);
            Controls.Add(usuario1);
            Controls.Add(userControl21);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private UserControl2 userControl21;
        private usuario usuario1;
        private tarjetamodulos tarjetamodulos1;
        private PictureBox pictureBox1;
    }
}
