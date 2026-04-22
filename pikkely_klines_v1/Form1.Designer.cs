namespace pikkely_klines_v1
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
            btnTestConnection = new Button();
            lblResult = new Label();
            txtRawData = new TextBox();
            dgvProducts = new DataGridView();
            loadHullok = new Button();
            loadHalak = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // btnTestConnection
            // 
            btnTestConnection.Location = new Point(350, 12);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(1042, 46);
            btnTestConnection.TabIndex = 0;
            btnTestConnection.Text = "kapcsolat tesztelése";
            btnTestConnection.UseVisualStyleBackColor = true;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(350, 61);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(230, 32);
            lblResult.TabIndex = 1;
            lblResult.Text = "Várakozás a tesztre...";
            // 
            // txtRawData
            // 
            txtRawData.Location = new Point(658, 12);
            txtRawData.Multiline = true;
            txtRawData.Name = "txtRawData";
            txtRawData.ScrollBars = ScrollBars.Vertical;
            txtRawData.Size = new Size(876, 268);
            txtRawData.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(800, 12);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 82;
            dgvProducts.Size = new Size(860, 268);
            dgvProducts.TabIndex = 3;
            dgvProducts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // loadHullok
            // 
            loadHullok.Location = new Point(12, 12);
            loadHullok.Name = "loadHullok";
            loadHullok.Size = new Size(150, 46);
            loadHullok.TabIndex = 4;
            loadHullok.Text = "Hüllők";
            loadHullok.UseVisualStyleBackColor = true;
            loadHullok.Click += loadHullok_Click;
            // 
            // loadHalak
            // 
            loadHalak.Location = new Point(168, 12);
            loadHalak.Name = "loadHalak";
            loadHalak.Size = new Size(150, 46);
            loadHalak.TabIndex = 5;
            loadHalak.Text = "Halak";
            loadHalak.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(0, 346);
            panel1.Name = "panel1";
            panel1.Size = new Size(1670, 793);
            panel1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1672, 1139);
            Controls.Add(panel1);
            Controls.Add(loadHalak);
            Controls.Add(loadHullok);
            Controls.Add(dgvProducts);
            Controls.Add(txtRawData);
            Controls.Add(lblResult);
            Controls.Add(btnTestConnection);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTestConnection;
        private Label lblResult;
        private TextBox txtRawData;
        private DataGridView dgvProducts;
        private Button loadHullok;
        private Button loadHalak;
        private Panel panel1;
    }
}
