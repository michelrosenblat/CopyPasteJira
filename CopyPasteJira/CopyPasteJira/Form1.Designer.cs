namespace CopyPasteJira
{
    partial class FormMain
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
            this.textBoxUserStoryFull = new System.Windows.Forms.TextBox();
            this.textBoxUserStoryCode = new System.Windows.Forms.TextBox();
            this.comboBoxPrefixo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxDescricao = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUserStoryFull
            // 
            this.textBoxUserStoryFull.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUserStoryFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUserStoryFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserStoryFull.Location = new System.Drawing.Point(10, 50);
            this.textBoxUserStoryFull.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxUserStoryFull.Multiline = true;
            this.textBoxUserStoryFull.Name = "textBoxUserStoryFull";
            this.textBoxUserStoryFull.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxUserStoryFull.Size = new System.Drawing.Size(374, 311);
            this.textBoxUserStoryFull.TabIndex = 0;
            this.textBoxUserStoryFull.TextChanged += new System.EventHandler(this.textBoxUserStoryFull_TextChanged);
            // 
            // textBoxUserStoryCode
            // 
            this.textBoxUserStoryCode.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUserStoryCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUserStoryCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserStoryCode.Location = new System.Drawing.Point(10, 50);
            this.textBoxUserStoryCode.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxUserStoryCode.Multiline = true;
            this.textBoxUserStoryCode.Name = "textBoxUserStoryCode";
            this.textBoxUserStoryCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUserStoryCode.Size = new System.Drawing.Size(362, 311);
            this.textBoxUserStoryCode.TabIndex = 1;
            // 
            // comboBoxPrefixo
            // 
            this.comboBoxPrefixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPrefixo.FormattingEnabled = true;
            this.comboBoxPrefixo.Items.AddRange(new object[] {
            "BIPBIP-",
            "SHOGUN-"});
            this.comboBoxPrefixo.Location = new System.Drawing.Point(69, 14);
            this.comboBoxPrefixo.Name = "comboBoxPrefixo";
            this.comboBoxPrefixo.Size = new System.Drawing.Size(139, 26);
            this.comboBoxPrefixo.TabIndex = 2;
            this.comboBoxPrefixo.Text = "BIPBIP-";
            this.comboBoxPrefixo.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrefixo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prefixo";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopy.Location = new System.Drawing.Point(10, 10);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.buttonCopy.MaximumSize = new System.Drawing.Size(131, 30);
            this.buttonCopy.MinimumSize = new System.Drawing.Size(131, 30);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(131, 30);
            this.buttonCopy.TabIndex = 4;
            this.buttonCopy.Text = "Copy to Clipboard";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.BackColor = System.Drawing.Color.LightGreen;
            this.buttonPaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaste.Location = new System.Drawing.Point(10, 10);
            this.buttonPaste.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.buttonPaste.MaximumSize = new System.Drawing.Size(186, 30);
            this.buttonPaste.MinimumSize = new System.Drawing.Size(186, 30);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(186, 30);
            this.buttonPaste.TabIndex = 5;
            this.buttonPaste.Text = "Paste User Stories from Jira";
            this.buttonPaste.UseVisualStyleBackColor = false;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxDescricao);
            this.panel1.Controls.Add(this.comboBoxPrefixo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 50);
            this.panel1.TabIndex = 6;
            // 
            // checkBoxDescricao
            // 
            this.checkBoxDescricao.AutoSize = true;
            this.checkBoxDescricao.Checked = true;
            this.checkBoxDescricao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDescricao.Location = new System.Drawing.Point(244, 18);
            this.checkBoxDescricao.Name = "checkBoxDescricao";
            this.checkBoxDescricao.Size = new System.Drawing.Size(216, 20);
            this.checkBoxDescricao.TabIndex = 4;
            this.checkBoxDescricao.Text = "Incluir descrição das User Story";
            this.checkBoxDescricao.UseVisualStyleBackColor = true;
            this.checkBoxDescricao.CheckedChanged += new System.EventHandler(this.checkBoxDescricao_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Size = new System.Drawing.Size(784, 371);
            this.splitContainer1.SplitterDistance = 394;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxUserStoryFull, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonPaste, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(150, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 371);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxUserStoryCode, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonCopy, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.MinimumSize = new System.Drawing.Size(150, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(382, 371);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "FormMain";
            this.Text = "JIRA Extract Stories";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserStoryFull;
        private System.Windows.Forms.TextBox textBoxUserStoryCode;
        private System.Windows.Forms.ComboBox comboBoxPrefixo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonPaste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxDescricao;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

