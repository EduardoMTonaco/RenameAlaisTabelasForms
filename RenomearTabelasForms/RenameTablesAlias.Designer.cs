namespace RenomearTabelasForms
{
    partial class RenameTablesAlias
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Replace = new System.Windows.Forms.Button();
            this.Txt_Command = new System.Windows.Forms.TextBox();
            this.Txt_Alias = new System.Windows.Forms.TextBox();
            this.Txt_Result = new System.Windows.Forms.TextBox();
            this.Mtx_Start = new System.Windows.Forms.MaskedTextBox();
            this.Mtx_End = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Alias = new System.Windows.Forms.Label();
            this.Lbl_Command = new System.Windows.Forms.Label();
            this.Lbl_Result = new System.Windows.Forms.Label();
            this.Lbl_Start = new System.Windows.Forms.Label();
            this.Lbl_End = new System.Windows.Forms.Label();
            this.Lbl_Numbers = new System.Windows.Forms.Label();
            this.Btn_Example = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Replace
            // 
            this.Btn_Replace.Font = new System.Drawing.Font("Times New Roman", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Replace.Location = new System.Drawing.Point(300, 543);
            this.Btn_Replace.Name = "Btn_Replace";
            this.Btn_Replace.Size = new System.Drawing.Size(164, 51);
            this.Btn_Replace.TabIndex = 0;
            this.Btn_Replace.Text = "Btn_Replace";
            this.Btn_Replace.UseVisualStyleBackColor = true;
            this.Btn_Replace.Click += new System.EventHandler(this.Btn_Replace_Click);
            // 
            // Txt_Command
            // 
            this.Txt_Command.Font = new System.Drawing.Font("Times New Roman", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Command.Location = new System.Drawing.Point(12, 248);
            this.Txt_Command.Multiline = true;
            this.Txt_Command.Name = "Txt_Command";
            this.Txt_Command.Size = new System.Drawing.Size(353, 270);
            this.Txt_Command.TabIndex = 1;
            this.Txt_Command.Text = "Txt_Command";
            // 
            // Txt_Alias
            // 
            this.Txt_Alias.Font = new System.Drawing.Font("Times New Roman", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Alias.Location = new System.Drawing.Point(12, 44);
            this.Txt_Alias.Name = "Txt_Alias";
            this.Txt_Alias.Size = new System.Drawing.Size(100, 25);
            this.Txt_Alias.TabIndex = 2;
            this.Txt_Alias.Text = "Txt_Alias";
            // 
            // Txt_Result
            // 
            this.Txt_Result.Font = new System.Drawing.Font("Times New Roman", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Result.Location = new System.Drawing.Point(397, 248);
            this.Txt_Result.Multiline = true;
            this.Txt_Result.Name = "Txt_Result";
            this.Txt_Result.ReadOnly = true;
            this.Txt_Result.Size = new System.Drawing.Size(353, 270);
            this.Txt_Result.TabIndex = 3;
            this.Txt_Result.Text = "Txt_Result";
            // 
            // Mtx_Start
            // 
            this.Mtx_Start.Font = new System.Drawing.Font("Times New Roman", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtx_Start.Location = new System.Drawing.Point(12, 167);
            this.Mtx_Start.Mask = "00";
            this.Mtx_Start.Name = "Mtx_Start";
            this.Mtx_Start.Size = new System.Drawing.Size(48, 25);
            this.Mtx_Start.TabIndex = 4;
            this.Mtx_Start.ValidatingType = typeof(int);
            // 
            // Mtx_End
            // 
            this.Mtx_End.Font = new System.Drawing.Font("Times New Roman", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtx_End.Location = new System.Drawing.Point(118, 167);
            this.Mtx_End.Mask = "00";
            this.Mtx_End.Name = "Mtx_End";
            this.Mtx_End.Size = new System.Drawing.Size(48, 25);
            this.Mtx_End.TabIndex = 5;
            this.Mtx_End.ValidatingType = typeof(int);
            // 
            // Lbl_Alias
            // 
            this.Lbl_Alias.AutoSize = true;
            this.Lbl_Alias.Font = new System.Drawing.Font("Times New Roman", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Alias.Location = new System.Drawing.Point(12, 18);
            this.Lbl_Alias.Name = "Lbl_Alias";
            this.Lbl_Alias.Size = new System.Drawing.Size(65, 17);
            this.Lbl_Alias.TabIndex = 6;
            this.Lbl_Alias.Text = "Lbl_Alias";
            // 
            // Lbl_Command
            // 
            this.Lbl_Command.AutoSize = true;
            this.Lbl_Command.Font = new System.Drawing.Font("Times New Roman", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Command.Location = new System.Drawing.Point(12, 218);
            this.Lbl_Command.Name = "Lbl_Command";
            this.Lbl_Command.Size = new System.Drawing.Size(95, 17);
            this.Lbl_Command.TabIndex = 7;
            this.Lbl_Command.Text = "Lbl_Command";
            // 
            // Lbl_Result
            // 
            this.Lbl_Result.AutoSize = true;
            this.Lbl_Result.Font = new System.Drawing.Font("Times New Roman", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Result.Location = new System.Drawing.Point(394, 218);
            this.Lbl_Result.Name = "Lbl_Result";
            this.Lbl_Result.Size = new System.Drawing.Size(72, 17);
            this.Lbl_Result.TabIndex = 8;
            this.Lbl_Result.Text = "Lbl_Result";
            // 
            // Lbl_Start
            // 
            this.Lbl_Start.AutoSize = true;
            this.Lbl_Start.Font = new System.Drawing.Font("Times New Roman", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Start.Location = new System.Drawing.Point(12, 138);
            this.Lbl_Start.Name = "Lbl_Start";
            this.Lbl_Start.Size = new System.Drawing.Size(63, 17);
            this.Lbl_Start.TabIndex = 9;
            this.Lbl_Start.Text = "Lbl_Start";
            // 
            // Lbl_End
            // 
            this.Lbl_End.AutoSize = true;
            this.Lbl_End.Font = new System.Drawing.Font("Times New Roman", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_End.Location = new System.Drawing.Point(115, 138);
            this.Lbl_End.Name = "Lbl_End";
            this.Lbl_End.Size = new System.Drawing.Size(58, 17);
            this.Lbl_End.TabIndex = 10;
            this.Lbl_End.Text = "Lbl_End";
            // 
            // Lbl_Numbers
            // 
            this.Lbl_Numbers.AutoSize = true;
            this.Lbl_Numbers.Font = new System.Drawing.Font("Times New Roman", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Numbers.Location = new System.Drawing.Point(9, 99);
            this.Lbl_Numbers.Name = "Lbl_Numbers";
            this.Lbl_Numbers.Size = new System.Drawing.Size(89, 17);
            this.Lbl_Numbers.TabIndex = 11;
            this.Lbl_Numbers.Text = "Lbl_Numbers";
            // 
            // Btn_Example
            // 
            this.Btn_Example.Font = new System.Drawing.Font("Times New Roman", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Example.Location = new System.Drawing.Point(601, 30);
            this.Btn_Example.Name = "Btn_Example";
            this.Btn_Example.Size = new System.Drawing.Size(164, 51);
            this.Btn_Example.TabIndex = 12;
            this.Btn_Example.Text = "Btn_Example";
            this.Btn_Example.UseVisualStyleBackColor = true;
            this.Btn_Example.Click += new System.EventHandler(this.Btn_Example_Click);
            // 
            // RenameTablesAlias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 660);
            this.Controls.Add(this.Btn_Example);
            this.Controls.Add(this.Lbl_Numbers);
            this.Controls.Add(this.Lbl_End);
            this.Controls.Add(this.Lbl_Start);
            this.Controls.Add(this.Lbl_Result);
            this.Controls.Add(this.Lbl_Command);
            this.Controls.Add(this.Lbl_Alias);
            this.Controls.Add(this.Mtx_End);
            this.Controls.Add(this.Mtx_Start);
            this.Controls.Add(this.Txt_Result);
            this.Controls.Add(this.Txt_Alias);
            this.Controls.Add(this.Txt_Command);
            this.Controls.Add(this.Btn_Replace);
            this.Name = "RenameTablesAlias";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Replace;
        private System.Windows.Forms.TextBox Txt_Command;
        private System.Windows.Forms.TextBox Txt_Alias;
        private System.Windows.Forms.TextBox Txt_Result;
        private System.Windows.Forms.MaskedTextBox Mtx_Start;
        private System.Windows.Forms.MaskedTextBox Mtx_End;
        private System.Windows.Forms.Label Lbl_Alias;
        private System.Windows.Forms.Label Lbl_Command;
        private System.Windows.Forms.Label Lbl_Result;
        private System.Windows.Forms.Label Lbl_Start;
        private System.Windows.Forms.Label Lbl_End;
        private System.Windows.Forms.Label Lbl_Numbers;
        private System.Windows.Forms.Button Btn_Example;
    }
}

