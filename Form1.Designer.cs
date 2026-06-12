namespace EscapeRoomDigital
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
            titleName = new Label();
            btnPLAY = new Button();
            panelLaboratorio = new Panel();
            picComputadora = new PictureBox();
            panelHistoria = new Panel();
            labelContexto = new Label();
            btnEntendido = new Button();
            labelHistoria = new Label();
            panelLaboratorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picComputadora).BeginInit();
            panelHistoria.SuspendLayout();
            SuspendLayout();
            // 
            // titleName
            // 
            titleName.AutoSize = true;
            titleName.BackColor = Color.Transparent;
            titleName.FlatStyle = FlatStyle.Flat;
            titleName.Font = new Font("Impact", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleName.ForeColor = Color.Black;
            titleName.Location = new Point(58, 47);
            titleName.Name = "titleName";
            titleName.Size = new Size(1184, 117);
            titleName.TabIndex = 0;
            titleName.Text = "Area 51: The Escape Protocol";
            titleName.Click += label1_Click;
            // 
            // btnPLAY
            // 
            btnPLAY.BackColor = Color.Transparent;
            btnPLAY.FlatStyle = FlatStyle.Flat;
            btnPLAY.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPLAY.ForeColor = Color.Black;
            btnPLAY.Location = new Point(1326, 762);
            btnPLAY.Name = "btnPLAY";
            btnPLAY.Size = new Size(249, 136);
            btnPLAY.TabIndex = 1;
            btnPLAY.Text = "PLAY";
            btnPLAY.UseVisualStyleBackColor = false;
            btnPLAY.Click += btnIniciar_Click;
            // 
            // panelLaboratorio
            // 
            panelLaboratorio.BackgroundImage = (Image)resources.GetObject("panelLaboratorio.BackgroundImage");
            panelLaboratorio.BackgroundImageLayout = ImageLayout.Stretch;
            panelLaboratorio.Controls.Add(picComputadora);
            panelLaboratorio.Controls.Add(panelHistoria);
            panelLaboratorio.Controls.Add(labelHistoria);
            panelLaboratorio.Dock = DockStyle.Fill;
            panelLaboratorio.Location = new Point(0, 0);
            panelLaboratorio.Name = "panelLaboratorio";
            panelLaboratorio.Size = new Size(1898, 1024);
            panelLaboratorio.TabIndex = 2;
            panelLaboratorio.Visible = false;
            panelLaboratorio.Paint += panelLaboratorio_Paint;
            // 
            // picComputadora
            // 
            picComputadora.BackColor = Color.Transparent;
            picComputadora.Cursor = Cursors.Hand;
            picComputadora.Location = new Point(85, 448);
            picComputadora.Name = "picComputadora";
            picComputadora.Size = new Size(180, 162);
            picComputadora.TabIndex = 1;
            picComputadora.TabStop = false;
            picComputadora.Visible = false;
            picComputadora.Click += pictureBox1_Click;
            // 
            // panelHistoria
            // 
            panelHistoria.BackColor = SystemColors.ActiveCaptionText;
            panelHistoria.Controls.Add(labelContexto);
            panelHistoria.Controls.Add(btnEntendido);
            panelHistoria.Location = new Point(481, 138);
            panelHistoria.Name = "panelHistoria";
            panelHistoria.Size = new Size(903, 513);
            panelHistoria.TabIndex = 0;
            // 
            // labelContexto
            // 
            labelContexto.AutoSize = true;
            labelContexto.BackColor = Color.Transparent;
            labelContexto.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContexto.ForeColor = Color.White;
            labelContexto.Location = new Point(58, 113);
            labelContexto.Name = "labelContexto";
            labelContexto.Size = new Size(84, 35);
            labelContexto.TabIndex = 1;
            labelContexto.Text = "label1";
            labelContexto.Click += labelContexto_Click;
            // 
            // btnEntendido
            // 
            btnEntendido.BackColor = Color.Transparent;
            btnEntendido.Location = new Point(742, 459);
            btnEntendido.Name = "btnEntendido";
            btnEntendido.Size = new Size(131, 34);
            btnEntendido.TabIndex = 1;
            btnEntendido.Text = "Entendido";
            btnEntendido.UseVisualStyleBackColor = false;
            btnEntendido.Click += btnEntendido_Click;
            // 
            // labelHistoria
            // 
            labelHistoria.AutoSize = true;
            labelHistoria.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHistoria.ForeColor = Color.White;
            labelHistoria.Location = new Point(-1898, 636);
            labelHistoria.Name = "labelHistoria";
            labelHistoria.Size = new Size(0, 25);
            labelHistoria.TabIndex = 0;
            labelHistoria.Click += labelHistoria_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panelLaboratorio);
            Controls.Add(btnPLAY);
            Controls.Add(titleName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escape Room Digital";
            Load += Form1_Load;
            panelLaboratorio.ResumeLayout(false);
            panelLaboratorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picComputadora).EndInit();
            panelHistoria.ResumeLayout(false);
            panelHistoria.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleName;
        private Button btnPLAY;
        private Panel panelLaboratorio;
        private Panel panelHistoria;
        private Label labelHistoria;
        private Button btnEntendido;
        private Label labelContexto;
        private PictureBox picComputadora;
    }
}
