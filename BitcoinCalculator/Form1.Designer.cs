namespace BitcoinCalculator
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
            this.currencyselector = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bitcoinamountinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tulemuslabel = new System.Windows.Forms.Label();
            this.resultlabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currencyselector
            // 
            this.currencyselector.BackColor = System.Drawing.SystemColors.ControlLight;
            this.currencyselector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.currencyselector.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyselector.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.currencyselector.FormattingEnabled = true;
            this.currencyselector.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "EEK",
            "GBP"});
            this.currencyselector.Location = new System.Drawing.Point(329, 247);
            this.currencyselector.Name = "currencyselector";
            this.currencyselector.Size = new System.Drawing.Size(179, 26);
            this.currencyselector.TabIndex = 0;
            this.currencyselector.Text = "Select currency";
            this.currencyselector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(329, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate rate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bitcoinamountinput
            // 
            this.bitcoinamountinput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bitcoinamountinput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitcoinamountinput.Location = new System.Drawing.Point(329, 211);
            this.bitcoinamountinput.Name = "bitcoinamountinput";
            this.bitcoinamountinput.Size = new System.Drawing.Size(179, 20);
            this.bitcoinamountinput.TabIndex = 2;
            this.bitcoinamountinput.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(332, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Bitcoin amount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tulemuslabel
            // 
            this.tulemuslabel.AutoSize = true;
            this.tulemuslabel.BackColor = System.Drawing.Color.Transparent;
            this.tulemuslabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tulemuslabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tulemuslabel.Location = new System.Drawing.Point(332, 352);
            this.tulemuslabel.Name = "tulemuslabel";
            this.tulemuslabel.Size = new System.Drawing.Size(64, 18);
            this.tulemuslabel.TabIndex = 4;
            this.tulemuslabel.Text = "Result:";
            this.tulemuslabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // resultlabel
            // 
            this.resultlabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resultlabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultlabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.resultlabel.Location = new System.Drawing.Point(329, 373);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(179, 26);
            this.resultlabel.TabIndex = 5;
            this.resultlabel.Text = "Nothing here yet";
            this.resultlabel.TextChanged += new System.EventHandler(this.resultlabel_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BitcoinCalculator.Properties.Resources.unicorn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultlabel);
            this.Controls.Add(this.tulemuslabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitcoinamountinput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currencyselector);
            this.Name = "Form1";
            this.Text = "Bitcoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyselector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bitcoinamountinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tulemuslabel;
        private System.Windows.Forms.TextBox resultlabel;
    }
}

