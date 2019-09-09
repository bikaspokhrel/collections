namespace collections
{
    partial class Form1
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
            this.lbxFruitList = new System.Windows.Forms.ListBox();
            this.txtFruit = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnlistFruit = new System.Windows.Forms.Button();
            this.btnaddFruit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxFruitList
            // 
            this.lbxFruitList.FormattingEnabled = true;
            this.lbxFruitList.ItemHeight = 16;
            this.lbxFruitList.Location = new System.Drawing.Point(92, 69);
            this.lbxFruitList.Name = "lbxFruitList";
            this.lbxFruitList.Size = new System.Drawing.Size(225, 292);
            this.lbxFruitList.TabIndex = 0;
            // 
            // txtFruit
            // 
            this.txtFruit.Location = new System.Drawing.Point(616, 151);
            this.txtFruit.Name = "txtFruit";
            this.txtFruit.Size = new System.Drawing.Size(100, 22);
            this.txtFruit.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnlistFruit
            // 
            this.btnlistFruit.Location = new System.Drawing.Point(526, 69);
            this.btnlistFruit.Name = "btnlistFruit";
            this.btnlistFruit.Size = new System.Drawing.Size(114, 43);
            this.btnlistFruit.TabIndex = 3;
            this.btnlistFruit.Text = "List Fruit";
            this.btnlistFruit.UseVisualStyleBackColor = true;
            this.btnlistFruit.Click += new System.EventHandler(this.BtnlistFruit_Click);
            // 
            // btnaddFruit
            // 
            this.btnaddFruit.Location = new System.Drawing.Point(652, 69);
            this.btnaddFruit.Name = "btnaddFruit";
            this.btnaddFruit.Size = new System.Drawing.Size(136, 43);
            this.btnaddFruit.TabIndex = 4;
            this.btnaddFruit.Text = "Add Fruit";
            this.btnaddFruit.UseVisualStyleBackColor = true;
            this.btnaddFruit.Click += new System.EventHandler(this.BtnaddFruit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnaddFruit);
            this.Controls.Add(this.btnlistFruit);
            this.Controls.Add(this.txtFruit);
            this.Controls.Add(this.lbxFruitList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxFruitList;
        private System.Windows.Forms.TextBox txtFruit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnlistFruit;
        private System.Windows.Forms.Button btnaddFruit;
    }
}

