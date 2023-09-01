
namespace BaseDatos
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCarpetaBackcup = new System.Windows.Forms.TextBox();
            this.CmdCarpetaBackup = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtArchivoRestarurar = new System.Windows.Forms.TextBox();
            this.CmdArchivoRestaurar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CmdBackup = new System.Windows.Forms.Button();
            this.CmdRestaurar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CmbBDBackup = new System.Windows.Forms.ComboBox();
            this.CmbBDRestaurar = new System.Windows.Forms.ComboBox();
            this.TxtPuerto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.CmdActualizar = new System.Windows.Forms.Button();
            this.CmdSeleccionarCarpeta = new System.Windows.Forms.Button();
            this.TxtRuta = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRADOR DE BASES DE DATOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "BACKUP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Base de datos (MySQL) ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Carpeta respaldo";
            // 
            // TxtCarpetaBackcup
            // 
            this.TxtCarpetaBackcup.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCarpetaBackcup.Location = new System.Drawing.Point(158, 280);
            this.TxtCarpetaBackcup.Name = "TxtCarpetaBackcup";
            this.TxtCarpetaBackcup.Size = new System.Drawing.Size(279, 23);
            this.TxtCarpetaBackcup.TabIndex = 1;
            // 
            // CmdCarpetaBackup
            // 
            this.CmdCarpetaBackup.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCarpetaBackup.Location = new System.Drawing.Point(451, 278);
            this.CmdCarpetaBackup.Name = "CmdCarpetaBackup";
            this.CmdCarpetaBackup.Size = new System.Drawing.Size(65, 23);
            this.CmdCarpetaBackup.TabIndex = 2;
            this.CmdCarpetaBackup.Text = "Select";
            this.CmdCarpetaBackup.UseVisualStyleBackColor = true;
            this.CmdCarpetaBackup.Click += new System.EventHandler(this.CmdCarpetaBackup_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "RESTAURAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Base de datos (MySQL)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Base de datos";
            // 
            // TxtArchivoRestarurar
            // 
            this.TxtArchivoRestarurar.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArchivoRestarurar.Location = new System.Drawing.Point(158, 492);
            this.TxtArchivoRestarurar.Name = "TxtArchivoRestarurar";
            this.TxtArchivoRestarurar.Size = new System.Drawing.Size(279, 23);
            this.TxtArchivoRestarurar.TabIndex = 3;
            // 
            // CmdArchivoRestaurar
            // 
            this.CmdArchivoRestaurar.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdArchivoRestaurar.Location = new System.Drawing.Point(451, 490);
            this.CmdArchivoRestaurar.Name = "CmdArchivoRestaurar";
            this.CmdArchivoRestaurar.Size = new System.Drawing.Size(65, 23);
            this.CmdArchivoRestaurar.TabIndex = 2;
            this.CmdArchivoRestaurar.Text = "Select";
            this.CmdArchivoRestaurar.UseVisualStyleBackColor = true;
            this.CmdArchivoRestaurar.Click += new System.EventHandler(this.CmdArchivoRestaurar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 657);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dev Miqueas Quintanilla Ventura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(130, 642);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(274, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Copyright © 2023 Todos los derechos reservados";
            // 
            // CmdBackup
            // 
            this.CmdBackup.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdBackup.Location = new System.Drawing.Point(192, 309);
            this.CmdBackup.Name = "CmdBackup";
            this.CmdBackup.Size = new System.Drawing.Size(133, 32);
            this.CmdBackup.TabIndex = 4;
            this.CmdBackup.Text = "BACKUP";
            this.CmdBackup.UseVisualStyleBackColor = true;
            this.CmdBackup.Click += new System.EventHandler(this.CmdBackup_Click);
            // 
            // CmdRestaurar
            // 
            this.CmdRestaurar.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdRestaurar.Location = new System.Drawing.Point(192, 521);
            this.CmdRestaurar.Name = "CmdRestaurar";
            this.CmdRestaurar.Size = new System.Drawing.Size(133, 32);
            this.CmdRestaurar.TabIndex = 4;
            this.CmdRestaurar.Text = "RESTURAR";
            this.CmdRestaurar.UseVisualStyleBackColor = true;
            this.CmdRestaurar.Click += new System.EventHandler(this.CmdRestaurar_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(410, 33);
            this.label10.TabIndex = 0;
            this.label10.Text = "*Permite hacer un respaldo de la base de datos, se recomienda hacer semanalmente," +
    " pero ud podria hacerlo hasta diario.";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 563);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(401, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = "*Permite restaurar una base, se reemplazara toda la información con la base de da" +
    "tos seleccionada.";
            // 
            // CmbBDBackup
            // 
            this.CmbBDBackup.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBDBackup.FormattingEnabled = true;
            this.CmbBDBackup.Location = new System.Drawing.Point(158, 249);
            this.CmbBDBackup.Name = "CmbBDBackup";
            this.CmbBDBackup.Size = new System.Drawing.Size(279, 23);
            this.CmbBDBackup.TabIndex = 5;
            // 
            // CmbBDRestaurar
            // 
            this.CmbBDRestaurar.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBDRestaurar.FormattingEnabled = true;
            this.CmbBDRestaurar.Location = new System.Drawing.Point(158, 461);
            this.CmbBDRestaurar.Name = "CmbBDRestaurar";
            this.CmbBDRestaurar.Size = new System.Drawing.Size(279, 23);
            this.CmbBDRestaurar.TabIndex = 5;
            // 
            // TxtPuerto
            // 
            this.TxtPuerto.Location = new System.Drawing.Point(71, 68);
            this.TxtPuerto.Name = "TxtPuerto";
            this.TxtPuerto.Size = new System.Drawing.Size(42, 20);
            this.TxtPuerto.TabIndex = 3;
            this.TxtPuerto.Text = "3306";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Puerto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(142, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Usuario";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(191, 71);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(53, 20);
            this.TxtUsuario.TabIndex = 3;
            this.TxtUsuario.Text = "root";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(271, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Password";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(330, 71);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(97, 20);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.Text = "123456";
            // 
            // CmdActualizar
            // 
            this.CmdActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdActualizar.Location = new System.Drawing.Point(441, 69);
            this.CmdActualizar.Name = "CmdActualizar";
            this.CmdActualizar.Size = new System.Drawing.Size(65, 23);
            this.CmdActualizar.TabIndex = 2;
            this.CmdActualizar.Text = "Update";
            this.CmdActualizar.UseVisualStyleBackColor = true;
            this.CmdActualizar.Click += new System.EventHandler(this.CmdActualizar_Click);
            // 
            // CmdSeleccionarCarpeta
            // 
            this.CmdSeleccionarCarpeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.CmdSeleccionarCarpeta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.CmdSeleccionarCarpeta.FlatAppearance.BorderSize = 2;
            this.CmdSeleccionarCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSeleccionarCarpeta.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSeleccionarCarpeta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CmdSeleccionarCarpeta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdSeleccionarCarpeta.ImageKey = "Reporte";
            this.CmdSeleccionarCarpeta.Location = new System.Drawing.Point(450, 139);
            this.CmdSeleccionarCarpeta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdSeleccionarCarpeta.Name = "CmdSeleccionarCarpeta";
            this.CmdSeleccionarCarpeta.Size = new System.Drawing.Size(66, 28);
            this.CmdSeleccionarCarpeta.TabIndex = 26;
            this.CmdSeleccionarCarpeta.Text = "SELECCIONAR";
            this.CmdSeleccionarCarpeta.UseVisualStyleBackColor = false;
            // 
            // TxtRuta
            // 
            this.TxtRuta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtRuta.Location = new System.Drawing.Point(30, 144);
            this.TxtRuta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TxtRuta.Name = "TxtRuta";
            this.TxtRuta.Size = new System.Drawing.Size(407, 20);
            this.TxtRuta.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(27, 179);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(338, 14);
            this.label17.TabIndex = 24;
            this.label17.Text = "*Carpeta donde se almacenara, carperas de todos los reportes y demas.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(26, 114);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(145, 18);
            this.label18.TabIndex = 23;
            this.label18.Text = "CARPETA MATRIZ:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(534, 682);
            this.Controls.Add(this.CmdSeleccionarCarpeta);
            this.Controls.Add(this.TxtRuta);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CmbBDRestaurar);
            this.Controls.Add(this.CmbBDBackup);
            this.Controls.Add(this.CmdRestaurar);
            this.Controls.Add(this.CmdBackup);
            this.Controls.Add(this.CmdArchivoRestaurar);
            this.Controls.Add(this.CmdActualizar);
            this.Controls.Add(this.CmdCarpetaBackup);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.TxtPuerto);
            this.Controls.Add(this.TxtArchivoRestarurar);
            this.Controls.Add(this.TxtCarpetaBackcup);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCarpetaBackcup;
        private System.Windows.Forms.Button CmdCarpetaBackup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtArchivoRestarurar;
        private System.Windows.Forms.Button CmdArchivoRestaurar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CmdBackup;
        private System.Windows.Forms.Button CmdRestaurar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmbBDBackup;
        private System.Windows.Forms.ComboBox CmbBDRestaurar;
        private System.Windows.Forms.TextBox TxtPuerto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button CmdActualizar;
        private System.Windows.Forms.Button CmdSeleccionarCarpeta;
        private System.Windows.Forms.TextBox TxtRuta;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

