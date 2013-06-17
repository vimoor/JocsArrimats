namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tresEnRayaButton = new System.Windows.Forms.Button();
            this.pescaminesButton = new System.Windows.Forms.Button();
            this.JocAnecButton = new System.Windows.Forms.Button();
            this.partxisButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.benbinguda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tresEnRayaButton
            // 
            this.tresEnRayaButton.Location = new System.Drawing.Point(30, 70);
            this.tresEnRayaButton.Name = "tresEnRayaButton";
            this.tresEnRayaButton.Size = new System.Drawing.Size(90, 40);
            this.tresEnRayaButton.TabIndex = 1;
            this.tresEnRayaButton.Text = "Toe Tic Tac";
            this.tresEnRayaButton.UseVisualStyleBackColor = true;
            this.tresEnRayaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pescaminesButton
            // 
            this.pescaminesButton.Location = new System.Drawing.Point(160, 70);
            this.pescaminesButton.Name = "pescaminesButton";
            this.pescaminesButton.Size = new System.Drawing.Size(90, 40);
            this.pescaminesButton.TabIndex = 2;
            this.pescaminesButton.Text = "Pescamines";
            this.pescaminesButton.UseVisualStyleBackColor = true;
            // 
            // JocAnecButton
            // 
            this.JocAnecButton.Location = new System.Drawing.Point(30, 130);
            this.JocAnecButton.Name = "JocAnecButton";
            this.JocAnecButton.Size = new System.Drawing.Size(90, 40);
            this.JocAnecButton.TabIndex = 3;
            this.JocAnecButton.Text = "El Joc de l\'ànec";
            this.JocAnecButton.UseVisualStyleBackColor = true;
            // 
            // partxisButton
            // 
            this.partxisButton.Location = new System.Drawing.Point(160, 130);
            this.partxisButton.Name = "partxisButton";
            this.partxisButton.Size = new System.Drawing.Size(90, 40);
            this.partxisButton.TabIndex = 4;
            this.partxisButton.Text = "El partxís";
            this.partxisButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 250);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // benbinguda
            // 
            this.benbinguda.AutoSize = true;
            this.benbinguda.BackColor = System.Drawing.Color.Transparent;
            this.benbinguda.Location = new System.Drawing.Point(80, 20);
            this.benbinguda.Name = "benbinguda";
            this.benbinguda.Size = new System.Drawing.Size(127, 13);
            this.benbinguda.TabIndex = 0;
            this.benbinguda.Text = "Benvingut als jocs reunits";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.partxisButton);
            this.Controls.Add(this.JocAnecButton);
            this.Controls.Add(this.pescaminesButton);
            this.Controls.Add(this.tresEnRayaButton);
            this.Controls.Add(this.benbinguda);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tresEnRayaButton;
        private System.Windows.Forms.Button pescaminesButton;
        private System.Windows.Forms.Button JocAnecButton;
        private System.Windows.Forms.Button partxisButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label benbinguda;
    }
}

