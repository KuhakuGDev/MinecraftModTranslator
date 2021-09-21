
namespace TraductorDeModsMC
{
    partial class MinecraftTranslator
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ModPathBut = new System.Windows.Forms.Button();
            this.SearchModId = new System.Windows.Forms.Timer(this.components);
            this.TranslatePathBut = new System.Windows.Forms.Button();
            this.StartBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModPathBut
            // 
            this.ModPathBut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModPathBut.BackgroundImage = global::TraductorDeModsMC.Properties.Resources.Button;
            this.ModPathBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ModPathBut.Location = new System.Drawing.Point(315, 247);
            this.ModPathBut.Name = "ModPathBut";
            this.ModPathBut.Size = new System.Drawing.Size(171, 40);
            this.ModPathBut.TabIndex = 1;
            this.ModPathBut.Text = "Seleccionar Mod";
            this.ModPathBut.UseVisualStyleBackColor = false;
            this.ModPathBut.Click += new System.EventHandler(this.SelectMod);
            // 
            // SearchModId
            // 
            this.SearchModId.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TranslatePathBut
            // 
            this.TranslatePathBut.BackgroundImage = global::TraductorDeModsMC.Properties.Resources.Button;
            this.TranslatePathBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TranslatePathBut.Enabled = false;
            this.TranslatePathBut.Location = new System.Drawing.Point(315, 307);
            this.TranslatePathBut.Name = "TranslatePathBut";
            this.TranslatePathBut.Size = new System.Drawing.Size(171, 41);
            this.TranslatePathBut.TabIndex = 2;
            this.TranslatePathBut.Text = "Traducción";
            this.TranslatePathBut.UseVisualStyleBackColor = true;
            this.TranslatePathBut.Click += new System.EventHandler(this.SelectLang);
            // 
            // StartBut
            // 
            this.StartBut.BackgroundImage = global::TraductorDeModsMC.Properties.Resources.Button;
            this.StartBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartBut.Enabled = false;
            this.StartBut.Location = new System.Drawing.Point(315, 365);
            this.StartBut.Name = "StartBut";
            this.StartBut.Size = new System.Drawing.Size(171, 39);
            this.StartBut.TabIndex = 3;
            this.StartBut.Text = "Traducir";
            this.StartBut.UseVisualStyleBackColor = true;
            this.StartBut.Click += new System.EventHandler(this.Translate);
            // 
            // MinecraftTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TraductorDeModsMC.Properties.Resources.H2x1_NSwitch_Minecraft_image1600w;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartBut);
            this.Controls.Add(this.TranslatePathBut);
            this.Controls.Add(this.ModPathBut);
            this.Name = "MinecraftTranslator";
            this.Text = "Traductor de Mods de Minecraft";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ModPathBut;
        private System.Windows.Forms.Timer SearchModId;
        private System.Windows.Forms.Button TranslatePathBut;
        private System.Windows.Forms.Button StartBut;
    }
}

