namespace WinAppImplementacion
{
    partial class Main
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
            this.PbxPantalla = new System.Windows.Forms.PictureBox();
            this.BtnInterpolar = new System.Windows.Forms.Button();
            this.BtnInterpolarHorizontal = new System.Windows.Forms.Button();
            this.BnEjes3D = new System.Windows.Forms.Button();
            this.BtnSuperficie3D = new System.Windows.Forms.Button();
            this.BtnResorte = new System.Windows.Forms.Button();
            this.BtnTiroParabolico = new System.Windows.Forms.Button();
            this.BtnEjes2D = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPantalla)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxPantalla
            // 
            this.PbxPantalla.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PbxPantalla.Location = new System.Drawing.Point(56, 12);
            this.PbxPantalla.Name = "PbxPantalla";
            this.PbxPantalla.Size = new System.Drawing.Size(700, 420);
            this.PbxPantalla.TabIndex = 0;
            this.PbxPantalla.TabStop = false;
            this.PbxPantalla.Click += new System.EventHandler(this.PbxPantalla_Click);
            // 
            // BtnInterpolar
            // 
            this.BtnInterpolar.Location = new System.Drawing.Point(56, 464);
            this.BtnInterpolar.Name = "BtnInterpolar";
            this.BtnInterpolar.Size = new System.Drawing.Size(93, 23);
            this.BtnInterpolar.TabIndex = 1;
            this.BtnInterpolar.Text = "Interpolar V";
            this.BtnInterpolar.UseVisualStyleBackColor = true;
            this.BtnInterpolar.Click += new System.EventHandler(this.BtnInterpolar_Click);
            // 
            // BtnInterpolarHorizontal
            // 
            this.BtnInterpolarHorizontal.Location = new System.Drawing.Point(165, 465);
            this.BtnInterpolarHorizontal.Name = "BtnInterpolarHorizontal";
            this.BtnInterpolarHorizontal.Size = new System.Drawing.Size(88, 23);
            this.BtnInterpolarHorizontal.TabIndex = 2;
            this.BtnInterpolarHorizontal.Text = "Interpolar H";
            this.BtnInterpolarHorizontal.UseVisualStyleBackColor = true;
            this.BtnInterpolarHorizontal.Click += new System.EventHandler(this.BtnInterpolarHorizontal_Click);
            // 
            // BnEjes3D
            // 
            this.BnEjes3D.Location = new System.Drawing.Point(274, 464);
            this.BnEjes3D.Name = "BnEjes3D";
            this.BnEjes3D.Size = new System.Drawing.Size(75, 23);
            this.BnEjes3D.TabIndex = 3;
            this.BnEjes3D.Text = "Ejes 3D";
            this.BnEjes3D.UseVisualStyleBackColor = true;
            this.BnEjes3D.Click += new System.EventHandler(this.BnEjes3D_Click);
            // 
            // BtnSuperficie3D
            // 
            this.BtnSuperficie3D.Location = new System.Drawing.Point(366, 464);
            this.BtnSuperficie3D.Name = "BtnSuperficie3D";
            this.BtnSuperficie3D.Size = new System.Drawing.Size(92, 23);
            this.BtnSuperficie3D.TabIndex = 4;
            this.BtnSuperficie3D.Text = "Superficie3D";
            this.BtnSuperficie3D.UseVisualStyleBackColor = true;
            this.BtnSuperficie3D.Click += new System.EventHandler(this.BtnSuperficie3D_Click);
            // 
            // BtnResorte
            // 
            this.BtnResorte.Location = new System.Drawing.Point(483, 465);
            this.BtnResorte.Name = "BtnResorte";
            this.BtnResorte.Size = new System.Drawing.Size(75, 23);
            this.BtnResorte.TabIndex = 5;
            this.BtnResorte.Text = "Resorte";
            this.BtnResorte.UseVisualStyleBackColor = true;
            this.BtnResorte.Click += new System.EventHandler(this.BtnResorte_Click);
            // 
            // BtnTiroParabolico
            // 
            this.BtnTiroParabolico.Location = new System.Drawing.Point(584, 466);
            this.BtnTiroParabolico.Name = "BtnTiroParabolico";
            this.BtnTiroParabolico.Size = new System.Drawing.Size(75, 23);
            this.BtnTiroParabolico.TabIndex = 6;
            this.BtnTiroParabolico.Text = "Tiro";
            this.BtnTiroParabolico.UseVisualStyleBackColor = true;
            this.BtnTiroParabolico.Click += new System.EventHandler(this.BtnTiroParabolico_Click);
            // 
            // BtnEjes2D
            // 
            this.BtnEjes2D.Location = new System.Drawing.Point(59, 508);
            this.BtnEjes2D.Name = "BtnEjes2D";
            this.BtnEjes2D.Size = new System.Drawing.Size(75, 23);
            this.BtnEjes2D.TabIndex = 7;
            this.BtnEjes2D.Text = "Ejes 2D";
            this.BtnEjes2D.UseVisualStyleBackColor = true;
            this.BtnEjes2D.Click += new System.EventHandler(this.BtnEjes2D_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(835, 545);
            this.Controls.Add(this.BtnEjes2D);
            this.Controls.Add(this.BtnTiroParabolico);
            this.Controls.Add(this.BtnResorte);
            this.Controls.Add(this.BtnSuperficie3D);
            this.Controls.Add(this.BnEjes3D);
            this.Controls.Add(this.BtnInterpolarHorizontal);
            this.Controls.Add(this.BtnInterpolar);
            this.Controls.Add(this.PbxPantalla);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.PbxPantalla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox PbxPantalla;
        private Button BtnInterpolar;
        private Button BtnInterpolarHorizontal;
        private Button BnEjes3D;
        private Button BtnSuperficie3D;
        private Button BtnResorte;
        private Button BtnTiroParabolico;
        private Button BtnEjes2D;
    }
}