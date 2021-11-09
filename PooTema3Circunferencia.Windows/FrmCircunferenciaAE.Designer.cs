
namespace PooTema3Circunferencia.Windows
{
    partial class FrmCircunferenciaAE
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
            this.label1 = new System.Windows.Forms.Label();
            this.RadioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BordeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RellenoComboBox = new System.Windows.Forms.ComboBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CancelarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RadioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radio:";
            // 
            // RadioNumericUpDown
            // 
            this.RadioNumericUpDown.Location = new System.Drawing.Point(124, 55);
            this.RadioNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RadioNumericUpDown.Name = "RadioNumericUpDown";
            this.RadioNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.RadioNumericUpDown.TabIndex = 1;
            this.RadioNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Borde:";
            // 
            // BordeComboBox
            // 
            this.BordeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BordeComboBox.FormattingEnabled = true;
            this.BordeComboBox.Location = new System.Drawing.Point(124, 96);
            this.BordeComboBox.Name = "BordeComboBox";
            this.BordeComboBox.Size = new System.Drawing.Size(121, 21);
            this.BordeComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Relleno:";
            // 
            // RellenoComboBox
            // 
            this.RellenoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RellenoComboBox.FormattingEnabled = true;
            this.RellenoComboBox.Location = new System.Drawing.Point(124, 138);
            this.RellenoComboBox.Name = "RellenoComboBox";
            this.RellenoComboBox.Size = new System.Drawing.Size(121, 21);
            this.RellenoComboBox.TabIndex = 2;
            // 
            // OkButton
            // 
            this.OkButton.Image = global::PooTema3Circunferencia.Windows.Properties.Resources.Guardar;
            this.OkButton.Location = new System.Drawing.Point(28, 195);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(79, 57);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Image = global::PooTema3Circunferencia.Windows.Properties.Resources.Cancelar;
            this.CancelarButton.Location = new System.Drawing.Point(209, 195);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(79, 57);
            this.CancelarButton.TabIndex = 3;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // FrmCircunferenciaAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 292);
            this.ControlBox = false;
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.RellenoComboBox);
            this.Controls.Add(this.BordeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RadioNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(335, 331);
            this.MinimumSize = new System.Drawing.Size(335, 331);
            this.Name = "FrmCircunferenciaAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCircunferenciaAE";
            ((System.ComponentModel.ISupportInitialize)(this.RadioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown RadioNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BordeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox RellenoComboBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}